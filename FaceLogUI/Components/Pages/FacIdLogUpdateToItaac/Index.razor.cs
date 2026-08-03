using Domain.AttendanceServiceRespDTO;
using FaceLogUI.Service;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace FaceLogUI.Components.Pages.FacIdLogUpdateToItaac;

public partial class Index
{
    [Inject]
    private AccessLogApiClient ApiClient { get; set; } = null!;

    [Inject]
    private NotificationService NotificationService { get; set; } = null!;

    private readonly SearchModel search = new();
    private IReadOnlyList<AccessLogDTO> logs = [];
    private readonly HashSet<AccessLogDTO> selected = [];
    private bool isLoading;

    private async Task SearchAsync()
    {
        if (string.IsNullOrWhiteSpace(search.Cpr) && string.IsNullOrWhiteSpace(search.CostCenter))
        {
            Notify(NotificationSeverity.Warning, "Search criteria required", "Enter either a CPR number or a cost center.");
            return;
        }

        if (search.FromDate > search.ToDate)
        {
            Notify(NotificationSeverity.Warning, "Invalid date range", "From date cannot be after to date.");
            return;
        }

        isLoading = true;
        selected.Clear();
        try
        {
            var employeeResponse = await ApiClient.GetEmployeesAsync(search.CostCenter, search.Cpr);
            var cprs = employeeResponse.lstData?
                .Select(employee => employee.CprNo)
                .Where(cpr => !string.IsNullOrWhiteSpace(cpr))
                .Select(cpr => cpr!)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList() ?? [];
            if (employeeResponse.RESPONSE_CODE != "001" || cprs.Count == 0)
            {
                logs = [];
                Notify(NotificationSeverity.Warning, "Unable to load employees",
                    employeeResponse.RESPONSE_DESCRPTION ?? "No CPR numbers matched the supplied filters.");
                return;
            }

            var response = await ApiClient.GetByCprsAsync(cprs, search.FromDate, search.ToDate);
            logs = (response.lstData ?? [])
                .OrderBy(log => log.EmpId)
                .ThenBy(log => log.AccessDateTime)
                .ToList();
            if (logs.Count > 0)
            {
                var itaacResponse = await ApiClient.GetItaacStatusAsync(logs);
                if (itaacResponse.RESPONSE_CODE == "001")
                {
                    var updatedKeys = (itaacResponse.lstData ?? [])
                        .Where(item => item.IsAvailable)
                        .Select(item => $"{item.Cpr}|{item.LogDate} {item.LogTime}")
                        .ToHashSet(StringComparer.OrdinalIgnoreCase);
                    foreach (var log in logs)
                    {
                        var date = log.AccessDate ?? DateOnly.FromDateTime(log.AccessDateTime);
                        var time = log.AccessTime ?? TimeOnly.FromDateTime(log.AccessDateTime);
                        log.ItaacUpdated = updatedKeys.Contains(
                            $"{log.EmpId}|{date:yyyy-MM-dd} {time:HH:mm:ss}");
                    }
                }
                else
                {
                    Notify(NotificationSeverity.Error, "Unable to check ITAAC status",
                        itaacResponse.RESPONSE_DESCRPTION ?? "The ITAAC status service did not return a message.");
                }
            }
            var severity = response.RESPONSE_CODE switch
            {
                "001" => NotificationSeverity.Success,
                "003" => NotificationSeverity.Warning,
                _ => NotificationSeverity.Error
            };
            Notify(severity,
                severity == NotificationSeverity.Success ? "Success" : "Unable to load logs",
                response.RESPONSE_DESCRPTION ?? "The attendance service did not return a message.");
        }
        finally
        {
            isLoading = false;
        }
    }

    private void SetSelected(AccessLogDTO log, bool value)
    {
        if (value && !log.ItaacUpdated)
            selected.Add(log);
        else
            selected.Remove(log);
    }

    private async Task PushToItaacAsync()
    {
        var pendingLogs = (selected.Count > 0 ? selected : logs)
            .Where(log => !log.ItaacUpdated)
            .ToList();
        if (pendingLogs.Count == 0)
        {
            Notify(NotificationSeverity.Info, "Nothing to push", "All displayed attendance logs are already updated in ITAAC.");
            return;
        }

        var invalidCprs = pendingLogs.Where(log => !decimal.TryParse(log.EmpId,
            System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out _)).ToList();
        if (invalidCprs.Count > 0)
        {
            Notify(NotificationSeverity.Error, "Unable to push logs",
                $"{invalidCprs.Count} attendance log(s) have a missing or invalid CPR number.");
            return;
        }

        isLoading = true;
        try
        {
            var result = await ApiClient.PushToItaacAsync(pendingLogs);
            Notify(NotificationSeverity.Success, "ITAAC update completed", result.Message);
            await SearchAsync();
        }
        catch (Exception ex)
        {
            Notify(NotificationSeverity.Error, "ITAAC update failed", ex.Message);
        }
        finally
        {
            isLoading = false;
        }
    }

    private void Notify(NotificationSeverity severity, string summary, string detail) =>
        NotificationService.Notify(severity, summary, detail, 5000);

    private sealed class SearchModel
    {
        public string Cpr { get; set; } = string.Empty;
        public string CostCenter { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Today;
        public DateTime ToDate { get; set; } = DateTime.Today;
    }
}
