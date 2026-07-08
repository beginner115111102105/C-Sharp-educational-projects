using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Rectangle:Shape
    {
        private int leight, wight;
        public Rectangle(int l,int w) 
        {
            this.leight = l;    
            this.wight = w;
        }
        public override double get_area()
        { return (leight* wight); }
        public override double get_perim()
        { return 2 *(leight + wight); }
        public int get_l()
        { return leight; }
        public int get_w()
        { return wight; }
        public override void draw()
        { 
            Console.WriteLine("Rectangle draw here");
            for (int i = 0; i < this.leight;i++)
            {
                for (int j = 0; j < this.wight; j++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
