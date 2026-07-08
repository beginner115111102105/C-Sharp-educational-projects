using Lab_3;


class main
{


    static void Main(String[] argv)
    {
        Console.WriteLine("Задание 1");
        Cat frisky = new Cat(5, 8);
        Cat r_cat = frisky;
        Console.WriteLine("frisky is age:" + frisky.getAge() + ", weight:" + frisky.getWeight());
        Console.WriteLine("frisky is " + r_cat.getAge() + " years old.");
        Console.WriteLine("frisky is " +r_cat.getWeight() + " pounds.\n");
        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите любое число");
        // Operator num= new(int.Parse(Console.ReadLine()));
        Operator num = new();
        num.set_number(Double.Parse(Console.ReadLine()));
        Console.WriteLine("Вы ввели "+num.get_number()+" квадрат равен "+ num.number_2 ()+ " , куб равен " + num.number_3());
        Console.WriteLine("\nЗадание 3");
        Console.WriteLine("Make a cat");
        TypedReference ref_frisky = __makeref(frisky);

         
        Console.WriteLine("Calling f1");
        f1(frisky);
        Console.WriteLine("Calling f2");
        f2();




    }







    public static Cat f1(Cat t_cat)
    {
        Console.WriteLine("f1 returning");
        return t_cat;
    }

     public static void f2()
     {
         Console.WriteLine("f2 returning");
     }
}

