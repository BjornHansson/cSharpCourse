using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace States
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            string[] states = { "New Jersey", "Idaho", "Illinois",
            "Indiana", "Iowa", "Kansas", "Kentucky", "Maryland",
            "Massachusetts", "Michigan", "Wisconsin", "Wyoming",
            "Oregon", "Pennsylvania", "Rhode Island" };
            
            statesComboBox.Items.AddRange( states );
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // remove the selected item from the combo box.
            statesListBox.Items.Add(statesComboBox.SelectedItem);
            statesComboBox.Items.RemoveAt(statesComboBox.SelectedIndex);

            if (statesComboBox.Items.Count == 0)
            {
                MessageBox.Show("The ComboBox must contains at least one item" + "ComboBox.", "Error", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
