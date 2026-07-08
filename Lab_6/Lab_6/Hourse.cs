using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Hourse:Bird
    {
        private int age;
        public void gallop()
        { Console.WriteLine("Galloping......."); }
        public override void fly()
        { Console.WriteLine("I can't fly :("); }
        public virtual void whinny()
        { Console.WriteLine("Whinny..."); }
    }
}
