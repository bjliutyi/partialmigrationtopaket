using Newtonsoft.Json;
using System;
using Serilog;

namespace PaketLibrary
{
    public class PaketClass
    {
        public static string Invoke()
        {
            return $"PaketClass.Invoke() is invoked  [{JsonConvert.SerializeObject(DateTime.Now)}]";
        }
        public static void InvokeLogger(string log)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("=== START ===");
            Log.Information($"PaketLibrary.InvokeLogger: {log}");
            Log.Information("=== END ===");

        }
    }
}
