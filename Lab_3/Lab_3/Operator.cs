using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Operator
    {
        private double number;
        public Operator()
        { 
            this.number=0;
        }
            
        public void set_number(double a)
        {
            this.number = a;
        }
        public double get_number()
        {
            return number;
        }
        public double number_2()
        {  
            return (this.number* this.number);
        }
        public double number_3()
        {
            return (this.number * this.number*this.number);
        }
    }
    
}
