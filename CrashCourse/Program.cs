using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Black"));
            cars.Add(new Car("Red"));
            cars.Add(new Car("Purple"));
            cars.Add(new Car("Green"));
            cars.Add(new Car());

            foreach (Car pieceOfCrap in cars)
            {
                Console.WriteLine(pieceOfCrap.Describe());
            }

            Console.ReadKey();
        }
    }
}
