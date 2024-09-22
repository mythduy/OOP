using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bai_01
{
    internal class Circle
    {
        private double radius = 1.0;
        private string color = "red";

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }
        public double getArea()
        {
            double area = 2*3.14*radius*radius;
            return area;
        }
        public string toString()
        {
            String s = $"Circle[radius = {radius}, color ={color}]";
            return s ;
        }
        ~Circle()
        {
        }

    }
}
