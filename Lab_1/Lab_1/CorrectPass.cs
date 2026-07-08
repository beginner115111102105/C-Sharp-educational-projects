using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class CorrectPass
    {
        private int PassLength;
        private bool Latin;
        private int UpperCase;
        private int LowerCase;
        private int Numbers;
        private int SpecialChars;
        private String SpecC="^$%@#&*!?";
        public CorrectPass()
        {
            this.PassLength = 8;
            this.Latin = true;
            this.UpperCase = 1;
            this.LowerCase = 1;
            this.Numbers = 1;
            this.SpecialChars = 2;
        }
       public bool PassVerification(String pass) 
       {
            bool PassLength1=false;
            bool UpperCase1 = false;
            bool LowerCase1 = false;
            bool Numbers1 = false;
            bool SpecialChars1 = false;
          
            if (pass.Length >= this.PassLength) PassLength1 = true;
            if (PassLength1 == false) { Console.WriteLine("Ваш пароль слишком короткий, повторите ввод"); return false; }
            bool[] CorrectPasswrd = new bool[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            { CorrectPasswrd[i] = false; }
                for (int i = 0; i < pass.Length; i++)
            {
                Console.WriteLine("i="+i+"char="+ (int)pass[i]);


                if ((int)pass[i] > 64 && (int)pass[i] < 91) { UpperCase1 = true; CorrectPasswrd[i] = true; }
                if ((int)pass[i] > 96 && (int)pass[i] < 123) { LowerCase1 = true; CorrectPasswrd[i] = true; }
                if ((int)pass[i] > 47 && (int)pass[i] < 58) { Numbers1 = true; CorrectPasswrd[i] = true; }
            }
            int FullChar = this.SpecialChars;
            for (int i = 0; i < pass.Length; i++)
            {
                for (int j = 0; j < this.SpecC.Length; j++)
                { 
                    if ((int)pass[i]==(int)this.SpecC[j]) { CorrectPasswrd[i] = true; FullChar--; }
                }
                if (FullChar <= 0) SpecialChars1 = true; 
            }
            for (int i = 0; i < pass.Length; i++)
            {
                if (CorrectPasswrd[i] == false ) { Console.WriteLine("Ваш пароль содержит недопустимый символ (\"" + pass[i] + "\", позиция "+(i+1)+"), повторите ввод"); return false; }
                
            }
           
            if (UpperCase1 == false) { Console.WriteLine("Отсутствуют символы в верхнем регистре, повторите ввод"); return false; }
            if (LowerCase1 == false) { Console.WriteLine("Отсутствуют символы в нижнем регистре, повторите ввод"); return false; }
            if (Numbers1 == false) { Console.WriteLine("В пароле отсутствуют числа, повторите ввод"); return false; }
            if (SpecialChars1 == false) { Console.WriteLine("В пароле не хватает специальных символов (^$%@#&*!?), повторите ввод"); return false; }

           
            return true;
        }
    }
}
