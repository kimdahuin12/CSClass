using System;

namespace CSClass
{
    public class Cat :Animal
    {
        public void Meow()
        {
            Console.WriteLine("냐옹냐옹 웁니다.");
        }

        public override void Eat()
        {
            Console.WriteLine("냐옹 먹습니다.");
        }
    }
}