using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Polinomials
    {
        int extent;
        List<double> indicator = new List<double>();
       
        public Polinomials()
        {
            this.extent = 1;
            indicator.Add(1);
        }
        public Polinomials(int a, List <double> num)
        {
            this.extent = a;
            this.indicator = num;
        }
        public int get_extent()
        {
            return this.extent;
        }
        public void set_extent(int a)
        {
           this.extent=a;
        }
        public List<double> get_indicator()
        {
           return this.indicator;
        }       
        public void set_indicator(List<double> num)
        {
            this.indicator = num ;
        }
        public void addition(Polinomials a)
        {
            int h = 0;
            List<double> res = new List<double>();               
            if (a.get_extent()<this.extent)
                h=a.get_extent();
            else 
                h=this.extent;
            int i=0;
            while (i<h-1)
            {        
                res.Add(a.indicator[i] + this.indicator[i]);
                i++;
            }
            if (a.get_extent() > this.extent)
            {
                while (i < a.get_extent())
                {
                    res.Add(a.indicator[i]);
                    i++;
                }
            }
            else
            {
                while (i < this.extent)
                {
                    res.Add( this.indicator[i]);
                    i++;
                }
            }
            for (i=0;i<res.Count;i++)// print
            Console.Write("a"+(i+1)+"="+res[i]);
        }
        public void substraction(Polinomials a)
        {
            int h = 0;
            List<double> res = new List<double>();
            if (a.get_extent() < this.extent)
                h = a.get_extent();
            else
                h = this.extent;
            int i = 0;
            while (i < h - 1)
            {
                res.Add(this.indicator[i]- a.indicator[i]);
                i++;
            }
            if (a.get_extent() > this.extent)
            {
                while (i < a.get_extent())
                {
                    res.Add(a.indicator[i]);
                    i++;
                }
            }
            else
            {
                while (i < this.extent)
                {
                    res.Add(this.indicator[i]);
                    i++;
                }
            }
            for (i = 0; i < res.Count; i++)// print
                Console.Write("a" + (i + 1) + "=" + res[i]);
        }
        public void multiplecation(Polinomials a)
        {
            
            List<double> res = new List<double>();
            for (int i = 0; i < this.extent; i++)
                for (int j = 0; j < a.extent; j++)
                {
                    res.Add(this.indicator[i]*a.indicator[j]);
                }

            for (int i = 0; i < res.Count; i++)// print
                Console.Write("a" + (i + 1) + "=" + res[i]);

        }


    }
}
