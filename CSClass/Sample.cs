using System;

namespace CSClass
{
    internal class Sample
    {

        public static int value = 99;

        public  Sample()
        {
            value = 11;
            Console.WriteLine("Sample() 생성자 호출!!!");
        }

        //정적 생성자
        static Sample()
        {
            value = 11;
            Console.WriteLine("Sample() 정적 생성자 호출!!!");
        }

        //c#은 가비지 컬렉터가 관리를 해서, 소멸자는 언제 소멸될 지 모른다.
        ~Sample()
        {
            Console.WriteLine("Sample() 소멸자 호출!!!!!!!");
        }

    }
}