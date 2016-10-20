using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Utils
{
    public class LoggerNLog
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(String testClassName)
        {
            logger.Log(LogLevel.Info, "Test passed: {0}", testClassName);
        }

        public void LogFail(String exceptionMessage, String testClassName, String screenshotPath)
        {
            logger.Log(LogLevel.Error, "The assertation error occurred: '{0}' in test class: '{1}', screenshot: {2} ", exceptionMessage, testClassName, screenshotPath);
        }
    }
}
