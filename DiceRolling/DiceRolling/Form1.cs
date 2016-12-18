using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRolling
{
    public partial class Form1 : Form
    {
        private Dices dices = new Dices();

        public Form1()
        {
            InitializeComponent();

            DataTable table = new DataTable();
            table.Columns.Add("Sum", typeof(int));
            table.Columns.Add("Nr of times", typeof(int));

            int[] values = new int[13];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = 0;
            }

            for (int i = 0; i < 36000; i++)
            {
                dices.rollDices();
                values[dices.Sum]++;
            }

            for (int i = 2; i < 13; i++)
            {
                table.Rows.Add(i, values[i]);
            }

            dataGridView1.DataSource = table;
        }
    }
}
