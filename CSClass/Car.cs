﻿using System;

namespace CSClass
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        public Car()
        {
           
        }

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
            throw new NotImplementedException();
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
            throw new NotImplementedException();
        }
    }
}