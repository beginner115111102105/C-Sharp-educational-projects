using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Square:Rectangle
    {

        public Square(int l):base(l,l)
        { }
        public Square(int l, int w):base(l,w)
        { 
            if (get_l()!= get_w())
            {
                Console.WriteLine("Not a square");
            }
        }
        public override double get_perim()
        { return 4 * get_l(); }
    }
}
