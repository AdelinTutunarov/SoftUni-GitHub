namespace Logger.Core.Utilities
{
    using System.Globalization;

    public static class DateTimeValidator
    {
        private static string validFormat = "MM/dd/yyyy HH:mm:ss tt";

        public static bool IsDateTimeValid(string dateTime)
        {
            return DateTime.TryParse(dateTime, out DateTime result);
        }
    }
}
