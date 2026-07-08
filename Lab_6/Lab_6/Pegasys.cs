using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Pegasys:Hourse
    {
        public override void fly()

        {
            Console.WriteLine("I can fly!");
        }
        public override void chirp()
        {
            whinny();
        }
    }
}
