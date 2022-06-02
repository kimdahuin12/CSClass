using System;

namespace CSClass
{
    internal class MyMath
    {
        public static int Abs(int input)
        {
            //만약 input이 최저값일 경우에는 예외 처리를 해야함
            Console.WriteLine("----------int Abs----------");
            return (input < 0) ? -1 * input : input;
            
        }

        public static double Abs(double input)
        {
            Console.WriteLine("----------double Abs----------");
            return (input < 0) ? -1 * input : input;

        }

        public static long Abs(long input)
        {
            Console.WriteLine("----------long Abs----------");
            return (input < 0) ? -1 * input : input;

        }
    }
}