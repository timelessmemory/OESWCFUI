
namespace OesUI.utils
{
    public static class EscapeSpecialCharacter
    {
        public static string EscapeDatabaseCharacter(string input)
        {
            if (input.IndexOf("'") != -1)
            {
               input = input.Replace("'", "\\'");
            }
            else if (input.IndexOf("[") != -1)
            {
                input = input.Replace("[", "\\[");
            }
            else if (input.IndexOf("_") != -1)
            {
                input = input.Replace("_", "\\_");
            }
            else if (input.IndexOf("%") != -1)
            {
                input = input.Replace("%", "\\%");
            }
            else if (input.IndexOf("\\") != -1)
            {
                input = input.Replace("\\", "\\\\");
            }
            return input;
        }
    }
}
