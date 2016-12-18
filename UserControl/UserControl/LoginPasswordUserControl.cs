using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }
        public string Login
        {
            get
            {
                return loginTextBox.Text;
            }
        }
        public string Password
        {
            get
            {
                return passwordTextBox.Text;
            }
        }
    }
}
