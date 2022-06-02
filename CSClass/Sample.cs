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
    }
}