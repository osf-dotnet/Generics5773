using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_999
{
    class Program
    {
class MyList<T> where T : new()
{
    T t = new T();

    public override string ToString()
    {
        return t.ToString();
    }
}
class MyClass
{
    public static string ToString()
    {
        return "oshri ...";
    }
}
class Program
{

    static void Main(string[] args)
    {
        MyClass m = new MyClass();
        MyList<MyClass> list = new MyList<MyClass>();
        Console.WriteLine(list.ToString());
    }
}

    }
}
