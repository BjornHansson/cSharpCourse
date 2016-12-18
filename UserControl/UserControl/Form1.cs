using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginPassword
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            // login and password must be entered before
            // any information is displayed
            if ( myLogin.Login != "" && myLogin.Password != "" )
            {
                displayLabel.Text = "The information entered is:";
                loginLabel.Text =
                "Login: " + myLogin.Login;
                passwordLabel.Text =
                "Password: " + myLogin.Password;
            } // end if
            else
                displayLabel.Text = "Enter information above";
        }
    }
}
