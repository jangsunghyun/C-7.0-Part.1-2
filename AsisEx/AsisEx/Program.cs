using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsisEx
{
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
            Console.WriteLine("코딩하는 프로그래머");
        }
    }

    class Designner:Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }

    class Program:Human
    {
        static void Main(string[] args)
        {
            // As Is 연산자

            // As : 형변환(Casting)과 같은 역활을 하는 연산자이다. 형변환에 실패했을 경우에 null값을 
            // 리턴한다.

            // Is : 해당 객체 Type(형)이 일치하는지 여부를 bool값으로 반환 하는 연산자.

            Human human = new Programmer();
            Programmer programmer;

            if (human is Programmer)
            {
                programmer = (Programmer)human;
                programmer.programming();
            }

            Human human2 = new Designner();
            Designner designer = human2 as Designner;
            if (designer != null) designer.design();
            
            Designner designer2 = human as Designner;

            designer2 = (Designner)human;


            if (designer2 != null)
                designer2.design();
            else
                Console.WriteLine("designer2는 Designer 형이 아니다.");

        }
    }
}
