using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseballDatabaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // case sensitivity!
            this.playersBindingSource.DataSource =
                from player in this.baseballDataSet.Players
                where player.LastName.StartsWith(searchPlayer.Text)
                orderby player.PlayerID
                select player;
        }

        private void searchPlayer_TextChanged(object sender, EventArgs e)
        {
        }

        private void minMaxBtn_Click(object sender, EventArgs e)
        {
            decimal min = Convert.ToDecimal(minTextBox.Text);
            decimal max = Convert.ToDecimal(maxTextBox.Text);

            this.playersBindingSource.DataSource =
            from player in this.baseballDataSet.Players
            where player.BattingAverage >= min
            && player.BattingAverage <= max
            orderby player.PlayerID
            select player;
        }
    }
}