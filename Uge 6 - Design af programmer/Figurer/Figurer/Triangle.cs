using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurer
{
    internal class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double Area()
        {
            return 0.5 * base.Area();
        }
    }
}
