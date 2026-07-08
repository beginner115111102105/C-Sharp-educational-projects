using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class RationalNumber
    {
        int num, den;
        public RationalNumber()
        {
            this.num = 1;
            this.den = 1;
            Reduction(this.num, this.den);
        }
        public RationalNumber(int num, int den)
        {
            this.num = num;

            set_den(den);
            Reduction(this.num, this.den);
        }
        public void Reduction(int a, int b)//сокращение дроби
        {
            int NOD = Math.Abs(a);
            if (NOD == 1)
            {
                this.num = a;
                this.den = b;
            }
            while (NOD > 1)
            {
                // проверяем, если числитель и знаменатель делятся на наибольшее общее кратное
                // без остатка, то выводим сокращенную дробь и прерываем цикл проверки
                if ((a % NOD) == 0 && (b % NOD) == 0)
                {
                    if ((a > b || a == b) && a % b == 0)
                    {
                        this.num = a / b;
                        this.den = b / b;
                    }

                    else
                    {
                        this.num = a / NOD;
                        this.den = b / NOD;
                        //  Console.WriteLine("Сокращенная дробь: " + get_num() + "|" + get_den()); 
                    }

                    break;
                }
                --NOD;
            }
        }
        public int get_num()
        { return num; }
        public void set_num(int num)
        { this.num = num; }
        public int get_den()
        { return den; }
        public void set_den(int den)
        {
            if (den == 0)
            {
                Console.WriteLine("На ноль делить нельзя!\nВведите другое значение");
                set_den(int.Parse(Console.ReadLine()));

            }
            else
                this.den = den;
        }
        public void addition(RationalNumber num1, RationalNumber num2)
        {


            this.num = (num1.get_num() * num2.get_den()) + (num2.get_num() * num1.get_den());
            this.den = num1.get_den() * num2.get_den();
            Reduction(get_num(), get_den());
            if (this.num > this.den)
                Console.WriteLine("Сумма равна:" + this.num / this.den + " " + get_num() + "/" + get_den());
            else
                Console.WriteLine("Сумма равна:" + get_num() + "/" + get_den());
        }
        public void substraction(RationalNumber num1, RationalNumber num2)
        {


            this.num = (num1.get_num() * num2.get_den()) - (num2.get_num() * num1.get_den());
            this.den = num1.get_den() * num2.get_den();
            Reduction(get_num(), get_den());
            if (this.num > this.den)
                Console.WriteLine("Разность равна:" + this.num / this.den + " " + get_num() + "/" + get_den());
            else
                Console.WriteLine("Разность равна:" + get_num() + "/" + get_den());

        }
        public void multiplecation(RationalNumber num1, RationalNumber num2)
        {
            this.num = num1.get_num() * num2.get_num();
            this.den = num1.get_den() * num2.get_den();
            Reduction(get_num(), get_den());
            if (this.num > this.den)
                Console.WriteLine("Произведение равно:" + this.num / this.den + " " + get_num() + "/" + get_den());
            else
                Console.WriteLine("Произведение равно:" + get_num() + "/" + get_den());

        }
        public void delete(RationalNumber num1, RationalNumber num2)
        {
            if (num2.get_num() == 0)
                Console.WriteLine("Деление не возможно! Один из знаменателей равен 0");
            else
            {
                this.num = num1.get_num() * num2.get_den();
                this.den = num1.get_den() * num2.get_num();
                Reduction(get_num(), get_den());
                if (this.num > this.den)
                    Console.WriteLine("Деление равно:" + this.num / this.den + " " + get_num() + "/" + get_den());
                else
                    Console.WriteLine("Деление равно:" + get_num() + "/" + get_den());
            }
        }
        //Отношения и равенство
        public void relationships(RationalNumber num1)
        {
            int a = num1.get_num() * this.den;
            int a1 = this.num * num1.get_den();
            if (a > a1)
                Console.WriteLine("Дробь "+num1.get_num()+"/"+num1.get_den()+">"+ this.num + "/" + this.den);
            else if (a < a1)
                Console.WriteLine("Дробь " + num1.get_num() + "/" + num1.get_den() + "<" + this.num + "/" + this.den);
            else
                Console.WriteLine("Дробь " + num1.get_num() + "/" + num1.get_den() + "=" + this.num + "/" + this.den);

        }
    }
}
