using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDodatcove
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
        public int GetCoin() { return coin; }
        public int Add1()
        {
            Console.WriteLine("Add hour na 1: ");
            hour += 1;
            Console.WriteLine(hour + "." + minute);
            return hour;
        }
        public int Add11()
        {
            Console.WriteLine("Add minute na 1: ");
            minute += 1;
            Console.WriteLine(hour + "." + minute);
            return minute;
        }
        public int Del1()
        {
            Console.WriteLine("Del hour na 1: ");
            hour -= 1;
            Console.WriteLine(hour + "." + minute);
            return hour;
        }
        public int Del11()
        {
            Console.WriteLine("Del minute na 1: ");
            minute -= 1;
            Console.WriteLine(hour + "." + minute);
            return minute;
        }
        public int Add2()
        {
            Console.WriteLine("Add Money na 1: ");
            money += 1;
            Console.WriteLine(money + "." + coin);
            return money;
        }
        public int Add22()
        {
            Console.WriteLine("Add Coin na 1: ");
            coin += 1;
            Console.WriteLine(money + "." + coin);
            return coin;
        }
        public int Del2()
        {
            Console.WriteLine("Del Money na 1: ");
            money -= 1;
            Console.WriteLine(money + "." + coin);
            return money;
        }
        public int Del22()
        {
            Console.WriteLine("Del Coin na 1: ");
            coin -= 1;
            Console.WriteLine(money + "." + coin);
            return coin;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int a, b, c, d = 0;
            Random realRnd = new Random();
            int min = 0, max = 100;
            for (int i = 1; i <= 5; i++)
            {
                a = realRnd.Next(min, max);
                b = realRnd.Next(min, max);
                c = realRnd.Next(min, max + 100000);
                d = realRnd.Next(min, max + 100000);
                Application.Run(new Pairs(a, b, c, d));
                Application.Run(new Times(a, b, c, d));
                Application.Run(new Moneys(a, b, c, d));
            }
        }
    }
}
