using System;

namespace CSClass
{
    public class Child:Parent
    {

        public Child() :base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }

        public Child(string input):base(input)
        {
            Console.WriteLine("Child(string input):base(input)");
        }

        public void CounterChild()
        {
            Child.counter++; //Parent의 counter를 증가
        }

    }
}