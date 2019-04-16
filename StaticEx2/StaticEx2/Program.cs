using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx2
{
    class MyClass
    {
        public static int Global_count = 0;
    }

    class DemoClass1
    {
        public  DemoClass1()
        {
            MyClass.Global_count++;
        }
    }

    class DemoClass2 {
        public DemoClass2()
        {
            MyClass.Global_count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global_count :  { MyClass.Global_count}");
            new DemoClass1();
            new DemoClass1();
            new DemoClass2();
            Console.WriteLine($"Global_count :  { MyClass.Global_count}");
        }
    }
}
