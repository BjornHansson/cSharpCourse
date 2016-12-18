using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
            new Font(outputLabel.Font.Name, outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
            new Font(outputLabel.Font.Name, outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Italic);
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
            new Font(outputLabel.Font.Name, outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Underline);
        }

        private void strikeoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
            new Font(outputLabel.Font.Name, outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Strikeout);
        }
    }
}