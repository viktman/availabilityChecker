

namespace availabilityChecker
{
    public static class Util
    {
        public static int TickCounter = 30;
        public static string ClearString(string dirtyString)
        {
            string cleanString = System.Text.RegularExpressions.Regex.Replace(dirtyString, @"\s+", " ");
            cleanString = System.Text.RegularExpressions.Regex.Replace(cleanString, @"&nbsp;", "");
            cleanString = cleanString.Trim();

            return cleanString;
        }
    }
}
