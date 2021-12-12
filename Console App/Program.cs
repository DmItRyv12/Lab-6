using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = @"Hello \n\\\\world\";
            Console.WriteLine(s);   
            Console.ReadKey();  
        }
    }
}
