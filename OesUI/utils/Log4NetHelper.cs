using System;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4Net.config", ConfigFileExtension = "config", Watch = true)]
namespace OesUI.utils
{
    public static class Log4NetHelper
    {
        /// <summary>
        /// Print log to Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region

        public static void WriteErrorLog(Type t, Exception ex)
        {
            ILog log = LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        #endregion

        /// <summary>
        /// Print log to Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        #region

        public static void WriteInfoLog(Type t, string msg)
        {
            ILog log = LogManager.GetLogger(t);
            log.Info(msg);
        }

        #endregion
    }
}
