using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    enum breed{golden, cairn, dandie, shetland, doberman, lab};
    internal class Mammal
    {
        protected int age, weight;
        public Mammal()
        {
            age = 0;
            weight = 0;
        }
        public Mammal(int age, double weight)
        {
            this.age = age;
            this.weight = (int)weight;
        }
        public void set_age(int a) 
            { this.age = a; }
        public void set_weight(int a)
        { this.weight = a; }
        public int get_age()
            { return this.age; }
        public int get_weight()
            { return this.weight; }
        public void sleep()
        {
            Console.WriteLine("Sleep");
        }
        public void speak()
        {
             Console.WriteLine("Soung");
        }

        }
}
