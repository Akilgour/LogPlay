using NLog;
using NLog.Targets;

namespace LogPlay.Logging
{
    public static class LogFourNet
    {
        public static void Configure()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget() { FileName = "file.txt", Name = "logfile" };
            logfile.Layout = "Level        : ${level} ${newline}When         : ${longdate} ${newline}Message      : ${message} ${newline}Machine Name : ${machinename} ${newline}Stack Trace  : ${stacktrace} ${newline} ";
        

    //            layout type = "log4net.Layout.PatternLayout" >
    //< IgnoresException value = "False" />

            // ...


            config.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Error, logfile));
            config.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Info, logfile));

            logfile.ArchiveEvery = FileArchivePeriod.Day;
            logfile.ArchiveNumbering = ArchiveNumberingMode.Rolling;
            logfile.ConcurrentWrites = true;
            logfile.KeepFileOpen = false;
            logfile.ArchiveDateFormat = "yyyyMMdd";
            
            LogManager.Configuration = config;
        }
    }
}