// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Lab_1;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography;

class main
{
    public void PassCorrect()
    {
        Console.WriteLine("Введите пароль ");
        String pass = Console.ReadLine();


        while (pass.Length < 8)
        {
            Console.WriteLine("Ваш пароль слишком короткий, повторите ввод");
            pass = Console.ReadLine();
        }
        bool[] CorrectPasswrd = new bool[pass.Length];
        int[] Condition = new int[3] { 0, 0, 0 }; //UpperCase,LowerCase,Numbers
        List<char> Chars = new List<char>();//^,$,%,@,#,&,*,!,?
        for (int i = 0; i < pass.Length; i++)
        { CorrectPasswrd[i] = false; }

        for (int i = 0; i < pass.Length; i++)
        {
            if (i != pass.Length - 1)
            {
                if (pass[i] == pass[i + 1]) { Console.WriteLine("Символ " + pass[i] + " повторяется. Повторите попытку"); return; }
            }

            CurrentPassword cp = new CurrentPassword(pass[i]);
            if (cp.IsUpperCase()) { Condition[0]++; CorrectPasswrd[i] = true; }
            if (cp.IsLowerCase() && CorrectPasswrd[i] != true) { Condition[1]++; CorrectPasswrd[i] = true; }
            if (cp.IsNumbers() && CorrectPasswrd[i] != true) { Condition[2]++; CorrectPasswrd[i] = true; }
            if (cp.IsSpecC() != '0' && CorrectPasswrd[i] != true) { Chars.Add(pass[i]); CorrectPasswrd[i] = true; }
        }
        for (int i = 0; i < CorrectPasswrd.Length; i++)
        {
            if (CorrectPasswrd[i] == false) { Console.WriteLine("Символ " + pass[i] + " неверный. Повторите попытку"); return; }
        }

        for (int i = 0; i < Condition.Length; i++)
        {
            if (Condition[i] < 0) { Console.WriteLine("Не хватает символов верхнего регистра, нижнего регистра или цифр. Повторите попытку"); return; }
        }
        Chars = Chars.Union(Chars).ToList();


        if (Chars.Count < 2) { Console.WriteLine("Не хватает специальных символов. Повторите попытку"); return; }
        else Console.WriteLine("Вы ввели верный пароль");
    }
    public void ColorCorrect()
    {
        Console.WriteLine("Введите цвет ");

        //что программа оптимизирует (минимизирует или максимизирует)
        //оптимизация,безусловная оптимизация система ограничений, линейное программирование
        //целевая функция ф(х)-макс, система ограничений д1(х)...дн(х)

        //задача математического (программмирование)моделирование задача планирования   исследование операций
        //тахо ввидение в исседовательские операции
        //приблеженные методы: эвристические и метоивристические точность/время
        // 
        // развивать мелкую маторику
        String color = Console.ReadLine();
        color.Trim();

        ColorType ct = new ColorType(color);
        //Console.WriteLine(color.Length);
        if (ct.IsHEX() == true) { Console.WriteLine("Ура! Все верно"); return; }
        else if (ct.IsRGB() == true) { Console.WriteLine("Ура! Все верно"); return; }
        else if (ct.IsHSL() == true) { Console.WriteLine("Ура! Все верно"); return; }
        else Console.WriteLine("Неверный формат");
    }

