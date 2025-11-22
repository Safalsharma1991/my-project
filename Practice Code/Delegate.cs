using System;

public delegate void MyDelegate();

class A
{

public static void M1()
{
 Console.WriteLine("I am m1");
}
}

static void Main()
{
MyDelegate obj = new MyDelegate(m1);
obj();
}

