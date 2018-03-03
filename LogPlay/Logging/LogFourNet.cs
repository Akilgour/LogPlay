using NLog;

namespace LogPlay.Logging
{
    public static class LogFourNet
    {
        public static void Configure()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget() { FileName = "file.txt", Name = "logfile" };
            config.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Error, logfile));
            LogManager.Configuration = config;
        }
    }
}