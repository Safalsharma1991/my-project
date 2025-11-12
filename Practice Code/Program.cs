using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMExtensionDemo
{
    class A
    {
        public void Show() {
            Console.WriteLine("I am show");
                }
    }

    static class B
    {
        public static void Display(this A a)
        {
            Console.WriteLine("I am  display");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                A a = new A();
                a.Show();
                a.Display();
        }
    }
}
