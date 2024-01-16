using MaterialSkin.Controls;
using System;

namespace kapcha
{
    public partial class CatForm : MaterialForm
    {
        public CatForm()
        {
            InitializeComponent();
        }

        public string LoginLabelText
        {
            get { return LoginLabel.Text; }
            set { LoginLabel.Text = value; }
        }

        private void createNewForm(object sender, EventArgs e)
        {
            CatForm catForm = new CatForm();
            catForm.FormClosed += (s, args) => Close();
            catForm.LoginLabel.Text = LoginLabelText;
            catForm.Show();
        }
    }
}
