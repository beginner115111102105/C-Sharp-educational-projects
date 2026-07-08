using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Shape
    {
        public Shape()
        { }
        public virtual double get_area() 
        { return -1; }
        public virtual double get_perim()
        { return -1; }
        public virtual void draw()
        { }
    }
}