    static void Main(String[] argv)
    {
        
        
        Console.WriteLine("Введите выражение");

        String expression = Console.ReadLine();
        string[] Constant = new string[] { "pi", "e", "sqrt2", "ln2", "ln10" };
        string[] Function = new string[] { "sin", "cos", "tg", "ctg", "tan", "cot", "sinh", "cosh", "th", "cth", "tanh", "coth", "ln", "lg", "log", "exp", "sqrt", "cbrt", "abs", "sign" };
        string[] Operator = new string[] { "^", "*", "/", "-", "+" };
        List<Token1> token1s = new List<Token1>();
        
        bool[] CheckToken =new bool[expression.Length];
        for (int i = 0; i < CheckToken.Length; i++)
        {
            if (expression[i]==' ') CheckToken[i] = true;
            else CheckToken[i] = false;
        }
        for (int i = 0; i < Function.Length; i++)
        {
            if (expression.Contains(Function[i]))
            {
                int index = expression.IndexOf(Function[i], 0);
                while (index > -1)
                {
                    for (int m = index; m < index+Function[i].Length; m++)
                    { CheckToken[m] = true; }
                    Token1 t = new Token1("function", index, index + Function[i].Length);
                    token1s.Add(t);
                    index = expression.IndexOf(Function[i], index + Function[i].Length);
                }
            }

        }
        for (int i = 0; i < Operator.Length; i++)
        {
            if (expression.Contains(Operator[i]))
            {
                int index = expression.IndexOf(Operator[i], 0);
                while (index > -1)
                {
                    for (int m = index; m < index + Operator[i].Length; m++)
                    { CheckToken[m] = true; }
                    Token1 t = new Token1("operator", index, index + Operator[i].Length);
                    token1s.Add(t);
                    index = expression.IndexOf(Operator[i], index + Operator[i].Length);
                }
            }

        }
        for (int i = 0; i < Constant.Length; i++)
        {
            if (expression.Contains(Constant[i]))
            {
                int index = expression.IndexOf(Constant[i], 0);
                while (index > -1)
                {
                    for (int m = index; m < index + Constant[i].Length; m++)
                    { CheckToken[m] = true; }
                    Token1 t = new Token1("constant", index, index + Constant[i].Length);
                    token1s.Add(t);
                    index = expression.IndexOf(Constant[i], index + Constant[i].Length);
                }
            }

        }
        if (expression.Contains('('))
        {
            int index = expression.IndexOf('(', 0);
            while (index > -1)
            {
                CheckToken[index] = true;
                Token1 t = new Token1("left_parenthesis", index, index + 1);
                token1s.Add(t);
                index = expression.IndexOf('(', index +1);
            }
        }
        if (expression.Contains(')'))
        {
            int index = expression.IndexOf(')', 0);
            while (index > -1)
            {
                CheckToken[index] = true;
                Token1 t = new Token1("right_parenthesis", index, index + 1);
                token1s.Add(t);
                index = expression.IndexOf(')', index + 1);
            }
        }
        
        //for (int i = 0; i < CheckToken.Length; i++)
        //{
        //    Console.Write(i+" "+CheckToken[i]+" , ");
        //}
        for (int i = 0; i < expression.Length; i++)
        {
            if (CheckToken[i] != true)
            {
                string s = "";
                while (CheckToken[i] != true)
                {
                    CheckToken[i] = true;
                    s = s + expression[i];
                            
                    i++; 
                    if (i == expression.Length) break;
                    
                }                
                double d = 0;
                if (s.Contains('.')) s=s.Replace('.', ',');
                double.TryParse(s, out d);
                if (d != 0)
                {
                    //Console.WriteLine(d + " d");
                    Token1 t = new Token1("number", i - s.Length, i);
                    token1s.Add(t);
                }               
                else
                {
                    Token1 t = new Token1("variable", i - s.Length, i);
                    token1s.Add(t);
                }
            }

        }

        for (int i = 0; i < token1s.Count; i++)
        {
            for (int j = i; j < token1s.Count; j++)
            {
                if (token1s[i].GetStart() > token1s[j].GetStart()) 
                {
                    Token1 t1 = token1s[i];
                    token1s[i] = token1s[j];
                    token1s[j]=t1;
                }
            }
            
            Console.WriteLine("{"+'"'+"type:" + "\" \"" + token1s[i].GetGroup() + "\", \"" + "span" + "\": [" + token1s[i].GetStart()+", "+ token1s[i].GetEnd()+"]}");
        }



    }

}
