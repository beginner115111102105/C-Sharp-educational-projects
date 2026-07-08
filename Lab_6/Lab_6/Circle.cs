using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Circle:Shape
    {
        private int radius;
        public Circle(int r)
        {
            this.radius = r;
        }
        public override double get_area()
        { return (3.1415926 * radius * radius); }
        public override double get_perim()
        { return 2 * 3.1415926 * radius;}
        public override void draw()
        { Console.WriteLine("Circle draw here"); }
        
        
    }
}
