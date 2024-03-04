using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level31_TheFountainOfObjects
{
    public static class ConsoleChanger
    {
       public static void WriteLine(string text, ConsoleColor color) 
       {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
       }
        public static void Write(string text, ConsoleColor color) 
       {
            Console.ForegroundColor = color;
            Console.Write(text);
       }
    }
}
