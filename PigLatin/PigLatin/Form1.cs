using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // translate from English to Pig Latin
        private void translateButton_Click(object sender, EventArgs e)
        {
            // check for empty TextBox
            if (inputTextBox.Text == "")
            {
                return;
            } // end if

            string[] words = inputTextBox.Text.Split(' ');

            string pigLatin = "";

            // translate each word into pig latin
            foreach (string word in words)
            {
                pigLatin += GetPigLatin(word);
            }

            // display the translation
            outputTextBox.AppendText(pigLatin + "\r\n");
            inputTextBox.Clear();
        } // end method translateButton_Click

        // pressing enter is the same as clicking the Translate Button
        private void inputTextBox_KeyDown( object sender, KeyEventArgs e )
        {
            // allow user to press enter in TextBox
            if ( e.KeyCode == Keys.Enter )
                translateButton_Click( sender, e );
        } // end method inputTextBox_KeyDown

        // translate the word
        private string GetPigLatin( string word )
        {
            StringBuilder latin = new StringBuilder( word );
            char firstLetter = latin[ 0 ];

            // remove first letter and append it to the end
            latin.Remove(0, 1);
            latin.Append(firstLetter);

            // add "ay" to the end of word
            latin.Append("ay");

            return latin.ToString();
        }
    }
}
