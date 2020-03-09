using System;

namespace MultiArchNuget
{
    public static class Logger
    {
        private static string _prefix = "N/A";


        public static void Log(string msg)
        {
#if DEBUG86
            _prefix = "Debug-x86";
#elif DEBUG64
            _prefix = "Debug-x64";
#elif RELEASE86
            _prefix = "Release-x86";
#elif RELEASE64
            _prefix = "Release-x64";
#endif

            Console.WriteLine($"{_prefix}: {msg}");
        }
    }
}
