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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Check = new Form3();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Check = new Form4();
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Check = new Form5();
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Check = new Form6();
            Check.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 Check = new Form7();
            Check.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 Check = new Form8();
            Check.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 Check = new Form9();
            Check.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
