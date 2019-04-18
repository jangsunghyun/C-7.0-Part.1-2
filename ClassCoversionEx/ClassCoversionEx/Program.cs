using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCoversionEx
{
    //상속관계 클래스 사이에서의 형변환

    class Human
    {
        public void showInfo()
        {
            Console.WriteLine("Human");
        }
    }

    class Programmer : Human
    {
        public void programming()
        {
            Console.WriteLine("프로그래밍 하는 개발자.");
        }
    }

    class Designer : Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();  //객체 생성
            human.showInfo();

            //Programmer programmer = new Programmer();
            //programmer.showInfo();
            //programmer.programming();

            //Designer designer = new Designer();
            //designer.showInfo();
            //designer.design();

            human = new Programmer();
            human.showInfo();

            Programmer programmer = (Programmer)human;
            programmer.showInfo();
            programmer.programming();

            human = new Designer();
            human.showInfo();

            Designer designer = (Designer)human;
            designer.showInfo();
            designer.design();
        }
    }
}
