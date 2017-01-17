using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{

    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public bool isFixed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Cat(int Age, string Name, char Genger, bool isFixed)
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

    }
}
