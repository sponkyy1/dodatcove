using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDodatcove
{
    public partial class Pairs : Form
    {
        public int hour;
        public int minute;
        public int money;
        public int coin;
        public Pairs(int a, int b, int c, int d)
        {
            hour = a;
            minute = b;
            money = c;
            coin = d;
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Del11();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Add22();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Del11();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Add11();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            Console.WriteLine("Pair spent at work: ");
            foreach (TPair x in pers)
            {
                x.Work();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Del2();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Add2();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Del1();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            List<TPair> pers = new List<TPair>();
            pers.Add(new TPair(hour, minute, money, coin));
            foreach (TPair x in pers)
            {
                x.Add1();
            }
        }
    }
}
