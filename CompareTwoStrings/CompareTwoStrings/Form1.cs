using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareTwoStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            int value = s1.CompareTo(s2);

            if (value == 0)
            {
                result.Text = s1 + " IS EQUAL TO " + s2;
            }
            else if (value == 1)
            {
                result.Text = s1 + " IS GREATER THAN " + s2;
            }
            else if (value == -1)
            {
                result.Text = s1 + " IS LESS THAN " + s2;
            }
        }
    }
}
