using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        string outputFileName;

        public FilePrinter(string outputFileName)
        {
            this.outputFileName = outputFileName;
        }

        public void Print(string s)
        {
            File.WriteAllText(outputFileName, s);
        }
    }
}
