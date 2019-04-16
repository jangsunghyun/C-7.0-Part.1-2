using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisEx2
{
    class Demo
    {
        public int a, b, c;

        public Demo()
        {
            this.a = 100;
            Console.WriteLine("demo()");
        }

        public Demo(int b):this()
        {
            //this.a = 100;
            this.b = b;
            Console.WriteLine($"demo({b})");
        }

        public Demo(int b, int c):this(b)
        {
            //this.a = 100;
            //this.b = b;
            this.c = c;
            Console.WriteLine($"demo({b} {c})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //this() 생성자
            Demo demo = new Demo(200,300);

            Console.WriteLine(demo.a);
            Console.WriteLine(demo.b);
            Console.WriteLine(demo.c);

        }
    }
}
