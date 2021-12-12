using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToUpper() + s.Substring(1) + ' ';
            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
