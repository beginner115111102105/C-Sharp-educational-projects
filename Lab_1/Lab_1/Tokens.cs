using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Tokens
    {
        private string token;
        private string lastgroup;
        private string span;
        private string[] Constant = new string[] { "pi", "e", "sqrt2", "ln2","ln10" };
        private string[] Function = new string[] { "sin", "cos", "tg", "ctg", "tan", "cot", "sinh", "cosh", "th", "cth", "tanh", "coth", "ln", "lg", "log", "exp", "sqrt", "cbrt", "abs", "sign" };
        private string[] Operator = new string[] { "^", "*", "/", "-", "+" };
        
        public void Span(string match)
        {
            string s="";
            span= s ;
        }
        public void SetToken(string match)
        {
            this.token = match ;    
        }
        public string GetToken(String match)
        {
            return this.token ;
        }
        public void LastGroup(string match)
        {
            string s = "";
            lastgroup = s;
        }
        public string ShowToken(string match)
        {
            string s = "";
            return s;

        }
    }
   
}
