using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{

    class Cat : Animal, IMammal
    {

        public Cat(int Age, string Name, char Genger, bool isFixed) {

            this.Age = Age;
            this.Gender = Gender;
            this.isFixed = isFixed;
            this.Weight = Weight;
            this.Color = Color;
        }

        public Cat()
        {
            this.Name = " ";
            this.Gender = '?';
            this.isFixed = false;
            this.Weight = Weight;
            this.Color = "Orange";
        }
        public string MakeNoise()
        {
            return "Meow";
        }

        public string Move()
        {
            return "Walking....";
        }
        public string isHappy()
        {
            return "Purr";
        }

        public void GiveLiveBirth()
        {
            Console.Write("Cat had kittens");
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
