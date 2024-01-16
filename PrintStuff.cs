using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2CSharpFun
{
    internal class PrintStuff
    {
        //must be here so its scope is for everything in here
        private string language;

        //constructor
        public PrintStuff ()
        {
            language = "EN";
        }
        public PrintStuff(string temp) 
        {
            language = temp;
        }
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }
        public void PrintName()
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, John or Jane Doe!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, John ou Jane Doe");
            }
        }
    }
}
