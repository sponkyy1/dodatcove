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
    public partial class Moneys : Form
    {
        public int hour;
        public int minute;
        public int money;
        public int coin;
        public Moneys(int a, int b, int c, int d)
        {
            hour = a;
            minute = b;
            money = c;
            coin = d;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TMoney> persss = new List<TMoney>();
            persss.Add(new TMoney(hour, minute, money, coin));
            Console.WriteLine("Money spent at work: ");
            foreach (TMoney x in persss)
            {
                x.Money();
            }
        }
    }
}
