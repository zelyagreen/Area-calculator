using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : Figure
    {
        // Radius in meters
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value > 0 ? value : -value;
            }
        }

        protected Circle() : base("Circle")
        {

        }

        public Circle(double radius) : this()
        {
            Radius = radius;
        }

        public override double Area()
        {
            double Area = 0;

            Area = Math.PI * Radius * Radius;

            return (Area);
        }

    }
}
