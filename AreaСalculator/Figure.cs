using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public abstract class Figure
    {
        private string name;
        public Figure(string Name)
        {
            name = Name;
        }

        public abstract double Area();
    }
}
