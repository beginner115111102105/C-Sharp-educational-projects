using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    abstract internal class Animal
    {
        public virtual void said()
        { }
        public void who(string a) 
        {
            if (a.Equals("egg"))
                Console.WriteLine("Яйцо несущее");
            else Console.WriteLine("Живородящее");
        }

    }
    internal class Dog : Animal
    {
        string name,type="viviparous";
        int age;
        public Dog(string a,int a1)
        {
            this.name = a;
            this.age = a1;
          
        }
        public string get_name()
        { return name; }
        public void set_name(string a)
        { this.name=a; }
        public string get_type()
        { return type; }
        public int get_age()
        { return age; }
        public void set_age(int a)
        { this.age = a; }
        public override void said()
        {
            Console.WriteLine("Я собака!"); ;
        }

    }
    internal class Platyhus : Animal
    {
        string name, type="egg";
        int age;
        public Platyhus(string a, int a1)
        {
            this.name = a;
            this.age = a1;
            
        }
        public string get_name()
        { return name; }
        public void set_name(string a)
        { this.name = a; }
        public string get_type()
        { return type; }
        
        public int get_age()
        { return age; }
        public void set_age(int a)
        { this.age = a; }
        public override void said()
        {
            Console.WriteLine("Я утконос!"); 
        }
        
    }

}
