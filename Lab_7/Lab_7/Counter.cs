using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Counter
    {
        private int min, max,counter;
        public Counter(int min, int max, int counter)
        {
            this.min = min;
            this.max = max;
            this.counter = counter;
        }
        public Counter()
        {
            this.min = 0;
            this.max = 100;
            this.counter = this.min;
        }
        public int get_min()
            { return this.min; }
        public void set_min(int min)
        { this.min = min; }
        public int get_max()
        { return this.max; }
        public void set_max(int max)
        { this.max = max; }
        public int get_counter()
        { return this.counter; }
        public void set_counter(int counter)
        {  this.counter= counter; }
        public void add1()
        {
            this.counter++;
            if (this.counter == this.max)
                this.counter = this.min;
        }

    }
}
