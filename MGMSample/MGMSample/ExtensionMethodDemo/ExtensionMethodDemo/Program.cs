using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("I am show");
        }
    }
    static class NewClass
    {
        public static void NewMethod(this A obj)
        {
            Console.WriteLine("I am new method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Show();
            a1.NewMethod();
        }
    }
}
