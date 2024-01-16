using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Windows.Forms;

namespace captcha
{
    public partial class Registration : MaterialForm
    {
        private NpgsqlConnection connection;
        private string connectionString;
        private UserProvider usersProvider;
        public Registration()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=5432;Database=Users;User Id=postgres;Password=0987";
            connection = new NpgsqlConnection(connectionString);
            usersProvider = new UserProvider(connection);
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            if (string.Empty != LoginTxt.Text && string.Empty != PasswordTxt.Text)
            {
                if (usersProvider.addUser(LoginTxt.Text, PasswordTxt.Text))
                {
                    goToAuth();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.");
                }
            } else
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToAuth();
        }

        private void goToAuth()
        {
            Hide();
            Auth auth = new Auth();
            auth.FormClosed += (s, args) => Close();
            auth.Show();
        }
    }
}
