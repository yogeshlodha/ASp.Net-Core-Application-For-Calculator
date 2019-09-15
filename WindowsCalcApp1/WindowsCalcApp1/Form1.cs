using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsCalcApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder strNum = new StringBuilder("");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // StringBuilder Num = new StringBuilder(txtNumber.Text);
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "1"));
            txtNumber.Text = strNum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat( txtNumber.Text, "2"));
            txtNumber.Text = strNum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat( txtNumber.Text,"3"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "4"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "5"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "6"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "7"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "8"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "9"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            strNum.Clear();
            strNum.Append(string.Concat(txtNumber.Text, "0"));
            txtNumber.Text = strNum.ToString();
            txtNumber.Text = strNum.ToString();
        }
    }
}
