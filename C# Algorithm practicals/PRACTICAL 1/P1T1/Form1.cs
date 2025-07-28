using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numEggs1=int.Parse(textBox1.Text);
            int numEggs2 = int.Parse(textBox2.Text);
            int numEggs3 = int.Parse(textBox3.Text);
            int numEggs4= int.Parse(textBox4.Text);
            int numEggs5= int.Parse(textBox5.Text);
            int total, dozen, eggs;
            total = numEggs1 + numEggs2 + numEggs3 + numEggs4+ numEggs5;
            dozen = total / 12;
            eggs = total % 12;
            label6.Text = "You have a sum of" + total + "eggs which makes" + dozen + "dozens" + eggs + "eggs";

        }
    }
}
