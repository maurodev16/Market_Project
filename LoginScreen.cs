using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "1")
            {
                MessageBox.Show("username is not correct");

            }
            else if (maskedPassword.Text !="1")
            {

                MessageBox.Show("Password is not correct");

            }
            else { 
             
               MainScreen form = new MainScreen();
               form.Show();
             
          
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

      
    }
}
