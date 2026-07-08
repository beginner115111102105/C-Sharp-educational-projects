using Lab_4;

class main
{    
    static void Main(String[] argv)
    {
        Console.WriteLine("Задание 1");
        Rectangle rest=new(30,5);
        Console.WriteLine("Draw:");
        rest.draw();
        Console.WriteLine("Draw:");
        rest.draw(10,4);

        Console.WriteLine("\nЗадание 2");
        Rectangle rest1 = new();
        Console.WriteLine("rest1 widht "+rest1.get_widht());
        Console.WriteLine("rest1 height "+rest1.get_height());
        Console.WriteLine("Введите ширину");  
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину");
        int b = int.Parse(Console.ReadLine());
        Rectangle rest3 = new(a, b);
        Console.WriteLine("rest1 widht " + rest3.get_widht());
        Console.WriteLine("rest1 height " + rest3.get_height());

        Console.WriteLine("\nЗадание 3");
        Counter i = new();
        Console.WriteLine("Value of couter is: "+i.get_value());
        i.increment();
        Console.WriteLine("Value of couter is: " + i.get_value());
        i.operator_();
        Console.WriteLine("Value of couter is: " + i.get_value());
        Console.WriteLine("\nЗадание 4");
        
        i.operator_();
        Counter ai = new();
 
        ai.set_value(i.get_value());
        Console.WriteLine("Value of a is: " + ai.get_value());
        Console.WriteLine("Value of couter is: " + i.get_value());
        i.increment();
        ai.set_value(i.get_value());
        Console.WriteLine("Value of a is: " + ai.get_value());
        Console.WriteLine("Value of couter is: " + i.get_value());
        Console.WriteLine("\nЗадание 5");
        int a2 = 2;
        Counter var1 = new(a2), var2 = new(5), var3 = new();
        var3.set_value(var1.operator_(var2));
        Console.WriteLine("var1 " +var1.get_value());
        Console.WriteLine("var2 " + var2.get_value());
        Console.WriteLine("var3 " + var3.get_value());
















    }
}
