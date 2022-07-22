using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DailyDutyV2
{
    public partial class LoginForm : Form
    {
        DateBase dateBase = new DateBase();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            this.CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            this.CloseLabel.ForeColor = Color.Black;
        }

        private void newUserRegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string password = PasswordField.Text;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string queryString = $"select ID,Login,Password From Users Where Login= '{login}' and Password = '{password}'";
            SqlCommand command = new SqlCommand(queryString, dateBase.GetConnection());


          
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count==1)
            {
                this.Hide();
                MainForm mainForm = new MainForm();

                mainForm.Show();
            }
            else
            {
                MessageBox.Show("ასეთი მონაცემებით მოხმარებელი არ მოიძებნა!", "მომხმარებელი ვერ მოიძებნა" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
