﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Electronic_store.Form1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Electronic_store;

namespace Аптека
{
    public partial class TextBoxUsername : Form
    {
        public object TextBoxUsername { get; private set; }

        public TextBoxUsername()
        {
            InitializeComponent();
        }
        public class UserManager
        {
            private string connectionString = "Data Source=DESKTOP-JC5A2Q8\\SQLEXPRESS;Initial Catalog= The_IP_of_the_electronic_store. ;Integrated Security=True";
            public bool AuthenticateUser(string username, string password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Log_and_pass_ WHERE Login  = @Login AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void button3_MouseCli(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            UserManager userManager = new UserManager();
            if (userManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вы успешно вошли в систему");
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!");
            }
        }

        private void extBoxUsername_Load(object sender, EventArgs e)
        {

        }
    }
}


