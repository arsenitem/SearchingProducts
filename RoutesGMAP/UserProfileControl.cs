using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RoutesGMAP
{
    public partial class UserProfileControl : UserControl
    {
        public UserProfileControl()
        {
            InitializeComponent();
            #region Выгрузка данных о пользователе
            pictureBox1.Image = CUser.UserPhoto;
            nameTextBox.Text = CUser.UserName;
            string[] rdate = CUser.RegDate.Split(' ');
            RegDateTextBox.Text = "Зарегестрирован " + rdate[0];
            SecondNameTextBox.Text = CUser.UserSName;
            CityTextBox.Text = CUser.City;
            #endregion
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Thread ap = new Thread(new ParameterizedThreadStart(AddPhoto));
                ap.Start(ofd);
            }
        }
        private void AddPhoto(object ofds)
        {
            OpenFileDialog ofd = (OpenFileDialog)ofds;
            try
            {
                #region Добавить в базу фото
                using (SearchProductsEntities db = new SearchProductsEntities())
                {
                    Users user = db.Users.Where(x => x.UserLogin == CUser.CurrentUser).FirstOrDefault();
                    user.UserPhoto = ImageConvertion.ConvertToByteArray(Image.FromFile(ofd.FileName));
                    db.SaveChanges();
                      pictureBox1.Image = ImageConvertion.RetriveImage(user.UserPhoto);
                }
                #endregion
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!settingsPanel.Visible)
            {
                settingsPanel.Visible = true;
                HidePanels();
                GeneralInfoPanel.Visible = true;
            }
            else
            {
                settingsPanel.Visible = false;
            }
        }
        private void HidePanels()
        {
            changePassPanel.Visible = false;
            GeneralInfoPanel.Visible = false;
            changeEmailPanel.Visible = false;
        }

        private void GeneralInfo_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(3, 31);
            panel1.Width = 217;
            HidePanels();
            GeneralInfoPanel.Visible = true;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(226, 31);
            panel1.Width = 169;
            HidePanels();
            changePassPanel.Visible = true;
        }

        private void changeEmail_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(397, 31);
            panel1.Width = 150;
            HidePanels();
            changeEmailPanel.Visible = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            oldEmailTextbox.LineIdleColor = Color.Gray;
            newEmailTextBox.LineIdleColor = Color.Gray;
            if (String.IsNullOrEmpty(oldEmailTextbox.Text))
            {
                oldEmailTextbox.LineIdleColor = Color.Red;
                return;
            }
            if (String.IsNullOrEmpty(newEmailTextBox.Text))
            {
                newEmailTextBox.LineIdleColor = Color.Red;
                return;
            }
            #region Изменить емейл
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                Users user = db.Users.Where(x => x.UserLogin == CUser.CurrentUser).FirstOrDefault();
                if (user.UserEmail == oldEmailTextbox.Text)
                {
                    oldEmailTextbox.LineIdleColor = Color.Red;
                    return;
                }
                else
                {
                    user.UserEmail = newEmailTextBox.Text;
                    db.SaveChanges();
                    label3.Visible = true;
                }
            }
            #endregion
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            oldPsswordTextBox.BorderColorIdle = Color.Gray;
            newPasswordTextBox.BorderColorIdle = Color.Gray;
            confirmNewPasswordTextBox.BorderColorIdle = Color.Gray;
            if (String.IsNullOrEmpty(oldPsswordTextBox.Text))
            {
                oldPsswordTextBox.BorderColorIdle = Color.Red;
                return;
            }
            if (String.IsNullOrEmpty(newPasswordTextBox.Text))
            {
                newPasswordTextBox.BorderColorIdle = Color.Red;
                return;
            }
            #region Изменить пароль
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                Users user = db.Users.Where(x => x.UserLogin == CUser.CurrentUser).FirstOrDefault();
                if (String.Compare(user.UserPassword, Crypto.Hash(oldPsswordTextBox.Text)) == 0)
                {
                    if (newPasswordTextBox.Text.Length < 6)
                    {
                        newPasswordTextBox.BorderColorIdle = Color.Red;
                        return;
                    }
                    if (confirmNewPasswordTextBox.Text != newPasswordTextBox.Text)
                    {
                        confirmNewPasswordTextBox.BorderColorIdle = Color.Red;
                        return;
                    }
                    else
                    {
                        user.UserPassword = Crypto.Hash(newPasswordTextBox.Text);
                        db.SaveChanges();
                        label2.Visible = true;
                    }
                }
                else
                {
                    oldPsswordTextBox.BorderColorIdle = Color.Red;
                }
            }
            #endregion
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(changedNameTextbox.Text))
            {
                changedNameTextbox.LineIdleColor = Color.Red;
                return;
            }
            #region Изменить информацию
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                Users user = db.Users.Where(x => x.UserLogin == CUser.CurrentUser).FirstOrDefault();
                user.UserName = changedNameTextbox.Text;
                user.UserSecondName = changedSNameTextbox.Text;
                user.UserCity = ChangedCityTextBox.Text;
                db.SaveChanges();
                label1.Visible = true;
                nameTextBox.Text = user.UserName;
                SecondNameTextBox.Text = user.UserSecondName;
                CityTextBox.Text = user.UserCity;
            }
            #endregion
        }
    }
}
