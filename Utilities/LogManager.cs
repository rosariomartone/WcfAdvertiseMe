using System;

namespace Utilities
{
    public static class LogManager
    {
        private static log4net.ILog _logger;
        private static log4net.ILog logger
        {
            get
            {
                if (_logger != null)
                    return _logger;
                else
                {
                    log4net.Config.XmlConfigurator.Configure();
                    _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                    return _logger;
                }
            }
        }

        public static void LogError(Exception ex, string fullNamespace, string className, string methodName, string message)
        {
            if (ex != null)
                Console.WriteLine(ex.Message);
            Console.WriteLine("Namespace: " + fullNamespace + ", Class: " + className + ", Method: " + methodName + ", Message: " + message, ex);
            logger.Error("DateTime: " + DateTime.Now.ToString() + " Namespace: " + fullNamespace + ", Class: " + className + ", Method: " + methodName + ", Message: " + message, ex);
            Console.WriteLine(" ");
            logger.Error(" ");
        }
    }
}
