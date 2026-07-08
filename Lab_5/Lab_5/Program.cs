using Lab_5;
using System.Drawing;

class main
{
    static void Main(String[] argv)
    {

        Console.WriteLine("Задание 1");
        Dog fido=new();
        fido.speak();
        Console.WriteLine();
        fido.wag_tail();
        Console.WriteLine("fido is "+fido.get_age()+" years old");
        Console.WriteLine("\nЗадание 3");
        Console.WriteLine("Введите возраст");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите вес");
        double w = double.Parse(Console.ReadLine());
        Dog fido1 = new (a,w);
        Console.WriteLine("Возраст: "+fido1.get_age()+" ,вес: "+fido1.get_weight());
        

    }
}