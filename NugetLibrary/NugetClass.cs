using Newtonsoft.Json;
using System;

namespace NugetLibrary
{
    public static class NugetClass
    {
        public static string Invoke()
        {
            return $"NugetClass.Invoke() is invoked [{JsonConvert.SerializeObject(DateTime.Now)}]";
        }
        public static string InvokeJS(string js)
        {
            var engine = new Jurassic.ScriptEngine();
            return engine.Evaluate<int>("5 * 10 + 2").ToString();
        }
    }
}
