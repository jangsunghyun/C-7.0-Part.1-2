using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    //오버라이드 : 메소드 재정의

    // virtual : 부모(base)클래스 메소드 앞에 붙는 키워드
    // 자식(파생:derived)클래스에 의해서 재정의 될 수 있다는 의미를 갖는다. 

    // override : 자식(derived)클래스 메소드 앞에 붙는 키워드
    // 부모로부터 받는 메소드를 재정의 한다라는 의미.
    // 재정의 할때는 부모의 메소드 이름과 같아야 한다. 프로토타입도 일치해야 한다.
    // override 는 virtual에 지정되어 있는 메소드에 한해서 사용한다.
    // new : 오버라이딩과는 다른 개념으로 메소드를 숨기는 기능이다. 

    class BaseClass
    {
        public virtual void echo()
        {
            Console.WriteLine("기반 클래스");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void echo()  //자신을 감추고 (메소드 숨기기 ) echo 가 독립적으로.. 
        {
            Console.WriteLine("파생 클래스");
        }

        //public override void echo()
        //{
        //    Console.WriteLine("파생 클래스");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.echo();

            BaseClass baseClass = new DerivedClass();
            baseClass.echo();
        }
    }
}
