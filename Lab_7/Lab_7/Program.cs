
using Lab_7;

class main
{
    public static void task_1()
    {
        Console.WriteLine("Задание 1");
        Complex c1 = new(2, 3);
        Complex c2 = new(5, 4);
        Complex c3 = new();
        Console.WriteLine("Работа с числами:");
        c1.printer();
        c2.printer();
        c3.addition(c1, c2);//результат в с3
        c3.substraction(c1, c2);
        c3.multiplecation(c1, c2);
        c3.printer();
    }
    static void Main(String[] argv)
    {
        
        Console.WriteLine("Номер задания");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        { 
            case 1: { task_1(); break; }
            case 2: { task_2(); break; }
            case 3: { task_3(); break; }
            case 4: { task_4(); break; }
            case 5: { task_5(); break; }
            case 6: { task_6(); break; }
            case 7: { task_7(); break; }
            case 8: { task_8(); break; }
            case 9: { task_9(); break; }
            
            default:
                    break;
        }

    }
    public static void task_2()
    {
        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите радиус окружности");
        Circle ci1 = new(int.Parse(Console.ReadLine()));
        ci1.Draw();
        ci1.P();
        ci1.S();
        Console.WriteLine("\nВведите стороны прямоугольника");
        Console.WriteLine("Введите первую сторону");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону");
        int b = int.Parse(Console.ReadLine());
        Rectangle rec1 = new(a, b);
        rec1.Draw();
        rec1.P();
        rec1.S();
        Console.WriteLine("\nВведите стороны треугольника");
        Console.WriteLine("Введите первую сторону");
        int a1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону");
        int a2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третью сторону");
        int a3 = int.Parse(Console.ReadLine());
        Triangle tri = new(a1, a2, a3);
        tri.Draw();
        tri.P();
        tri.S();

        Dog dog = new("Карл", 3);
        Platyhus pl = new("Лиза", 2);
        Console.WriteLine("\nМеня зовут:" + dog.get_name());
        dog.said();
        dog.who(dog.get_type());
        Console.WriteLine("Меня зовут:" + pl.get_name());
        pl.said();
        pl.who(pl.get_type());
    }
    public static void task_3()
    {
        Console.WriteLine("Задание 3");
        Rational rat = new();
        Console.WriteLine("Введите числитель");
        Console.WriteLine("Введите знаменатель");
        rat.set_ch(int.Parse(Console.ReadLine()));
        rat.set_zn(int.Parse(Console.ReadLine()));
        Rational rat1 = new();
        Console.WriteLine("Введите числитель");
        Console.WriteLine("Введите знаменатель");
        rat1.set_ch(int.Parse(Console.ReadLine()));
        rat1.set_zn(int.Parse(Console.ReadLine()));
        Rational rat2 = new();
        Console.WriteLine("Действия с дробями");
        rat.print();
        rat1.print();
        rat2.addition(rat, rat1);
        rat2.substraction(rat, rat1);
        rat2.multiplecation(rat, rat1);
        rat2.delete(rat, rat1);
        rat2.print_point();
    }
    public static void task_4()
    {
        Console.WriteLine("Задание 4");
        Console.WriteLine("Создание даты по умолчанию");
        Datee dat1 = new(),dat2 = new();
        dat1.print();
        Console.WriteLine();
        Console.WriteLine("Создание даты пользователя");
        dat2.user_date();
        dat2.print();
        Console.WriteLine();
        Console.WriteLine("Увеличение на 1 день");
        dat2.add1();
        dat2.print();
        Console.WriteLine();

        Console.WriteLine("Уменьшение на 1 день");
        dat1.sub();
        dat1.print();
        Console.WriteLine();

        Console.WriteLine("На сколько дней увеличить?");
        dat2.add_day(short.Parse(Console.ReadLine()));
        dat2.print();
        


    }
    public static void task_5()
    {
        Console.WriteLine("Задание 5");
        Console.ReadLine();

    }
    public static void task_6()
    {
        Console.WriteLine("Задание 6");
        RationalNumber r1 = new(1, 8);
        RationalNumber r2 = new(2, 9);
        RationalNumber r4 = new(5, 8);
        RationalNumber r5 = new(1, 8);
        Console.WriteLine(r2.get_num() + "/" + r2.get_den() + "," + r4.get_num() + "/" + r4.get_den());
        r1.addition(r2, r4);
        Console.WriteLine(r4.get_num() + "/" + r4.get_den() + "," + r5.get_num() + "/" + r5.get_den());
        r1.substraction(r4, r5);
        Console.WriteLine(r5.get_num() + "/" + r5.get_den() + "," + r2.get_num() + "/" + r2.get_den());
        r1.multiplecation(r5, r2);
        Console.WriteLine(r2.get_num() + "/" + r2.get_den() + "," + r4.get_num() + "/" + r4.get_den());
        r1.delete(r2, r4);
        r1.relationships(r4);
        r2.relationships(r5);
        r5.relationships(r1);
    }
    public static void task_7()
    {
        Console.WriteLine("Задание 7");
        List<double> a1 = new List<double>(){ 9, 2 };
       
        Polinomials pol = new(a1.Count, a1);
        List<double> a2 = new List<double>(){ 4, -1, 0 };
      
        Polinomials pol1 = new(a2.Count, a2);
        pol.addition(pol1) ;
        Console.WriteLine();
        pol.substraction(pol1);
        Console.WriteLine();
        pol.multiplecation(pol1);
        Console.WriteLine();




    }
    public static void task_8()
    {
        Console.WriteLine("Задание 8");
        Counter counter1 = new Counter();
        Console.WriteLine("Введите минимум");
        counter1.set_min(int.Parse(Console.ReadLine()));
        Console.WriteLine("Введите максимум");
        counter1.set_max(int.Parse(Console.ReadLine()));
        counter1.set_counter(counter1.get_min());
        
        while (counter1.get_counter() < counter1.get_max()-1)
        {
            Console.WriteLine("Увеличение счетчика на 1");
            counter1.add1();
            Console.WriteLine("Счетчик равен " + counter1.get_counter());          
        }
        Console.WriteLine("Увеличение счетчика на 1");
        counter1.add1();
        Console.WriteLine("Достигнут максимум. Счетчик равен " + counter1.get_counter());





    }
    public static void task_9()
    {
        Console.WriteLine("Задание 9");
        Matrix m1 = new(3);
        Matrix m2 = new(3);
        Matrix m3 = new(3);
        m1.print();
        Console.WriteLine();
        m2.print();
        Console.WriteLine();
        m3.addition(m1,m2);
        m3.print();
        Console.WriteLine();
        m3.substraction(m1, m2);
        m3.print();
        Console.WriteLine();
        m3.multi(m1, m2);
        m3.print();




    }
}