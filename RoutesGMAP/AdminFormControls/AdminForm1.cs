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
    public partial class AdminForm1 : Form
    {
        public AdminForm1()
        {
            InitializeComponent();
            userProfileControl1.Show();
            userProfileControl1.BringToFront();
            UserLabel.Text = CUser.CurrentUser;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            userProfileControl1.Show();
            userProfileControl1.BringToFront();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            shopsListAdmin1.Show();
            shopsListAdmin1.BringToFront();
        }
        private void HidePanels()
        {
            productsListAdmin1.Hide();
            shopsListAdmin1.Hide();
            userProfileControl1.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void myListButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            productsListAdmin1.Show();
            productsListAdmin1.BringToFront();
        }
    }
}
