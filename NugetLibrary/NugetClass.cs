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
    }
}
