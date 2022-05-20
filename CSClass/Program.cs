using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

            List<int> list = new List<int>() { 52, 273, 32, 64};
            list.Remove(52);
            foreach (int item in list)
            {
                Console.WriteLine("count : " + list.Count+" Item : " +item);
            }

            Console.WriteLine(Math.Abs(-3));
            Console.WriteLine(Math.Max(342, 2));
            Console.WriteLine(Math.Min(342, 2));
            Console.WriteLine(Math.Ceiling(234.2332));
            Console.WriteLine(Math.Floor(342.12));
            Console.WriteLine(Math.Round(342.52));
            Console.WriteLine(Math.Round(342.22));
            Console.WriteLine(Math.PI);

            Hamberger nyam = new Hamberger();

        }
    }
}
