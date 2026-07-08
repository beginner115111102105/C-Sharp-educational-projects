using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2
{
    internal class Cat
    {
        public Cat()
        {
            setAge(1);

        }
        public Cat(int a, int b)
        {
            this.its_age = a;
            this.its_weight = b;
        }
        public void setAge(int its_age)
        {
            this.its_age = its_age;
        }
        public int getAge()
        {
            return this.its_age;
        }
        public void setWeight(int its_weight)
        {
            this.its_weight = its_weight;
        }
        public int getWeight()
        {
            return this.its_weight;

        }

        
        public void meow()
        {
            Console.WriteLine("Meow");
        }

        private int its_age;
        private int its_weight;
    }
}

