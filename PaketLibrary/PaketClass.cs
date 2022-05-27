using Newtonsoft.Json;
using System;

namespace PaketLibrary
{
    public class PaketClass
    {
        public static string Invoke()
        {
            return $"PaketClass.Invoke() is invoked  [{JsonConvert.SerializeObject(DateTime.Now)}]";
        }
    }
}
