using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInheritanceEx
{
    //class A
    //{
    //    public void Output()
    //    {
    //        Console.WriteLine("A의 출력");
    //    }
    //}

    //class B
    //{
    //    public void Output()
    //    {
    //        Console.WriteLine("B의 출력");
    //    }
    //}
    //C#은 클래스 다중상속이 불가능 하다.
    //class Program : A

    interface Ia
    {
        void Output();
    }

    interface Ib
    {
        void print();
    }

    class MyClass : Ia, Ib
    {
        public void Output()
        {
            Console.WriteLine("A 인터페이스 출력");
        }

        public void print()
        {
            Console.WriteLine("B 인터페이스 출력");
        }
            
    }

    class Program 
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Output();
            mc.print();

            Ia ia = mc as Ia;
            ia.Output();

            Ib ib = mc as Ib;
            ib.print();
        }
    }
}
