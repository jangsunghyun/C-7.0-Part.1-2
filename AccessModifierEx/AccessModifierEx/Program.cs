using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierEx
{
    class Demo
    {
        public Demo()
        {
            //내부에서 접근
            Demo.public_method();
            Demo.private_method();
            Demo.protected_method();
            Demo.internal_method();
            Demo.protected_internal();
            Demo.private_protected();
        }

        // public 접근 제한자
        public static void public_method() { }

        //private 접근 제한자
        private static void private_method() { }

        //protected 접근 제한자.
        protected static void protected_method() {}

        //internal 접근 제한자
        internal static void internal_method() { }

        //protected internal 접근 제한자
        protected internal static void protected_internal() { }

        //private protected 접근 제한자
        private protected static void private_protected () { }

    }

    class Demo2 : Demo {
        public Demo2()
        {
            //private 빼고 접근 가능하다. 
            Demo.public_method();
            Demo.protected_method();
            Demo.protected_internal();
            Demo.private_protected();
            Demo.internal_method();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 한정자 /접근 제한자 (Access Modifier) 
            // public, private, protected, internal, protected internal, private protected

            //** 클래스 멤버에 한정자가 지정되지 않았을 경우 무조건 private으로 자동 지정된다.

            // public :  클래스이 내부 또는 외부 모든 곳에서 접근할수 있도록 지정자..
            // private : 클래스 외부에서는 접근을 할 수 없도록 하는 지정자, 즉 내부에서만 접근이 가능하도록 하는 지정자.
            //           상속받은 자식(파생)클래스에서도 접근이 허용이 안됨
            // protected : 클래스 외부에서는 접근 할 수 없도록 하는 지정자이다. 하지만 파생 클래스에서는 접근이
            //             가능하도록 하는 지정자.

            // internal : 동일 어셈블리에 있는 코드에서만 public 접근할 수 있는 지정자이다. 
            //            다른 어셈블리에 있는 코드에서는 private과 같은 접근 수준을 갖는다.
            // protected internal : 동일 어셈블리에 있는 코드에서만 protected로 접근할 수 있는 지정자
            //            다른 어셈블리에 있는 코드에서는 private과 같은 접근 수준을 갖는다.

            // private protected : 동일 어셈블리에 있는 클래스에서 클래스에서 상속받은 클래스 내부에서만 접근 가능

            //외부클래스는 public, internal, protected_internal 접근 가능.. 
            Demo.public_method();
            Demo.internal_method();
            Demo.protected_internal();
            
        }
    }
}
