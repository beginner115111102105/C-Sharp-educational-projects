using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class CurrentPassword
    {
        private char PassChar;      
        public CurrentPassword(char PassChar)
        { this.PassChar = PassChar; }
        
        public bool IsUpperCase()
        {
            bool result = false; 
            if ((int)this.PassChar > 64 && (int)this.PassChar < 91) { result = true;  }
            return result;
        }
        public bool IsLowerCase()
        {
            bool result = false;
            if ((int)this.PassChar > 96 && (int)this.PassChar < 123) { result = true; }
            return result;
        }
        public bool IsNumbers()
        {
            bool result = false;
            if ((int)this.PassChar > 47 && (int)this.PassChar < 56) { result = true; }
            return result;
        }
        public char IsSpecC()
        {
            char result = '0';
            string SpecC = "^$%@#&*!?";
            for (int i = 0; i < SpecC.Length; i++)
            if ((int)this.PassChar== SpecC[i]) { result = SpecC[i]; }
            return result;
        }

    }
}
