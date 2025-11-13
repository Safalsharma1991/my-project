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
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(10);
            ar.Add("MyGoMinds");
            ar.Add(2.5); ar.Add(true);
            foreach (var i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
