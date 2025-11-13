using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMGeneric
{
    internal class Program
    {
        static void print(int x)
        {
        Console.WriteLine(x);
        }
            static void print(string x)
            { System.Console.WriteLine(x); }
        static void print(double x) { System.Console.WriteLine(x); }

        static void Main(string[] args)
        {
            Program.print(10);
            Program.print("Safal");
            Program.print(10.23);
        }
    }
}
