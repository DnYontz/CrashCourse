using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Car
    {
        public string Color { get; set; }

        public Car()
        {
            this.Color = "Primer Grey";
        }

        public Car(string color)
        {
            this.Color = color;
        }

        public string Describe()
        {
            return "This car is " + this.Color;
        }

    }
}
