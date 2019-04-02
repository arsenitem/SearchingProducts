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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HideAllPanels();
            userProfileControl1.Show();
            userProfileControl1.BringToFront();
            UserLabel.Text = CUser.CurrentUser;
        }

        private void HideAllPanels()
        {
            shopsUserControl1.Hide();
            userProfileControl1.Hide();
            search1.Hide();
            newRouteControl1.Hide();
        }
        private void shopsButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            shopsUserControl1.Show();
            shopsUserControl1.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            userProfileControl1.Show();
            userProfileControl1.BringToFront();
            userProfileControl1.Show();
            userProfileControl1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Закрыть
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (navPanel.Width == 50)
            {
                navPanel.Width = 215;
                workingAreaPanel.Location = new Point(215, 45);
                workingAreaPanel.Width -= 165;

            }
            else
            {
                navPanel.Width = 50;
                workingAreaPanel.Location = new Point(50, 45);
                workingAreaPanel.Width += 165;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            search1.Show();
            search1.BringToFront();
        }

        private void myListButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            myList1.Show();
            myList1.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            newRouteControl1.Show();
            newRouteControl1.BringToFront();
        }
    }
    public static class CUser
    {
        public static string UserName;
        public static string UserSName;
        public static string City;
        public static string RegDate;
        public static string CurrentUser;
        public static bool User_is_admin = false;
        public static Image UserPhoto;
    }
}
