using System;
using MetroLog;

namespace Bulksign
{
	public static class Logger
	{
		private static ILogger log = LogManagerFactory.DefaultLogManager.GetLogger("Log");


		public static void Fatal(Exception ex)
		{
			log.Fatal("", ex);
		}

		public static void Error(Exception ex)
		{
			log.Error("", ex);
		}

		public static void Error(string message)
		{
			log.Error(message);
		}

		public static void Error(string message, Exception ex)
		{
			log.Error(message, ex);
		}

		public static void Debug(string message)
		{
			log.Debug(message);
		}
	}
}