using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public int a;
        public int b;
        public int side;
        public void Lefts()
        {
            a = a + side;
        }
        public void Rights()
        {
            a = a - side;
        }
        public void numbers()
        {
            Console.WriteLine($"{a} {b}  {a + side} {b}   {a} {b + side} {a + side} {b + side}");
        }
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gra;
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            a = 5;
            b = 34;
            side = 150;
            numbers();
            gra = CreateGraphics();
            gra.Clear(Color.Azure);
            gra.DrawRectangle(Pens.Black, a, b, side, side);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                a +=5;
                b = 34;
                side = 150;
                numbers();
                gra = CreateGraphics();
                gra.Clear(Color.Azure);
                gra.DrawRectangle(Pens.Black, a, b, side, side);
            }
            if (e.KeyData == Keys.Left)
            {
                a -= 5;
                b = 34;
                side = 150;
                numbers();
                gra = CreateGraphics();
                gra.Clear(Color.Azure);
                gra.DrawRectangle(Pens.Black, a, b, side, side);
            }
        }
    }
}
