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
            var cat = new Cat();
            cat.Name = "Sookie";
            cat.Gender = 'F';
            var noise = cat.MakeNoise();
            Console.WriteLine(noise);

            var dog = new Dog();
            dog.Name = "Lady";
            dog.Gender = 'F';
            noise = dog.MakeNoise();
            Console.WriteLine(noise);

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);

            }


            //List<Car> cars = new List<Car>();
            //cars.Add(new Car("Black"));
            //cars.Add(new Car("Red"));
            //cars.Add(new Car("Purple"));
            //cars.Add(new Car("Green"));
            //cars.Add(new Car());

            //foreach (Car pieceOfCrap in cars)
            //{
            //    Console.WriteLine(pieceOfCrap.Describe());
            //}

            Console.ReadKey();
        }
    }
}
