using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SupermarketDesktop
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=supermarket_DB;");
            NpgsqlCommand command = new NpgsqlCommand();
            try
            {
                conn.Open();

                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText="select user_id, username, permission_id  from tbl_users";
                NpgsqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    
                    dataTable.Load(dataReader);
                    dgUsers.DataSource = dataTable;
                    dgUsers.DataSource = dataTable;

                    // Renomeia as colunas no DataGridView
                    dgUsers.Columns["user_id"].HeaderText = "User ID";
                    dgUsers.Columns["username"].HeaderText = "User Name"; 
                    dgUsers.Columns["permission_id"].HeaderText = "Permission Id";
                }


            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserScreen createUserScreen = new CreateUserScreen();
            createUserScreen.Show();
        }
    }
}
