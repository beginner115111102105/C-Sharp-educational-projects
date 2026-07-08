using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Rational
    {
        int ch, zn;
        public Rational()
        {
            this.ch = 1;
            this.zn = 1;
            Reduction(this.ch, this.zn);
        }
        public Rational(int ch, int zn)
        {
            this.ch = ch;
            
            set_zn(zn);
            Reduction(this.ch, this.zn);
        }
        public void Reduction(int a,int b)//сокращение дроби
        {
            int NOD = Math.Abs(a);
            if (NOD == 1)
            {
                this.ch = a;
                this.zn = b;
            }
            while (NOD > 1)
            {
                // проверяем, если числитель и знаменатель делятся на наибольшее общее кратное
                // без остатка, то выводим сокращенную дробь и прерываем цикл проверки
                if ((a % NOD) == 0 && (b % NOD) == 0)
                {
                    if ((a > b || a == b) && a % b == 0)
                    {
                        this.ch = a/b;
                        this.zn = b/b;
                    }

                    else
                    {
                        this.ch = a/NOD;
                        this.zn = b/NOD;
                      //  Console.WriteLine("Сокращенная дробь: " + get_ch() + "|" + get_zn()); 
                    }

                    break;
                }
                --NOD;
            }                    
        }
                   
        
        public void addition(Rational num1, Rational num2)
        {


            this.ch = (num1.get_ch() * num2.get_zn()) + (num2.get_ch() * num1.get_zn());
            this.zn = num1.get_zn() * num2.get_zn();                    
            Reduction(get_ch(), get_zn());
            if (this.ch>this.zn)
                Console.WriteLine("Сумма равна:" + this.ch / this.zn + " " + get_ch() + "/" + get_zn());
            else
                Console.WriteLine("Сумма равна:"+ get_ch() + "/" + get_zn());
        }
        public void substraction(Rational num1, Rational num2)
        {
            

            this.ch = (num1.get_ch() * num2.get_zn()) - (num2.get_ch() * num1.get_zn());
            this.zn = num1.get_zn() * num2.get_zn();
            Reduction(get_ch(), get_zn()); 
            if (this.ch > this.zn)
            Console.WriteLine("Разность равна:"+ this.ch / this.zn + " " + get_ch() + "/" + get_zn());
            else
            Console.WriteLine("Разность равна:" + get_ch() + "/" + get_zn());
           
        }
        public void multiplecation(Rational num1, Rational num2)
        {
            this.ch = num1.get_ch() * num2.get_ch();
            this.zn = num1.get_zn() * num2.get_zn();
            Reduction(get_ch(), get_zn()); 
            if(this.ch > this.zn)
            Console.WriteLine("Произведение равно:"+ this.ch / this.zn + " " + get_ch()+ "/"+get_zn());
            else
            Console.WriteLine("Произведение равно:" +get_ch()+ "/"+get_zn());
           
        }
        public void delete(Rational num1, Rational num2)
        {
            if (num2.get_ch() == 0)
                Console.WriteLine("Деление не возможно! Один из знаменателей равен 0");
            else
            {
                this.ch = num1.get_ch() * num2.get_zn();
                this.zn = num1.get_zn() * num2.get_ch();
                Reduction(get_ch(), get_zn());
                if (this.ch > this.zn)
                    Console.WriteLine("Деление равно:" + this.ch / this.zn + " " + get_ch() + "/" + get_zn());
                else
                    Console.WriteLine("Деление равно:" + get_ch() + "/" + get_zn());
            }
        }
        public int get_ch()
            { return ch; }
        public void set_ch(int ch)
            { this.ch = ch; }
        public int get_zn()
        { return zn; }
        public void set_zn(int zn)
        {
            if (zn == 0)
            { Console.WriteLine("На ноль делить нельзя!\nВведите другое значение");
               set_zn(int.Parse(Console.ReadLine()));

            }
            else
                this.zn = zn; 
        }
        public void print()
        {
            Reduction(this.ch, this.zn);
            Console.WriteLine( get_ch() + "/" + get_zn());
        }
        public void print_point()
        {
            double a= (double)get_ch()/ get_zn();
            a= Math.Round(a, 2);
            Console.WriteLine("Число= "+a);
        }
    }
}
