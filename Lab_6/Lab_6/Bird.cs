using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Bird
    {
        private int weight;
        public Bird()
        { }
        public virtual void chirp()
        { Console.WriteLine("Chirp...."); }
        public virtual void fly()
        { Console.WriteLine("I can fly :)"); }

    }
}
