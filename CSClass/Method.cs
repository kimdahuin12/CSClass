using System;

namespace CSClass
{
    class Method
    {

        int instanceVariable = 10;
        static int classVariable = 10;

        //기본으로 private 접근제어자이다.
        public double Multi(double v1, double v2)
        {
            return v1 * v2;
        }

        /// <summary>
        /// min부터 max까지의 합을 구합니다.
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최대값</param>
        /// <returns>min부터 max까지의 합계</returns>
        public int Sum(int min, int max)
        {
            int res = 0;
            for(int i = min; i <= max; i++)
            {
                res += i;
            }
            return res;
        }

        /// <summary>
        /// min부터 max까지의 곱을 구합니다.
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">최대값</param>
        /// <returns>min부터 max까지의 곱</returns>
        public int Multiply(int min, int max)
        {
            int res = 1;
            for (int i = min; i <= max; i++)
            {
                res *= i;
            }
            return res;
        }


        static public void some()
        {
            Console.WriteLine(classVariable);
            //접근 불가
            //Console.WriteLine(instanceVariable);
        }

        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

    }
}