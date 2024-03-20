using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevelse_1
{
    public abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Shape() : this(1, 1) { }

        public Shape(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X = {this.X}, Y = {this.Y}";
        }

        public abstract void Area();

        public void Move(double XCHange, double YChange)
        {
            this.X += XCHange;
            this.Y += YChange;
        }
    }
}
