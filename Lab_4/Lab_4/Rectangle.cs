using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Rectangle
    {
        private int widht,height;
        public Rectangle()
        {
            this.widht = 5;
            this.height = 6;
        }
        public Rectangle(int widht, int height)
        {
            this.widht = widht;
            this.height = height;
        }

        public void draw()
        {
            draw(this.widht,this.height);
        }
        public void draw(int w, int h)
        {
            if (get_height()==get_widht())
                Console.WriteLine("Это квадрат!");
            else
                Console.WriteLine("Это прямоугольник!");
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public int get_widht()
        {
            return widht;
        }
        public void set_widht(int local)
        {
            this.widht = local;
        }
        public int get_height()
        {
            return height;
        }
        public void set_height(int local)
        {
            this.height = local;
        }

    }
}
