using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    class Parent //기반클래스 베이스 클래스
    {
        public Parent()
        {
            Console.WriteLine("Parent() 생성자 호출");
        }

        ~Parent()
        {
            Console.WriteLine("~Parent Class 종료자 호출");
        }

        public void showInfo()  
        {
            Console.WriteLine("Parent Class");
        }
    }

    class Child : Parent    //파생클래스 - 기반 클래스를 기본으로 
    {
        public Child()
        {
            Console.WriteLine("Child() 생성자 호출");
        }

        ~Child()
        {
            Console.WriteLine("~Child() 종료자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //상속
            Child child = new Child();
            //child.showInfo();
        }
    }
}
