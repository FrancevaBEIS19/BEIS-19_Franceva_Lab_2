﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(a+b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(a / b);
        }
    }
}
