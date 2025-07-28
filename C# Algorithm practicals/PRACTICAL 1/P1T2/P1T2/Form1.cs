using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius=double.Parse(textBox1.Text);
            double circum=2*radius*Math.PI;
            label2.Text = "The circumference of a circle is " +Math.Round(circum,2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            double area=Math.Pow(radius,2)*Math.PI;
            label2.Text= "The area of a circle is "+Math.Round(area,2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            double sphere=Math.Pow(radius,2)*4*Math.PI;
            label2.Text="The sphere of the circle is "+Math.Round(sphere,2);

        }
    }
}
