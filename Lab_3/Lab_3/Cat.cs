using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Cat
    {

        private int its_age;
        private int its_weight;
        
        public Cat()
        {
            setAge(1);
        }
        
        public Cat(ref Cat a)
        {
            this.its_age=a.getAge();
            this.its_weight=a.getWeight();
        }
        public Cat(int a, int b)
        {
            this.its_age = a;
            this.its_weight = b;
        }
        public void setAge(int a)
        {
            this.its_age = a;
        }
        public int getAge()
        {
            return its_age;
        }
        public void setWeight(int a)
        {
            this.its_weight = a;
        }
        public int getWeight()
        {
            return its_weight;

        }

        public void meow()
        {
            Console.WriteLine("Meow");
        }

    }

}
