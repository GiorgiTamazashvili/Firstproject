
using System.Data;
using System.Data.SqlClient;

namespace DailyDutyV2
{

    public partial class RegistrationForm : Form
    {

       
        DateBase dateBase = new DateBase();
        public RegistrationForm()
        {
            InitializeComponent();
            this.PasswordField.Text = "პაროლი";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.FromArgb(24, 104, 196);
        }


        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            this.CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            this.CloseLabel.ForeColor = Color.Black;
        }

        Point mouseLeftButtonDown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLeftButtonDown = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - mouseLeftButtonDown.X;
                this.Top+=e.Y - mouseLeftButtonDown.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLeftButtonDown=new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - mouseLeftButtonDown.X;
                this.Top+= e.Y - mouseLeftButtonDown.Y;

            }
        }

        private void authorizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
        }

        private void Registrationbutton_Click(object sender, EventArgs e)
        {

            if (CheckUser())
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Users] (Name,LastName,Login,Password) VALUES (@Name,@LastName,@Login,@Password) ", dateBase.GetConnection());

                sqlCommand.Parameters.AddWithValue("name", NameField.Text);
                sqlCommand.Parameters.AddWithValue("LastName", LastNameField.Text);
                sqlCommand.Parameters.AddWithValue("Login", LoginField.Text);
                sqlCommand.Parameters.AddWithValue("Password", PasswordField.Text);

                dateBase.OpenConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("რეგისტრაცია წარამტეთ დასრულებულია", "მომხმარებელი დარეგისტრირდა!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("ATention! წარუმატებელი რეგისტრაცია!!");
                }


                dateBase.CloseConnection();
            }
            else
            {
                MessageBox.Show("ასეთი მომხმარებელი უკვე არსებობს! ", "გთხოვთ სცადოთ სხვა ლოგინი! ", MessageBoxButtons.OK);
            }


         

        }

        private bool CheckUser() 
        {


            string login = LoginField.Text;
            string password = PasswordField.Text;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string queryString = $"select ID,Login From Users Where Login= '{login}'";
            SqlCommand command = new SqlCommand(queryString, dateBase.GetConnection());



            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count >0)
            {

                return false;
            }
            else
            {
                return true;
            }



        }
    }
}