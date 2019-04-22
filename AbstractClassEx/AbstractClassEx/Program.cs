using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx
{
    //추상클래스 : 인터페이스와 비슷하다 하지만, 추상클래스는 구현(몸통)부를 가질수 있다.
    //              인스턴스를 가질수는 없다.
    // 추상클래스는 구현을 갖을 수 있지만 인스턴스를 만들수 없다.
    // 사용하는 한정자는 abstract와 class를 사용한다.

    /*
        선언 형식
        abstract class 클래스명
        {
            // 클래스와 동일
        }

        - 추상 클래스는 클래스와 달리 추상메소드를 갖고 있다.
        - 추상 클래스는 모든 멤버에 접근 제한자를 사용하지 않을 경우 private 설정된다.
        - 추상 메소드를 지정할 때 abstract 키워드를 사용한다.

        추상메소드의 형식
        public abstract void A();

        - 추상메소드는 private 이 될 수 없기 때문에 C# 컴파일러는 public, protected , internal,
          protected internal중에 하나로 수식되도록 하고 있다.

    */

    abstract class MyAbabstractClass
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("추상클래스의 ProtectedMethod호출");
        }

        public void PublicMoethod()
        {
            Console.WriteLine("추상클래스의 PublicMethod호출");
        }

     //추상메소드는 반드시.. 
     //접근제한자 + abstract 반드시 들어가야함
        public abstract void AbstracMethod();
    }

    class Child : MyAbabstractClass
    {
        public override void AbstracMethod()
        {
            Console.WriteLine("추상클래스의 AbstractMethod 호출");
            ProtectedMethod();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyAbabstractClass myabs = new Child();
            myabs.AbstracMethod();
            myabs.PublicMoethod();
        }
    }
}
