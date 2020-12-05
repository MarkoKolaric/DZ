using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
