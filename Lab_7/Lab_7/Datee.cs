using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Datee
    {
        private short[] date=new short[3];
        public Datee()
        {
            date=new short[3] {1,1,2001};
        }
        public Datee(short[] date)
        {
            this.date = date;
        }
        public short[] get_date()
        {
            return date;
        }
        public void set_date(short[] date)
        {
            this.date=date;
        }
        public void user_date()
        {
            Console.WriteLine("Введите дату в формате дд.мм.гггг");

            string s = Console.ReadLine();
            string[] subs = s.Split(".");
            int i = 0;
            foreach (string sub in subs)
            {
                date[i] = (short)int.Parse(sub);
                i++;
            }
        }
        public void add1()
        {
            add_day(1); }
        public void sub()
        { 
            date[0] -= 1;
            if (date[0]==0)
            {
                date[1] -= 1;
                if (date[1] == 0)
                {
                    date[2] -= 1;
                    date[1] = 12;
                    date[0] = 31;
                }
                else
                {
                    switch (date[1])
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 9:
                        case 12:
                            date[0] = 31;
                            break;
                        case 2:
                            if (date[2] % 4 == 0)
                            { date[0] = 29; }
                            else { date[0] = 28; }
                            break;
                        default: { date[0] = 30; break; }

                    }
                }
                

            }
        }
        public void add_day(short d)
        {
            short mes, day;
            do
            {
                mes = date[1];
                switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 9:
                case 12: 
                    day = 31;
                    break;
                case 2:
                    if (date[2] % 4 == 0)
                    { day = 29; }
                    else { day = 28; }
                    break;
                default : { day = 30; break; }

            }
            
                if ((short)(date[0] + d) > day)
                {
                    date[0] = (short)(date[0] + d - day);
                    if (date[1] + 1 > 12)
                    { date[1] = 1; date[2] += 1; }
                    else date[1] += 1;
                }
                else date[0] = (short)(date[0] + d);
                d = 0;
            }
            while (date[0]>day);
        }
        public void print()
        {
            Console.Write("Ваша дата: ");
            if (date[0]/10==0)
            {
                Console.Write("0"+ date[0]+".");
            }
            else Console.Write(date[0] + ".");
            if (date[1] / 10 == 0)
            {
                Console.Write("0" + date[1] + ".");
            }
            else Console.Write(date[1] + ".");
            Console.Write(date[2]);
        }

    }
}
