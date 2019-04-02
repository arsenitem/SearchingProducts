﻿namespace RoutesGMAP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.navPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.routeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.shopsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.myListButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.profileButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UserLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.workingAreaPanel = new System.Windows.Forms.Panel();
            this.myList1 = new RoutesGMAP.myList();
            this.search1 = new RoutesGMAP.Search();
            this.shopsUserControl1 = new RoutesGMAP.ShopsUserControl();
            this.userProfileControl1 = new RoutesGMAP.UserProfileControl();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.newRouteControl1 = new RoutesGMAP.newRouteControl();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.workingAreaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.navPanel.Controls.Add(this.logoutButton);
            this.navPanel.Controls.Add(this.bunifuImageButton3);
            this.navPanel.Controls.Add(this.routeButton);
            this.navPanel.Controls.Add(this.shopsButton);
            this.navPanel.Controls.Add(this.myListButton);
            this.navPanel.Controls.Add(this.searchButton);
            this.navPanel.Controls.Add(this.profileButton);
            this.navPanel.Controls.Add(this.UserLabel);
            this.navPanel.Location = new System.Drawing.Point(0, 43);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(215, 544);
            this.navPanel.TabIndex = 6;
            // 
            // userProfileControl1
            // 
            this.userProfileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.userProfileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfileControl1.Location = new System.Drawing.Point(0, 0);
            this.userProfileControl1.Name = "userProfileControl1";
            this.userProfileControl1.Size = new System.Drawing.Size(682, 545);
            this.userProfileControl1.TabIndex = 4;
            // 
            // shopsUserControl1
            // 
            this.shopsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.shopsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.shopsUserControl1.Name = "shopsUserControl1";
            this.shopsUserControl1.Size = new System.Drawing.Size(682, 545);
            this.shopsUserControl1.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.ButtonText = " Выход";
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutButton.Iconimage")));
            this.logoutButton.Iconimage_right = null;
            this.logoutButton.Iconimage_right_Selected = null;
            this.logoutButton.Iconimage_Selected = null;
            this.logoutButton.IconMarginLeft = 0;
            this.logoutButton.IconMarginRight = 0;
            this.logoutButton.IconRightVisible = true;
            this.logoutButton.IconRightZoom = 0D;
            this.logoutButton.IconVisible = true;
            this.logoutButton.IconZoom = 70D;
            this.logoutButton.IsTab = false;
            this.logoutButton.Location = new System.Drawing.Point(0, 390);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.logoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(216, 53);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = " Выход";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Textcolor = System.Drawing.Color.Gray;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(175, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(38, 41);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 8;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // routeButton
            // 
            this.routeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.routeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.routeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.routeButton.BorderRadius = 0;
            this.routeButton.ButtonText = " Маршрут";
            this.routeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.routeButton.DisabledColor = System.Drawing.Color.Gray;
            this.routeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.routeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.routeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("routeButton.Iconimage")));
            this.routeButton.Iconimage_right = null;
            this.routeButton.Iconimage_right_Selected = null;
            this.routeButton.Iconimage_Selected = null;
            this.routeButton.IconMarginLeft = 0;
            this.routeButton.IconMarginRight = 0;
            this.routeButton.IconRightVisible = true;
            this.routeButton.IconRightZoom = 0D;
            this.routeButton.IconVisible = true;
            this.routeButton.IconZoom = 70D;
            this.routeButton.IsTab = false;
            this.routeButton.Location = new System.Drawing.Point(1, 335);
            this.routeButton.Margin = new System.Windows.Forms.Padding(6);
            this.routeButton.Name = "routeButton";
            this.routeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.routeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.routeButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.routeButton.selected = false;
            this.routeButton.Size = new System.Drawing.Size(216, 53);
            this.routeButton.TabIndex = 7;
            this.routeButton.Text = " Маршрут";
            this.routeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.routeButton.Textcolor = System.Drawing.Color.Gray;
            this.routeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // shopsButton
            // 
            this.shopsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.shopsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.shopsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shopsButton.BorderRadius = 0;
            this.shopsButton.ButtonText = " Магазины";
            this.shopsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopsButton.DisabledColor = System.Drawing.Color.Gray;
            this.shopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shopsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.shopsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("shopsButton.Iconimage")));
            this.shopsButton.Iconimage_right = null;
            this.shopsButton.Iconimage_right_Selected = null;
            this.shopsButton.Iconimage_Selected = null;
            this.shopsButton.IconMarginLeft = 0;
            this.shopsButton.IconMarginRight = 0;
            this.shopsButton.IconRightVisible = true;
            this.shopsButton.IconRightZoom = 0D;
            this.shopsButton.IconVisible = true;
            this.shopsButton.IconZoom = 70D;
            this.shopsButton.IsTab = false;
            this.shopsButton.Location = new System.Drawing.Point(0, 282);
            this.shopsButton.Margin = new System.Windows.Forms.Padding(6);
            this.shopsButton.Name = "shopsButton";
            this.shopsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.shopsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.shopsButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.shopsButton.selected = false;
            this.shopsButton.Size = new System.Drawing.Size(216, 53);
            this.shopsButton.TabIndex = 6;
            this.shopsButton.Text = " Магазины";
            this.shopsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopsButton.Textcolor = System.Drawing.Color.Gray;
            this.shopsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopsButton.Click += new System.EventHandler(this.shopsButton_Click);
            // 
            // myListButton
            // 
            this.myListButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.myListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.myListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myListButton.BorderRadius = 0;
            this.myListButton.ButtonText = " Мой список";
            this.myListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myListButton.DisabledColor = System.Drawing.Color.Gray;
            this.myListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myListButton.Iconcolor = System.Drawing.Color.Transparent;
            this.myListButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("myListButton.Iconimage")));
            this.myListButton.Iconimage_right = null;
            this.myListButton.Iconimage_right_Selected = null;
            this.myListButton.Iconimage_Selected = null;
            this.myListButton.IconMarginLeft = 0;
            this.myListButton.IconMarginRight = 0;
            this.myListButton.IconRightVisible = true;
            this.myListButton.IconRightZoom = 0D;
            this.myListButton.IconVisible = true;
            this.myListButton.IconZoom = 70D;
            this.myListButton.IsTab = false;
            this.myListButton.Location = new System.Drawing.Point(1, 229);
            this.myListButton.Margin = new System.Windows.Forms.Padding(6);
            this.myListButton.Name = "myListButton";
            this.myListButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.myListButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.myListButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.myListButton.selected = false;
            this.myListButton.Size = new System.Drawing.Size(216, 53);
            this.myListButton.TabIndex = 4;
            this.myListButton.Text = " Мой список";
            this.myListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myListButton.Textcolor = System.Drawing.Color.Gray;
            this.myListButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myListButton.Click += new System.EventHandler(this.myListButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.BorderRadius = 0;
            this.searchButton.ButtonText = " Поиск товаров";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledColor = System.Drawing.Color.Gray;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.searchButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchButton.Iconimage")));
            this.searchButton.Iconimage_right = null;
            this.searchButton.Iconimage_right_Selected = null;
            this.searchButton.Iconimage_Selected = null;
            this.searchButton.IconMarginLeft = 0;
            this.searchButton.IconMarginRight = 0;
            this.searchButton.IconRightVisible = true;
            this.searchButton.IconRightZoom = 0D;
            this.searchButton.IconVisible = true;
            this.searchButton.IconZoom = 70D;
            this.searchButton.IsTab = false;
            this.searchButton.Location = new System.Drawing.Point(1, 172);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.searchButton.selected = false;
            this.searchButton.Size = new System.Drawing.Size(216, 53);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = " Поиск товаров";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Textcolor = System.Drawing.Color.Gray;
            this.searchButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileButton.BorderRadius = 0;
            this.profileButton.ButtonText = " Профиль";
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.DisabledColor = System.Drawing.Color.Gray;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileButton.Iconcolor = System.Drawing.Color.Transparent;
            this.profileButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("profileButton.Iconimage")));
            this.profileButton.Iconimage_right = null;
            this.profileButton.Iconimage_right_Selected = null;
            this.profileButton.Iconimage_Selected = null;
            this.profileButton.IconMarginLeft = 0;
            this.profileButton.IconMarginRight = 0;
            this.profileButton.IconRightVisible = true;
            this.profileButton.IconRightZoom = 0D;
            this.profileButton.IconVisible = true;
            this.profileButton.IconZoom = 70D;
            this.profileButton.IsTab = false;
            this.profileButton.Location = new System.Drawing.Point(1, 117);
            this.profileButton.Margin = new System.Windows.Forms.Padding(6);
            this.profileButton.Name = "profileButton";
            this.profileButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.profileButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.profileButton.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.profileButton.selected = false;
            this.profileButton.Size = new System.Drawing.Size(216, 53);
            this.profileButton.TabIndex = 2;
            this.profileButton.Text = " Профиль";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Textcolor = System.Drawing.Color.Gray;
            this.profileButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.ForeColor = System.Drawing.Color.Gray;
            this.UserLabel.Location = new System.Drawing.Point(50, 70);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(107, 25);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "username";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logoPanel.Controls.Add(this.bunifuImageButton2);
            this.logoPanel.Controls.Add(this.bunifuImageButton1);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.bunifuCustomLabel2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(890, 50);
            this.logoPanel.TabIndex = 8;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(801, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(43, 50);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(844, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.ForestGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(38, 2);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(206, 38);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Поиск продуктов";
            // 
            // workingAreaPanel
            // 
            this.workingAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.workingAreaPanel.Controls.Add(this.newRouteControl1);
            this.workingAreaPanel.Controls.Add(this.myList1);
            this.workingAreaPanel.Controls.Add(this.search1);
            this.workingAreaPanel.Controls.Add(this.userProfileControl1);
            this.workingAreaPanel.Controls.Add(this.shopsUserControl1);
            this.workingAreaPanel.Location = new System.Drawing.Point(214, 42);
            this.workingAreaPanel.Name = "workingAreaPanel";
            this.workingAreaPanel.Size = new System.Drawing.Size(682, 545);
            this.workingAreaPanel.TabIndex = 9;
            // 
            // myList1
            // 
            this.myList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.myList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myList1.Location = new System.Drawing.Point(0, 0);
            this.myList1.Name = "myList1";
            this.myList1.Size = new System.Drawing.Size(682, 545);
            this.myList1.TabIndex = 2;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search1.Location = new System.Drawing.Point(0, 0);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(682, 545);
            this.search1.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.logoPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // newRouteControl1
            // 
            this.newRouteControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.newRouteControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRouteControl1.Location = new System.Drawing.Point(0, 0);
            this.newRouteControl1.Name = "newRouteControl1";
            this.newRouteControl1.Size = new System.Drawing.Size(682, 545);
            this.newRouteControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 587);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.workingAreaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.workingAreaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel workingAreaPanel;
        private System.Windows.Forms.Panel logoPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel navPanel;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuFlatButton routeButton;
        private Bunifu.Framework.UI.BunifuFlatButton shopsButton;
        private Bunifu.Framework.UI.BunifuFlatButton myListButton;
        private Bunifu.Framework.UI.BunifuFlatButton searchButton;
        private Bunifu.Framework.UI.BunifuFlatButton profileButton;
        private Bunifu.Framework.UI.BunifuCustomLabel UserLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private ShopsUserControl shopsUserControl1;
        private myList myList1;
        private Search search1;
        private UserProfileControl userProfileControl1;
        private newRouteControl newRouteControl1;
    }
}