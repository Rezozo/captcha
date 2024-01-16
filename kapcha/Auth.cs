using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Windows.Forms;

namespace kapcha
{
    public partial class Auth : MaterialForm
    {
        private NpgsqlConnection connection;
        private UserProvider userProvider;
        private string connectionString;
        private int loginAttempts = 0;

        public Auth()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=5432;Database=Users;User Id=postgres;Password=0987";
            connection = new NpgsqlConnection(connectionString);
            userProvider = new UserProvider(connection);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string login = LoginTxtB.Text;
            string password = PasswordTxtB.Text;
            if (!userProvider.isValidUser(login, password))
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    System.Threading.Thread.Sleep(20000);
                    Hide();
                    CaptchaForm captchaForm = new CaptchaForm();
                    captchaForm.FormClosed += (s, args) => Close();
                    captchaForm.Show();
                }
                else
                {
                    MessageBox.Show("Данные введены неверно!");
                }
            } else
            {
                Hide();
                CatForm cat = new CatForm();
                cat.FormClosed += (s, args) => Close();
                cat.LoginLabelText = login;
                cat.Show();
            }
        }

        private void registrBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registr = new Registration();
            registr.FormClosed += (s, args) => Close();
            registr.Show();
        }
    }
}
