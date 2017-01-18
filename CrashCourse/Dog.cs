using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Dog : Animal
    {

        public Dog(int Age, string Name, char Genger, bool isFixed)
        {

            this.Age = Age;
            this.Gender = Gender;
            this.isFixed = isFixed;
            this.Weight = Weight;
            this.Color = Color;
        }


        public Dog()
        {
            this.Name = " ";
            this.Gender = '?';
            this.isFixed = false;
            this.Weight = Weight;
            this.Color = "Brown";
        }

        public override string MakeNoise()
        {
            return "Woof!";
        }
        public string Move()
        {
            return "Walking...";
        }
        public string isHappy()
        {
            return "Wagging Tail...";

        }

    }
}
