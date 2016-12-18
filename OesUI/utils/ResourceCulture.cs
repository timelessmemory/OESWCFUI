using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace OesUI.utils
{
    public class ResourceCulture
    {
        private const string english = "en-US";
        private const string fileName = "OesUI.language.Oes";

        /// <summary>
        /// Set current culture by name
        /// </summary>
        /// <param name="name">name</param>
        public static void SetCurrentCulture(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = english;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(name);
        }

        /// <summary>
        /// Get string by id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>current language string</returns>
        public static string GetString(string id)
        {
            string strCurLanguage = string.Empty;
            try
            {
                ResourceManager rm = new ResourceManager(fileName, Assembly.GetExecutingAssembly());
                CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                strCurLanguage = rm.GetString(id, ci);
            }
            catch
            {
                strCurLanguage = "No id: " + id + ", please add.";
            }
            return strCurLanguage;
        }
    }
}
