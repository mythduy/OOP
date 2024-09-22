using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01
{
    internal class Cylinder : Circle
    {
        private double height = 1.0;

        public double Height { get => height; set => height = value; }

        public Cylinder(double radius): base (radius)
        {
            this.Radius = radius;
        }
        public Cylinder(double radius, double height ): base(radius)
        {
            this.Radius=radius;
            this.Height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.Radius = radius;
            this.Height = height;
            this.Color = color;
        }

        ~Cylinder()
        {

        }
        public double getVolume()
        {
            return height*base.getArea();
        }
    }
}
