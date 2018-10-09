using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;

namespace FinancialPlanner.Common
{
    public static class Logger
    {

        public const string ConfigFileName = "log4net.config";
        static log4net.ILog _log;

        public static void LogInfo(object message)
        {
            Configure();
            _log.Info(message);
        }

        public static void LogDebug(object message)
        {
            Configure();
            _log.Debug(message);
        }

        public static void LogDebug(DebuggerLogInfo debuggerLoginfo)
        {
            Configure();
            _log.Debug("Class: " + debuggerLoginfo.ClassName + Environment.NewLine +
                "Method: " + debuggerLoginfo.Method + Environment.NewLine + 
                "Exception: " + debuggerLoginfo.ExceptionInfo);
        }

        private static void Configure()
        {
            Type type = typeof(Logger);
            string path = AppDomain.CurrentDomain.BaseDirectory;
            FileInfo configFile = new FileInfo(Path.Combine(path,ConfigFileName));
            XmlConfigurator.ConfigureAndWatch(configFile);

            _log  = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            _log.ToString();
        }
    }

    public class DebuggerLogInfo
    {
        public string ClassName;
        public string Method;
        public Exception ExceptionInfo;
    }
}
