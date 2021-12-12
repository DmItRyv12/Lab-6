using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultString = String.Format("{0:00000.00}", 123);
            Console.WriteLine(resultString);
            string resulString = String.Format("{0:#(###)###-##-##}", 85469871123);
            Console.WriteLine(resulString);
            string resulsString = String.Format("{0:0,0}", 1123);
            Console.WriteLine(resulsString);
            string resulzString = String.Format("{0:+0;-0;0}", 3);
            Console.WriteLine(resulzString);
            string resulaString = String.Format("{0:000.00}", 854);
            Console.WriteLine(resulaString);
            string resuString = String.Format("{0:.0}", 85);
            Console.WriteLine(resuString);
            string resulfString = String.Format("{0:F2}", 5);
            Console.WriteLine(resulfString);
            string resuldString = String.Format("{0:D}", 75);
            Console.WriteLine(resuldString);
            string resulnString = String.Format("{0:N2}", 50000000);
            Console.WriteLine(resulnString);
            string resulpString = String.Format("{0:P2}", 0.7);
            Console.WriteLine(resulpString);
            Console.ReadKey();
        }

    }
}
