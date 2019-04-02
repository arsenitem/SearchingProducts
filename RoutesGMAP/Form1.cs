using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using RoutesGMAP;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace RoutesGMAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void authButtom_Click(object sender, EventArgs e)
        {
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var pass = db.Users.Where(x => x.UserLogin == LoginTextBox.Text).FirstOrDefault();
                if (pass != null)
                {
                    if (String.Compare(pass.UserPassword, Crypto.Hash(PasswordTextBox.Text)) == 0)
                    {
                        CUser.CurrentUser = LoginTextBox.Text;
                        CUser.UserPhoto = ImageConvertion.RetriveImage(pass.UserPhoto);
                        CUser.City = pass.UserCity;
                        CUser.UserName = pass.UserName;
                        CUser.UserSName = pass.UserSecondName;
                        CUser.RegDate = pass.UserRegistrationDate;
                        if (isAdmin.Checked)
                        {
                            if (pass.UserAdminRights)
                            {
                              
                               
                                CUser.CurrentUser = LoginTextBox.Text;
                                AdminForm1 af = new AdminForm1();
                                this.Hide();
                                af.Show();
                            }
                            else
                            {
                                rightsErrorLabel.Visible = true; //Сообщение об ошибке
                            }

                        }
                        else
                        {
                         
                          
                            CUser.CurrentUser = LoginTextBox.Text;
                            MainForm mf = new MainForm();
                            this.Hide();
                            mf.Show();
                        }

                    }
                    else
                    {
                        wrongPassLabel.Visible = true; //Сообщение об ошибке
                    }
                }
                else
                {
                    wrongLoginLabel.Visible = true; //Сообщение об ошибке
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            rightsErrorLabel.Visible = false;
            wrongLoginLabel.Visible = false;
            wrongPassLabel.Visible = false;
            RegForm rf = new RegForm();
            this.Hide();
            rf.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
