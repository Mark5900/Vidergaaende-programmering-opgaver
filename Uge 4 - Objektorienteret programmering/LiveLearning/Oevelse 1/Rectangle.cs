using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse_1
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) : base()
        {
            this.Length = length;
            this.Width = width;
        }

        public Rectangle(double length, double width, double x, double y) : base(x, y)
        {
            this.Length = length;
            this.Width = width;
        }

        public override string ToString()
        {
            return base.ToString() + $" Length = {this.Length}, Width = {this.Width}";
        }

        public override void Area()
        {
            Console.WriteLine($"Area of rectangle: {this.Length * this.Width}");
        }

        public void Move(double XChange, double YChange)
        {
            if (XChange < 0 || YChange < 0)
            {
                throw new ArgumentOutOfRangeException("XChange and YChange must be positive");
            }
            if (YChange < Length)
            {
                throw new ArgumentOutOfRangeException("YChange must be greater than Length");
            }

            base.Move(XChange, YChange);
        }
    }
}
