using NLog;
using System;

namespace oms_test_framework_dotNET.Utils
{
    public class LoggerNLog
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(String testClassName)
        {
            logger.Log(LogLevel.Info, "Test passed: {0}", testClassName);
        }

        public void LogFail(String message, String testClassName, String screenshotFileName)
        {
            logger.Log(LogLevel.Error, "The assertation error occurred: '{0}' in test class: '{1}' ScreenShot name: {2} ", message, testClassName, screenshotFileName);
        }
    }
}
