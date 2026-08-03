using System.Globalization;

namespace DataAccess.Repository;

internal static class DateRangeParser
{
    private static readonly string[] SupportedFormats = ["yyyy-MM-dd", "dd-MM-yyyy"];

    internal static (DateTime StartOfDay, DateTime EndDateExclusive) Parse(
        string? fromDate,
        string? toDate)
    {
        var startDate = ParseDate(fromDate, nameof(fromDate), "From date");
        var endDate = ParseDate(toDate, nameof(toDate), "To date");

        if (endDate < startDate)
        {
            throw new ArgumentException("To date cannot be earlier than from date.", nameof(toDate));
        }

        return (
            startDate.ToDateTime(TimeOnly.MinValue),
            endDate.AddDays(1).ToDateTime(TimeOnly.MinValue));
    }

    private static DateOnly ParseDate(string? value, string parameterName, string displayName)
    {
        if (DateOnly.TryParseExact(
                value?.Trim(),
                SupportedFormats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var date))
        {
            return date;
        }

        throw new ArgumentException(
            $"{displayName} must use yyyy-MM-dd or dd-MM-yyyy format.",
            parameterName);
    }
}
