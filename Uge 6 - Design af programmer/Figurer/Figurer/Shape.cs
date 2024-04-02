using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurer
{
    internal class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual double Area()
        {
            return width * height;
        }
    }
}
