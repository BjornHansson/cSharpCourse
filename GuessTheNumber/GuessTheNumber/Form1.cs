using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int nr = 0;
        private int lastGuess = 0;

        public Form1()
        {
            InitializeComponent();
            
            this.nr = random.Next(1, 1001);
            this.AcceptButton = enterBtn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt16(textBox1.Text);

            if (guess < nr)
            {
                answer.Text = "Too Low";

                if (lastGuess != 0)
                {
                    if (guess < lastGuess)
                    {
                        this.BackColor = System.Drawing.Color.Blue;
                    }
                    else if (guess > lastGuess)
                    {
                        this.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
            else if (guess > nr)
            {
                answer.Text = "Too High";
                if (lastGuess != 0)
                {
                    if (guess > lastGuess)
                    {
                        this.BackColor = System.Drawing.Color.Blue;
                    }
                    else if (guess < lastGuess)
                    {
                        this.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
            else
            {
                answer.Text = "Correct";
                this.BackColor = System.Drawing.Color.Green;
                textBox1.Enabled = false;
                newGame.Enabled = true;
            }

            lastGuess = guess;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            newGame.Enabled = false;
            lastGuess = 0;
            nr = random.Next(1, 1001);
            this.BackColor = System.Drawing.Color.Gray;
        }
    }
}
