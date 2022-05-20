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

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;
            Product productB = new Product() { name="소금빵", price=2000};
            Product productC = new Product() { price=4000, name="당근케이크"};
            Product productD = new Product() { price = 4000};
            Product productE = new Product() { name="보름달" };

            Console.WriteLine("=================================================");
            Console.WriteLine("제품명 : "+productA.name +", 가격 : "+ productA.price);
            Console.WriteLine("제품명 : " + productB.name + ", 가격 : " + productB.price);
            Console.WriteLine("제품명 : " + productC.name + ", 가격 : " + productC.price);
            Console.WriteLine("제품명 : " + productD.name + ", 가격 : " + productD.price);
            Console.WriteLine("제품명 : " + productE.name + ", 가격 : " + productE.price);


        }
    }
}
