using System;

namespace CSClass
{
    public class Parent
    {
        public static int counter = 0;
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