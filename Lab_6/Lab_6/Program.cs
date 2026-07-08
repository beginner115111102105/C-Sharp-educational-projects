using Lab_6;
using System.Numerics;

class main
{
    public const int number_of_hourse = 5,num=2;
    static void Main(String[] argv)
    {

        Console.WriteLine("Задание 1");;
        Hourse[] ranch = new Hourse[number_of_hourse];
        Hourse p_hourse=new();
        int i, choice;
        for (i = 0; i < number_of_hourse; i++)
        {
            Console.WriteLine("1 - hourse, 2 - pegas");
            choice=int.Parse(Console.ReadLine());
            if (choice == 2)
                p_hourse = new Pegasys();
            else p_hourse = new();
            ranch[i] = p_hourse;    
        }
        for (i = 0; i < number_of_hourse; i++)
        {
            ranch[i].fly();
        }

        Console.WriteLine("\nЗадание 2");
        for (i = 0; i < number_of_hourse; i++)
        {
            if ( ranch[i] is Pegasys) { 
                Pegasys p_peg = (Pegasys)ranch[i];
                p_peg.fly();    }
            else
                Console.WriteLine("Just a house");
        }

        Console.WriteLine("\nЗадание 3");
        Bird[] aviary = new Bird[num];
        Hourse[] ranch1 = new Hourse[num];
        Bird p_bird = new();
        Hourse p_hourse1 = new();
        for (i = 0; i < num; i++)
        {
            Console.WriteLine("1 - hourse,2 - pegas");
            choice = int.Parse(Console.ReadLine());
            if (choice == 2)
                p_hourse = new Pegasys();
            else p_hourse = new();
            ranch1[i] = p_hourse;
        }
        for (i = 0; i < num; i++)
        {
            Console.WriteLine("1 - bird,2 - pegas");
            choice = int.Parse(Console.ReadLine());
            if (choice == 2)
                p_bird = new Pegasys();
            else p_bird = new();
            aviary[i] = p_bird;
        }
        for (i = 0; i < num; i++)
        {
            Console.WriteLine("ranch1["+i+"]");
            ranch1[i].whinny();
        }
        for (i = 0; i < num; i++)
        {
            Console.WriteLine("aviary[" + i + "]");
            aviary[i].chirp();
            aviary[i].fly();
        }

        Console.WriteLine("\nЗадание 4");
        bool f=false;
        Shape sp = new();
        while (!f)
        {
            Console.WriteLine("1 - circle, 2 - rectengle,3 - square,4 - quit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    sp = new Circle(4);
                    sp.draw();
                    break;
                case 2:
                    int ch1 = int.Parse(Console.ReadLine());
                    int ch2 = int.Parse(Console.ReadLine());
                    sp = new Rectangle(ch1, ch2);
                    sp.draw();
                    break ;
                case 3:
                    sp=new Square(5);
                    sp.draw();
                    break;
                case 0:
                    f = true;
                    break;
                default:
                    Console.WriteLine("enter a numbet between 0 and 3");
                    continue;
                    break;
            }
            if(f) sp.draw();
            
        }
    }
}
