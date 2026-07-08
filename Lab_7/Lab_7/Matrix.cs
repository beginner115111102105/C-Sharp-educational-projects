using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Matrix
    {
        private int size;
        private List<List<double>> mtrx = new List<List<double>>();

        public Matrix(int s)
        {
            size = s;
            Console.WriteLine("Создание новой матрицы");
            for (int i = 0; i < s; i++)
            {
                mtrx.Add(new List<double>());
                for (int j = 0; j < s; j++)
                {
                    Console.WriteLine("Введите значение:");
                    mtrx[i].Add(double.Parse(Console.ReadLine()));
                }
            }
        }
        public Matrix(int size, List<List<double>> mtrx)
        {
            this.size = size;
            this.mtrx = mtrx;
        }
        public int get_size()
        {
            return this.size;
        }
        public void set_size(int a)
        {
            this.size = a;
        }
        public List<List<double>> get_mtrx()
        {
            return this.mtrx;
        }
        public void set_mtrx(List<List<double>> num)
        {
            this.mtrx = num;
        }
        public void addition(Matrix a, Matrix b)
        {
            if (a.size == b.size)
            {
                List < List<double>> res = new List<List<double>>();
                for (int i = 0; i < a.size; i++)
                {
                    res.Add(new List<double>());
                    for (int j = 0; j < a.size; j++)
                    {
                        res[i].Add(a.mtrx[i][j]+ b.mtrx[i][j]);
                    }
                }
                this.set_size(a.size);
                this.set_mtrx(res);
            }
            else {Console.WriteLine("Матрицы нельзя сложить");return;}
        }
        public void substraction(Matrix a, Matrix b)
        {
            if (a.size == b.size)
            {
                List<List<double>> res = new List<List<double>>();
                for (int i = 0; i < a.size; i++)
                {
                    res.Add(new List<double>());
                    for (int j = 0; j < a.size; j++)
                    {
                        res[i].Add(a.mtrx[i][j] - b.mtrx[i][j]);
                    }
                }
                this.set_size(a.size);
                this.set_mtrx(res);
            }
            else { Console.WriteLine("Матрицы нельзя вычесть"); return; }
        }
        public void multi(Matrix a, Matrix b)
        {
            if (a.size == b.size)
            {
                List<List<double>> res = new List<List<double>>();
                for (int i = 0; i < a.size; i++)
                {
                    res.Add(new List<double>());
                    for (int j = 0; j < a.size; j++) 
                    {
                        res[i].Add(0);
                        for (int k = 0; k < a.size; k++)
                        { res[i][j] += a.mtrx[i][k] * b.mtrx[k][j]; }
                    }
                   
                }
                
                this.set_size(a.size);
                this.set_mtrx(res);
            }
            else { Console.WriteLine("Матрицы нельзя умножить"); return; }
            
        }
        public void print()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    Console.Write(this.mtrx[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

    }

}
