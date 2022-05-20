using System;


namespace CSClass
{
    /// <summary>
    /// 자동차 입차, 출차 시간 등을 저장하는 클래스입니다.
    /// </summary>
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        /// (xml 주석)
        /// 자동차 입차 시간을 지정합니다.
        /// </summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 어떤 동작을 합니다.
        /// </summary>
        /// <param name="me">숫자를 입력하는 변수입니다.</param>
        /// <returns>me * 10을 리턴합니다.</returns>
        public int m(int me)
        {
            return me * 10;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}