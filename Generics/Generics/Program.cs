using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Generics : int, float, double 같은 데이터 타입을 확정하지 않고 이 데이터 타입 자체를 타입
    //            파라미터로(Type Paramater) 받아들이도록 하는 기능

    /*
     
        선언 방식
        
        접근제한자 반환형식 메소드이름 <형식 매개 변수> (매개변수)
        {
            
        }
        <예>
        void CopyData(int a, int b)
        {
            b = a; // int b 에 int a 를 복사
        }

        void CopyData(string a, string b)
        {
            b = a; 문자열 a를 b에 복사
        }

        위의 방식은 데이터 형식에 따라서 여러개의 메소드가 필요하다. 비효율적인 방법

        위의 방식을 Generice 로 변환하면
                     <T> 형식 매개변수  컴파일러가 알아서 데이터 형식으로 처리..
        void CopyData<T>(T a, T b)  // 여기서 T는 Type을 뜻함.
        {
            b = a;
        }


    */

    class Program
    {
        //일반화 메소드
        static void CopyData<T>(T[] a, T[] b)
        {
            for (int i = 0; i < a.Length; i++)
                b[i] = a[i];
        }

        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55 };
            int[] b = new int[a.Length];

            CopyData<int>(a, b);

            foreach (int item in b)
            {
                Console.WriteLine(item);
            }


            string[] aa = { "사과", "배", "딸기", "포도", "수박" };
            string[] bb = new string[aa.Length];

            CopyData<string>(aa, bb);

            foreach (string item in bb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
