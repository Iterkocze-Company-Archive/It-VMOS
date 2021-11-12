using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosKernel2
{
    public static class Help
    {
        public static void ShowHelp()
        { 
            Console.Clear();
            Console.WriteLine("calc - Opens Calculator Menu.");
            Console.WriteLine("benchmark - Runs Benchmark.");
            Console.WriteLine("systeminfo - Shows Info About System.");
            Console.WriteLine("shutdown - Powers The PC Off.");
            Console.WriteLine("reboot - Reboots The PC.");
            Console.WriteLine("help - Shows This Message.");
            Console.WriteLine("fcreate {filename} - Creates A File of name 'filename'.");
            Console.WriteLine("dir - Shows All Files.");
            Console.WriteLine("fdelete {filename} - Delates A File Of Name 'filename'.");
            Console.WriteLine("cls/clear - Clears The Screen.");
            Console.WriteLine("fopen - Shows Contents Of The File 'filename'.");
            Console.WriteLine("fedit {filename} - Opens A File Of Name 'filename' In Text Editor.");
            Console.WriteLine("color - Shows Color Menu.");
            Console.WriteLine("date - Shows Current Date.");
        }
    }
}
