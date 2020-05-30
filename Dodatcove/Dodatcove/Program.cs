using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;
// Створити клас TPair, який представляє пару чисел і містить методи для їх збільшення/зменшення на 1.
//Реалізувати класи нащадки TTime (“години.хвилини”) та TMoney (“гривні.копійки”). 
//Згенерувати поступово випадковим чином n пар (час, гроші), де час – тривалість виконання роботи, 
//а гроші – вартість однієї хвилини роботи працівників. 
//Обчислити витрати на виконання кожної із робіт. 

namespace Dodatcove
{
    class TPair
    {
        public int hour;
        public int minute;
        public int money;
        public int coin;
        public TPair(int H, int Mi, int Mo, int C)
        {
            hour = H;
            minute = Mi;
            money = Mo;
            coin = C;
        }
        public int GetHour() { return hour; }
        public int GetMinute() { return minute; }
        public int GetMoney() { return money; }
        public float GetCoin() { return coin; }
        public void Add1()
        {
            Console.WriteLine("Add Time na 1: ");
            hour += 1;
            minute += 1;
            Console.WriteLine(hour + "." + minute);
        }
        public void Del1()
        {
            Console.WriteLine("Del Time na 1: ");
            hour -= 1;
            minute -= 1;
            Console.WriteLine(hour + "." + minute);
        }
        public void Add2()
        {
            Console.WriteLine("Add Money na 1: ");
            money += 1;
            coin += 1;
            Console.WriteLine(money + "." + coin);
        }
        public void Del2()
        {
            Console.WriteLine("Del Money na 1: ");
            money -= 1;
            coin -= 1;
            Console.WriteLine(money + "." + coin);
        }
        public void Work() 
        {
            float hours = hour * 60 + minute;
            float moneys = money * 100 + coin;
            float work = moneys / (100 * hours);
            Console.WriteLine("Work in 1 minute: {0} money", work);
            Console.WriteLine("Hour.Minute = {0}.{1} - Money.Coin = {2}.{3} ", hour, minute, money, coin); 
        }
    }



    class TTime : TPair
    {

        public TTime(int H, int Mi, int Mo, int C) : base(H, Mi, Mo, C)
        {
            hour = H;
            minute = Mi;
            money = Mo;
            coin = C;
        }

        public void Time()
        {
            Console.WriteLine(hour + "." + minute);
        }
    }

    class TMoney : TPair
    {
        public TMoney(int H, int Mi, int Mo, int C) : base(H, Mi, Mo, C)
        {
            hour = H;
            minute = Mi;
            money = Mo;
            coin = C;
        }

        public void Money()
        {
            Console.WriteLine(money + "." + coin);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d = 0;
            Random realRnd = new Random();
            List<TPair> pers = new List<TPair>();
            List<TTime> perss = new List<TTime>();
            List<TMoney> persss = new List<TMoney>();
            int min = 0, max = 100;
            for (int i = 1; i <= 5; i++)
            {
                a = realRnd.Next(min, max);
                b = realRnd.Next(min, max);
                c = realRnd.Next(min, max + 100000);
                d = realRnd.Next(min, max + 100000);
                pers.Add(new TPair(a, b, c, d));
                perss.Add(new TTime(a, b, c, d));
                persss.Add(new TMoney(a, b, c, d));
            }
            Console.WriteLine("Pair spent at work: ");
            foreach (TPair x in pers)
            { 
                x.Work();
            }
            Console.WriteLine("Time spent at work: ");
            foreach (TTime x in perss)
            {
                x.Time();
            }
            Console.WriteLine("Money spent at work: ");
            foreach (TMoney x in persss) 
            { 
                x.Money(); 
            }

            Console.WriteLine("Pair spent at work: ");
            foreach (TPair x in pers)
            {
                x.Del1();
            }

        }
    }
}
    

