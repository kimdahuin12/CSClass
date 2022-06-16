using System;

namespace CSClass
{
    //public sealed class Parent
    //public abstract class Parent
    public class Parent
    {
        public static int counter = 0;
        public int variable = 273;
        //abstract public void Method3();
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        public virtual void Method2()//오버라이드를 허용
        {
            Console.WriteLine("부모의 메서드");
        }
        public void CountParent()
        {
            Parent.counter++;
        }
        public Parent()
        {
            Console.WriteLine("Parent()");
        }
        public Parent(int param)
        {
            Console.WriteLine("Prarent(int param)");
        }

        public Parent(string param)
        {
            Console.WriteLine("Prarent(string param)");
        }

    }
}