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
    private IReadOnlyList<BiostarLogDTO> biostarLogs = [];
    //private readonly HashSet<BiostarLogDTO> selectedBiostar = [];
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
        //selectedBiostar.Clear();
        try
        {
            var employeeResponse = await ApiClient.GetEmployeesAsync(search.CostCenter, search.Cpr);
            var cprs = employeeResponse.lstData?
                .Select(employee => employee.EmpNo)
                .Where(cpr => !string.IsNullOrWhiteSpace(cpr))
                .Select(cpr => cpr!)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList() ?? [];
            if (employeeResponse.RESPONSE_CODE != "001" || cprs.Count == 0)
            {
                logs = [];
                biostarLogs = [];
                Notify(NotificationSeverity.Warning, "Unable to load employees",
                    employeeResponse.RESPONSE_DESCRPTION ?? "No CPR numbers matched the supplied filters.");
                return;
            }

            var response = await ApiClient.GetByCprsAsync(cprs, search.FromDate, search.ToDate);
            logs = (response.lstData ?? [])
                .OrderBy(log => log.EmpId)
                .ThenBy(log => log.AccessDateTime)
                .ToList();
            await ApplyItaacStatusAsync(logs);

            //var biostarResponse = await ApiClient.GetBiostarByCprsAsync(cprs, search.FromDate, search.ToDate);
            //biostarLogs = (biostarResponse.lstData ?? [])
            //    .OrderBy(log => log.Cpr)
            //    .ThenBy(log => log.AttendanceDate)
            //    .ThenBy(log => log.AttendanceTime)
            //    .ToList();
            //await ApplyBiostarItaacStatusAsync(biostarLogs);
            //var severity = response.RESPONSE_CODE switch
            //{
            //    "001" => NotificationSeverity.Success,
            //    "003" => NotificationSeverity.Warning,
            //    _ => NotificationSeverity.Error
            //};
            //Notify(severity,
            //    severity == NotificationSeverity.Success ? "Face ID logs loaded" : "Unable to load Face ID logs",
            //    response.RESPONSE_DESCRPTION ?? "The attendance service did not return a message.");

            //var biostarSeverity = biostarResponse.RESPONSE_CODE switch
            //{
            //    "001" => NotificationSeverity.Success,
            //    "003" => NotificationSeverity.Warning,
            //    _ => NotificationSeverity.Error
            //};
            //Notify(biostarSeverity,
            //    biostarSeverity == NotificationSeverity.Success ? "Biostar logs loaded" : "Unable to load Biostar logs",
            //    biostarResponse.RESPONSE_DESCRPTION ?? "The attendance service did not return a message.");
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

    private async Task PushFaceLogsToItaacAsync()
    {
        IEnumerable<AccessLogDTO> logsToPush = selected.Count > 0 ? selected : logs;
        var pendingLogs = logsToPush
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

    //private void SetBiostarSelected(BiostarLogDTO log, bool value)
    //{
    //    if (value && !log.ItaacUpdated)
    //        selectedBiostar.Add(log);
    //    else
    //        selectedBiostar.Remove(log);
    //}

    //private async Task PushBiostarLogsToItaacAsync()
    //{
    //    IEnumerable<BiostarLogDTO> logsToPush = selectedBiostar.Count > 0 ? selectedBiostar : biostarLogs;
    //    var pendingLogs = logsToPush.Where(log => !log.ItaacUpdated).ToList();
    //    if (pendingLogs.Count == 0)
    //    {
    //        Notify(NotificationSeverity.Info, "Nothing to push", "All displayed Biostar logs are already updated in ITAAC.");
    //        return;
    //    }

    //    var convertedLogs = pendingLogs.Select(ToAccessLog).ToList();
    //    if (convertedLogs.Any(log => log == null))
    //    {
    //        Notify(NotificationSeverity.Error, "Unable to push logs",
    //            "One or more Biostar logs have an invalid CPR, attendance date, or attendance time.");
    //        return;
    //    }

    //    isLoading = true;
    //    try
    //    {
    //        var result = await ApiClient.PushToItaacAsync(convertedLogs.Cast<AccessLogDTO>());
    //        Notify(NotificationSeverity.Success, "ITAAC update completed", result.Message);
    //        await SearchAsync();
    //    }
    //    catch (Exception ex)
    //    {
    //        Notify(NotificationSeverity.Error, "ITAAC update failed", ex.Message);
    //    }
    //    finally
    //    {
    //        isLoading = false;
    //    }
    //}

    private async Task ApplyItaacStatusAsync(IEnumerable<AccessLogDTO> attendanceLogs)
    {
        var logList = attendanceLogs.ToList();
        if (logList.Count == 0)
            return;

        var response = await ApiClient.GetItaacStatusAsync(logList);
        if (response.RESPONSE_CODE != "001")
        {
            Notify(NotificationSeverity.Error, "Unable to check ITAAC status",
                response.RESPONSE_DESCRPTION ?? "The ITAAC status service did not return a message.");
            return;
        }

        var updatedKeys = (response.lstData ?? []).Where(item => item.IsAvailable)
            .Select(item => $"{item.Cpr}|{item.LogDate} {item.LogTime}")
            .ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var log in logList)
        {
            var date = log.AccessDate ?? DateOnly.FromDateTime(log.AccessDateTime);
            var time = log.AccessTime ?? TimeOnly.FromDateTime(log.AccessDateTime);
            log.ItaacUpdated = updatedKeys.Contains($"{log.EmpId}|{date:yyyy-MM-dd} {time:HH:mm:ss}");
        }
    }

    //private async Task ApplyBiostarItaacStatusAsync(IEnumerable<BiostarLogDTO> attendanceLogs)
    //{
    //    var pairs = attendanceLogs.Select(log => (Source: log, Converted: ToAccessLog(log)))
    //        .Where(pair => pair.Converted != null).ToList();
    //    await ApplyItaacStatusAsync(pairs.Select(pair => pair.Converted!));
    //    foreach (var pair in pairs)
    //        pair.Source.ItaacUpdated = pair.Converted!.ItaacUpdated;
    //}

    //private static AccessLogDTO? ToAccessLog(BiostarLogDTO log)
    //{
    //    if (string.IsNullOrWhiteSpace(log.Cpr) || log.AttendanceDate == null
    //        || !TimeOnly.TryParseExact(log.AttendanceTime, "HH:mm:ss",
    //            System.Globalization.CultureInfo.InvariantCulture,
    //            System.Globalization.DateTimeStyles.None, out var time))
    //        return null;

    //    var date = DateOnly.FromDateTime(log.AttendanceDate.Value);
    //    return new AccessLogDTO
    //    {
    //        EmpId = log.Cpr,
    //        AccessDate = date,
    //        AccessTime = time,
    //        AccessDateTime = date.ToDateTime(time),
    //        DevSn = log.DeviceId,
    //        DevName = log.DeviceName,
    //        EmpFirstName = string.Empty
    //    };
    //}

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
