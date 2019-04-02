using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesGMAP
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


      
        private bool EmailExists(string user_email)
        {
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var vc = db.Users.Where(x => x.UserEmail == user_email).FirstOrDefault();
                return vc != null ? false : true;
            }
        }
        private bool LoginExists(string user_login)
        {
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var vc = db.Users.Where(x => x.UserLogin == user_login).FirstOrDefault();
                return vc != null ? false : true;
            }
        }
        private void ClearErrors()
        {
            nameErrorLabel.Visible = false;
            loginErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            passwordMatchErrorLabel.Visible = false;
            nameErrorLabel.Text = "";
            loginErrorLabel.Text = "";
            emailErrorLabel.Text = "";
            passwordErrorLabel.Text = "";
            passwordMatchErrorLabel.Text = "";
        }

        private void authButtom_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ClearErrors();
            #region Проверка полей
            if (Password2TextBox.Text != PasswordTextBox.Text)
            {
                passwordMatchErrorLabel.Text = "Пароли должны совпадать";
                passwordErrorLabel.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                nameErrorLabel.Text = "Необходимо указать имя";
                nameErrorLabel.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                loginErrorLabel.Text = "Необходимо указать логин";
                loginErrorLabel.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                emailErrorLabel.Text = "Необходимо указать почту";
                emailErrorLabel.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                passwordErrorLabel.Text = "Необходимо указать пароль";
                passwordErrorLabel.Visible = true;
                return;
            }
            if (String.IsNullOrEmpty(Password2TextBox.Text))
            {
                passwordMatchErrorLabel.Text = "Необходимо указать пароль";
                passwordMatchErrorLabel.Visible = true;
                return;
            }
            if (!EmailExists(EmailTextBox.Text)) //Почта совпадает
            {
                emailErrorLabel.Text = "Указанный адресс уже используется";
                emailErrorLabel.Visible = true;
                return;
            }
            if (!LoginExists(LoginTextBox.Text)) //Логин совпадает
            {
                loginErrorLabel.Text = "Указанный логин уже используется";
                loginErrorLabel.Visible = true;
                return;
            }

            if (PasswordTextBox.Text.Length < 6)
            {
                passwordErrorLabel.Text = "Минимальная длина пароля 6 символов";
                passwordErrorLabel.Visible = true;
                return;
            }
            #endregion

            Users user = new Users();
            user.UserName = NameTextBox.Text;
            user.UserLogin = LoginTextBox.Text;
            user.UserEmail = EmailTextBox.Text;
            user.UserEmailConfirmed = false;
            user.UserAdminRights = false;
            user.UserCity = "Пермь";
            user.UserRegistrationDate = DateTime.Now.ToString();

            #region Хэширование пароля
            user.UserPassword = Crypto.Hash(PasswordTextBox.Text);
            #endregion

            #region Добавление в базу        
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            #endregion

            panel1.Visible = true;
        }
    }
}
