using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse_1
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base()
        {
            this.Radius = radius;
        }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + $" Radius = {this.Radius}";
        }

        public override void Area()
        {
            Console.WriteLine($"Area of circle: {Math.PI * Math.Pow(this.Radius, 2)}");
        }

        public void Move(double XChange, double YChange)
        {
            if (XChange < 0 || YChange < 0)
            {
                throw new ArgumentOutOfRangeException("XChange and YChange must be positive");
            }
            if (YChange < Radius)
            {
                throw new ArgumentOutOfRangeException("YChange must be greater than Radius");
            }
            if (XChange < Radius)
            {
                throw new ArgumentOutOfRangeException("XChange must be greater than Radius");
            }

            base.Move(XChange, YChange);
        }
    }
}
