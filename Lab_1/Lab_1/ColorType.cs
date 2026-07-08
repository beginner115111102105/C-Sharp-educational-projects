using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class ColorType
    {
        private string ColorExpression;
        public ColorType(string ColorExpression)
        { this.ColorExpression = ColorExpression; }
        public bool IsRGB()
        {
            
            if (this.ColorExpression.Contains("rgb")) 
                if (this.ColorExpression.Contains('(') && this.ColorExpression[this.ColorExpression.Length-1] ==')') 
                {
                    byte e = 0;
                    for (int i = this.ColorExpression.IndexOf('(') + 1; i < this.ColorExpression.IndexOf(')'); i++)
                    {
                        
                        string ss = "";
                        while (this.ColorExpression[i] != ',')
                        {
                            if ((int)this.ColorExpression[i] > 47 && (int)this.ColorExpression[i] < 58) { ss += this.ColorExpression[i]; }
                            i++;
                            if (i == this.ColorExpression.IndexOf(')')) break;

                        }
                        int d = -1;
                        int.TryParse(ss, out d);

                        if (this.ColorExpression.Contains('%'))
                        {
                            if (d >= 0 && d < 101) e++;
                            else return false;
                        }
                        else if (d >= 0 && d < 256)  e++; 
                        else return false;
                    }
                    if (e!=3) {Console.WriteLine("Неверный формат");return false;}
                    else Console.WriteLine("Ура! Все верно");
                }
                else return false;
            else return false;
            return true;
        }        
        public bool IsHEX()
        {
            //bool result = false;
            if (this.ColorExpression.Contains("#"))  
                if (this.ColorExpression.Length == 4 || this.ColorExpression.Length == 7) 
                {
                    
                    for (int i = 1; i < this.ColorExpression.Length; i++)
                        if (!((this.ColorExpression[i] > 47 && this.ColorExpression[i] < 58) || (this.ColorExpression[i] > 64 && this.ColorExpression[i] < 71) || (this.ColorExpression[i] > 96 && this.ColorExpression[i] < 103)))
                        return false; 

                        //else result = true;
                }                
                else return false;            
            else return false ;
            return true;
        }
        public bool IsHSL()
        {
            if (this.ColorExpression.Contains("hsl"))
            {
                if (this.ColorExpression.IndexOf(')') != this.ColorExpression.Length - 1)  return false; 

                this.ColorExpression = this.ColorExpression.Substring(this.ColorExpression.IndexOf('(') + 1, this.ColorExpression.Length - 2 - this.ColorExpression.IndexOf('('));
                string[] ss = this.ColorExpression.Split(',');
                if (ss.Length != 3) return false;
                else
                {
                    for (int i = 0; i < ss.Length; i++)
                    {
                        int d = -1;
                        switch (i)
                        {
                            case 0:
                                {
                                    int.TryParse(ss[i], out d);
                                    //Console.WriteLine(d + " hh  " + ss[i]);
                                    if (!(ss[i].Contains('%')))
                                    {
                                        if (d >= 0 && d < 360 && !(ss[i].Contains('%'))) { Console.Write(""); }
                                        else return false;

                                    }
                                    else return false;
                                    break;
                                }
                            case 1:
                                {
                                    if (ss[i].Contains('%'))
                                    {
                                        ss[i] = ss[i].Remove(ss[i].Length - 1);
                                        //Console.WriteLine(ss[i]);
                                        int.TryParse(ss[i], out d);
                                        //Console.WriteLine(d + " hh  " + ss[i]);

                                        if (d >= 0 && d < 101) { Console.Write(""); }
                                        else return false;

                                    }
                                    else return false;
                                    break;
                                }
                            case 2:
                                {
                                    if (ss[i].Contains('%'))
                                    {
                                        ss[i] = ss[i].Remove(ss[i].Length - 1);
                                        //Console.WriteLine(ss[i]);
                                        int.TryParse(ss[i], out d);
                                        //Console.WriteLine(d + " hh  " + ss[i]);

                                        if (d >= 0 && d < 101) { Console.Write(""); }
                                        else  return false;
                                        
                                    }
                                    else return false; 
                                    break;
                                }

                        }

                    }
                }

            }
            else return false;
            
                return true;
        }
    }
}
