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
        if (value)
            selected.Add(log);
        else
            selected.Remove(log);
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
