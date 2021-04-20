using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double th1 = 0.53;
        private double th2 = 0.35;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private int n = 10;
        private double length = 100;
        private string color1 = "Red";
        //private Pen pen = new Pen(Color.White);

        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        
        public void drawCeylayTree(int n, double x0, double y0, double length, double th)
        {
            //n = Int32.Parse(this.textBox1.Text);
            //length = Double.Parse(this.textBox2.Text);
            //th = -Math.PI / 2;
            //x0 = 200;
            //y0 = 310;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCeylayTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCeylayTree(n - 1, x1, y1, per2 * length, th - th2);
            
        }

        private Pen color(string n)
        {
            
            switch (n)
            {
                case "red":return Pens.Red; 
                case "yellow": return Pens.Yellow;
                case "blue": return Pens.Blue;
                case "green": return Pens.Green;
                default:return Pens.White;
            }
        }
        public void drawLine(double x0, double y0, double x1, double y1)
        {
            
           graphics.DrawLine(color(color1), (int)x0, (int)y0, (int)x1, (int)y1); 
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double per1 = Double.Parse(this.textBox3.Text);
            double per2 = Double.Parse(this.textBox4.Text);
            double th1 = Double.Parse(this.textBox5.Text);
            double th2 = Double.Parse(this.textBox4.Text);
            string color1 = this.comboBox1.SelectedItem.ToString();
            if (graphics == null) graphics = this.CreateGraphics();
            drawCeylayTree(n, 200, 310, length, -Math.PI / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("red");
            this.comboBox1.Items.Add("yellow");
            this.comboBox1.Items.Add("blue");
            this.comboBox1.Items.Add("green");
        }
    }
}


