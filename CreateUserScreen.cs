using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketDesktop
{
    public partial class CreateUserScreen : Form
    {
        bool isLoading = false;
        public CreateUserScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isLoading = true;
            if (txtUsername.Text.Length > 2)
            {
                MessageBox.Show("Valid");
            }
            if (maskedPassword.Text == maskedConfPass.Text)
            {
                MessageBox.Show("Valid");
            }
        }

        private void cbxUserRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CreateUserScreen_Load(object sender, EventArgs e)
        {
           
        }
    }
}
