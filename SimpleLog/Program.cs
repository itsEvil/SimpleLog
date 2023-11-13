namespace SimpleLog
{
    internal class Program
    {
        static void Main(string[] args) {
            
            SLog.Debug("debug");
            SLog.Trace("trace");
            SLog.Info("info");
            SLog.Error("error");
            SLog.Fatal(new Exception("fatal"), false); //This will spam your logs directory 

            SLog.Info($"SLog::Config");
            SLog.Info($"MinLevel::{SLogConfig.MinLevel}");
            SLog.Info($"SleepTime::{SLogConfig.SleepTime}");
            SLog.Info($"ExportErrors::{SLogConfig.ExportErrors}");

            Console.ReadLine();
        }
    }
}
