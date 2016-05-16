using System;
using NLog;

namespace GeneralSys.Infrastructure.Log
{
    public static class LoggerFactory
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();
        /// <summary>
		/// IsDebugEnabled
		/// </summary>
		public static bool IsDebugEnabled => Log.IsDebugEnabled;

        /// <summary>
        /// GetLogger
        /// </summary>
        /// <param name="loggerName"></param>
        /// <returns></returns>
        public static Logger GetLogger(string loggerName)
        {
            return LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// GetLogger
        /// </summary>
        /// <param name="loggerName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Logger GetLogger(string loggerName, Type type)
        {
            return LogManager.GetLogger(loggerName, type);
        }

        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(object message)
        {
            Log.Debug(message);
        }

        /// <summary>
        ///  DebugFormat
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void DebugFormat(string format, params object[] args)
        {
            Log.Debug(format, args);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        public static void Error(object message)
        {
            Log.Error(message);
        }

        /// <summary>
        /// ErrorFormat
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void ErrorFormat(string format, params object[] args)
        {
            Log.Error(format, args);
        }

        /// <summary>
        /// Info
        /// </summary>
        /// <param name="message"></param>
        public static void Info(object message)
        {
            Log.Info(message);
        }

        /// <summary>
        /// InfoFormat
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void InfoFormat(string format, params object[] args)
        {
            Log.Info(format, args);
        }
    }
}
