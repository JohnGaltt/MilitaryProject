﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryProject
{
    public partial class FuelCalculate : Form
    {
        public FuelCalculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                textBox5.Text = (Double.Parse(textBox4.Text) / Double.Parse(textBox7.Text)).ToString();
                textBox6.Text = ((Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text) / Double.Parse(textBox7.Text)) * Double.Parse(textBox3.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
