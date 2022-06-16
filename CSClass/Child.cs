using System;

namespace CSClass
{
    public class Child: Parent
    {
        public new string variable = "hiding";

        public new void Method() //하이딩
        {
            Console.WriteLine("자식의 메서드");
        }

        //public new void Method3() //하이딩
        //{
        //    Console.WriteLine("추상 메서드");
        //}

        public override void Method2() 
        {
            Console.WriteLine("자식의 메서드");
        }

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

        public override void Method3()
        {
            throw new NotImplementedException();
        }
    }
}