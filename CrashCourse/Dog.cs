using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Dog
    {
        public char Gender { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool isFixed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Dog(int Age, char Gender, string Name, bool isFixed)
        {
            this.Name = " ";
            this.Gender = '?';
            this.isFixed = false;
            this.Weight = Weight;
            this.Color = "Brown";
        }

        public string MakeNoise()
        {
            return "Woof";
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
