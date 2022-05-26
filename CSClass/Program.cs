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

            List<Student> students = new List<Student>() {
                new Student() { name = "김다흰", grade = 3 },
                new Student() { name = "홍길동", grade = 1 },
                new Student() { name = "이똥개", grade = 4 },
                new Student() { name = "김황소", grade = 2 },
                new Student() { name = "이하나", grade = 1 },
                new Student() { name = "정바름", grade = 4 },
                new Student() { name = "나일등", grade = 3 }
            };

            //list에서 값 지우기

            //for (int i = 0; i < students.Count; i++)
            //{
            //    if (students[i].grade > 2)
            //    {
            //        students.RemoveAt(i);
            //        i--;
            //    }
            //}

            for (int i = students.Count-1; i >= 0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
