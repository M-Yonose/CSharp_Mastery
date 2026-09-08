using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClass
{
    public static class OutputFormatter
    {
        private static int _count;
        static OutputFormatter()
        {
            _count = 0;
        }
        public static void FormatMessage(string message, int serial )
        {
            Console.WriteLine($"{serial}: {message}");    
        }

        public static void FormatMessageWithHeading(string message, int serial, string heading)
        {
            Console.WriteLine($"==========={heading}===========");
            Console.WriteLine($"{serial}: {message}");
        }
        
    }
}
