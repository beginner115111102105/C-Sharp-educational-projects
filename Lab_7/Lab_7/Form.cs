using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    abstract internal class Form
    {
        public virtual void Draw()
        { }
        public virtual void Draw(int a1,int a2)
        { }
        public virtual void Draw(double a1, double a2, double a3)
        { }
        public virtual void Draw(int r)
        {  }
        public virtual void S()
        { }
        public virtual void P()
        { }
    }
    internal class Circle:Form

    {
        int R;
        public Circle()
        { this.R = 1; }
        public Circle(int r)
        { this.R = r; }
        public int get_r()
            { return this.R; }
        public void set_r(int r)
        { this.R = r; }
        public virtual void Draw(int r)
        { Console.WriteLine("Круг с радиусом " + r); }
        public virtual void Draw()
        { Console.WriteLine("Круг с радиусом "+this.R); }     
        public virtual void S()
        { double s = R * R * Math.PI;
            Console.WriteLine("Площадь круга " + R);
        }
        public virtual void P()
        { double p = 2 * R * Math.PI;
            Console.WriteLine("Периметр круга " + R);
        }

    }
    internal class Rectangle : Form
    {
        int a, b;
        public Rectangle()
        {
            this.a = 0;
            this.b = 0; 
        }
        public Rectangle(int a1,int b1)
        {
            this.a = a1;
            this.b = b1;
        }
        public int get_a()
            { return a; }
        public int get_b()
        { return b; }
        public void set_a(int a1)
        { this.a=a1; }
        public void set_b(int b1)
        { this.b = b1; }
        public override void Draw()
        {
            Draw(this.a,this.b);        }
        public override void Draw(int a1,int b1)
        {
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < b1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public virtual void S()
        { 
            int s = this.a * this.b;
            Console.WriteLine("Площадь равна "+s);

        }
        public virtual void P()
        { int p = 2 * (this.a + this.b);
            Console.WriteLine("Периметр равен " + p);
        }
    }
    internal class Triangle : Form 
    {
        double a,b,c;
        public Triangle()
        {
            this.a = 3;
            this.b = 4;
            this.c = 5;
        }
        public Triangle(double a1, double b1, double c1)
        {
            if ((a1 + b1 > c1) && (a1 + c1 > b1) && (b1 + c1 > a1))
            {
                this.a = a1;
                this.b = b1;
                this.c = c1;
            }
            else Console.WriteLine("Такой тругольник не построить");

        }
        public override void Draw()
        { Draw(this.a, this.b, this.c); }
        public override void Draw(double a1, double b1, double c1)
        {
            Console.WriteLine("Треугольник со сторонами "+a+" "+b+" "+c);
        }
        public override void S()
        {
            double p = (a+b+c)/ 2;
           
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("Площадь треугольника "+s);
        }
        public override void P()
        {
            double p = a + b + c;
            Console.WriteLine("Периметр треугольника равен "+p);

        }
        public double get_a()
        { return this.a; }
        public void set_a(int a1)
        { this.a = a1; }
        public double get_b()
        { return this.b; }
        public void set_b(int b1)
        { this.b = b1; }
        public double get_c()
        { return this.c; }
        public void set_c(int c1)
        { this.c = c1; }
    }
}
