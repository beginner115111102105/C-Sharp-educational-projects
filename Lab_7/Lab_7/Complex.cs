using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Complex
    {
        private double a, b;
       // int i = sqrt(4);
        public Complex()
        {
            this.a = 1;
            this.b = 1;
        }
        public Complex(double a1,double b1)
        { 
            this.a = a1;    
            this.b = b1;
        }
        public double get_a()
            { return this.a; }
        public double get_b()
            { return this.b; }
        public void printer()
        {
            Console.WriteLine("Комплексное число:("+this.a+","+this.b+"i)");
        }
        public void addition()
        {
            
        }
        public void addition(Complex num1,Complex num2)
        { 
            double n1=(num1.get_a()+num2.get_a());
            double n2=(num1.get_b()+num2.get_b());
            this.a = n1;
            this.b = n2;
            if (n2 >= 0)
                Console.WriteLine("Сумма равна:" + a + "+" + b + "i");
            else Console.WriteLine("Сумма равна:" + a +""+ b + "i");
        }
        public void substraction(Complex num1, Complex num2)
        {
            double n1 = (num1.get_a() - num2.get_a());
            double n2 = (num1.get_b() - num2.get_b());
            this.a = n1;
            this.b = n2;
            if (n2 >= 0)
                Console.WriteLine("Разность равна:" + a + "+" + b + "i");
            else Console.WriteLine("Разность равна:" + a + "" + b + "i");
        }
        public void multiplecation(Complex num1, Complex num2)
        {
            double n1 = num1.get_a()*num2.get_a()-num1.get_b() * num2.get_b();
            double n2 = num1.get_a() * num2.get_b()+num1.get_b() * num2.get_a();
            this.a = n1;
            this.b = n2;
            if (n2 >= 0)
                Console.WriteLine("Произведение равно:" + a + "+" + b + "i");
            else Console.WriteLine("Произведение равно:" + a + "" + b + "i");
        }
    }
}
