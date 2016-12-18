using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double fahrenheit = Convert.ToDouble(textBox1.Text);
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            result.Text = Convert.ToString(celsius);
        }
    }
}
