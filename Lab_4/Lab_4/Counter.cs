using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Counter
    {
        private int value;
        public Counter()
        {
            value = 0;
        }
        public Counter(int initial_value)
        {
            value = initial_value;
        }
        public int get_value()
        {
            return value;
        }
        public void set_value(int local)
        {
            this.value = local;
        }
        public void increment()
        { 
            this.value++;
        }//n++
        public void operator_ ()//++n
        {
            ++this.value;
        }
        //4
        public int operator_(Counter rhs)
        {
            //TypedReference temp = __makeref(this.value);
            //++this.value;
            return this.value+rhs.get_value();
        }

    }

}
