using NLog;
using System;

namespace oms_test_framework_dotNET.Utils
{
    public class LoggerNLog
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogInfo(String testName)
        {
            logger.Log(LogLevel.Info, "Test passed: {0}", testName);
        }

        public static void LogPass(String value)
        {
            logger.Log(LogLevel.Info, value);
        }

        public static void LogFail(String message, String testName, String screenshotFileName)
        {
            logger.Log(LogLevel.Error, "'{0}' in test: '{1}' ScreenShot name: {2} ",
                message, testName, screenshotFileName);
        }

        public static void LogFail(String message)
        {
            logger.Log(LogLevel.Error, message);
        }
    }
}
