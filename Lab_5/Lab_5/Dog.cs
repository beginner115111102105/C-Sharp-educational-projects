using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Dog:Mammal
    {

        public Dog(int a, double b) : base(a, b)//2
        { }
        public Dog() : base()
        { }
        private breed breed_1;
        public breed get_breed()
        {
            return breed_1;
        }
        public void set_breed(breed dr)
        {  this.breed_1 = dr; }
        public void wag_tail()
        {
            Console.WriteLine("tail wadding");
        }
        public void beg_for_food()
        {
            Console.WriteLine("bedding for food");
        }
       
    }
}
