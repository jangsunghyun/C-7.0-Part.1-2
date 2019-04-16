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
        public class DemoClass1
        {
            MyClass.Global_count++;
        }
    }

    class DemoClass2 {
        public class DemoClass2
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
