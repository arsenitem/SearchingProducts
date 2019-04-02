namespace RoutesGMAP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.rightsErrorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.wrongLoginLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.wrongPassLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.authButtom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.isAdmin = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PasswordTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LoginTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rightsErrorLabel
            // 
            this.rightsErrorLabel.AutoSize = true;
            this.rightsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightsErrorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.rightsErrorLabel.Location = new System.Drawing.Point(32, 280);
            this.rightsErrorLabel.Name = "rightsErrorLabel";
            this.rightsErrorLabel.Size = new System.Drawing.Size(188, 18);
            this.rightsErrorLabel.TabIndex = 45;
            this.rightsErrorLabel.Text = "У вас не достаточно прав";
            this.rightsErrorLabel.Visible = false;
            // 
            // wrongLoginLabel
            // 
            this.wrongLoginLabel.AutoSize = true;
            this.wrongLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongLoginLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongLoginLabel.Location = new System.Drawing.Point(153, 149);
            this.wrongLoginLabel.Name = "wrongLoginLabel";
            this.wrongLoginLabel.Size = new System.Drawing.Size(135, 18);
            this.wrongLoginLabel.TabIndex = 44;
            this.wrongLoginLabel.Text = "Неверный пароль!";
            this.wrongLoginLabel.Visible = false;
            // 
            // wrongPassLabel
            // 
            this.wrongPassLabel.AutoSize = true;
            this.wrongPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongPassLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongPassLabel.Location = new System.Drawing.Point(153, 216);
            this.wrongPassLabel.Name = "wrongPassLabel";
            this.wrongPassLabel.Size = new System.Drawing.Size(135, 18);
            this.wrongPassLabel.TabIndex = 43;
            this.wrongPassLabel.Text = "Неверный пароль!";
            this.wrongPassLabel.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Зарегистрироваться";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(6, 303);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 42;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // authButtom
            // 
            this.authButtom.ActiveBorderThickness = 1;
            this.authButtom.ActiveCornerRadius = 20;
            this.authButtom.ActiveFillColor = System.Drawing.Color.Transparent;
            this.authButtom.ActiveForecolor = System.Drawing.Color.ForestGreen;
            this.authButtom.ActiveLineColor = System.Drawing.Color.ForestGreen;
            this.authButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.authButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("authButtom.BackgroundImage")));
            this.authButtom.ButtonText = "Войти";
            this.authButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authButtom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authButtom.ForeColor = System.Drawing.Color.Gray;
            this.authButtom.IdleBorderThickness = 1;
            this.authButtom.IdleCornerRadius = 20;
            this.authButtom.IdleFillColor = System.Drawing.Color.Transparent;
            this.authButtom.IdleForecolor = System.Drawing.Color.Gray;
            this.authButtom.IdleLineColor = System.Drawing.Color.Gray;
            this.authButtom.Location = new System.Drawing.Point(206, 303);
            this.authButtom.Margin = new System.Windows.Forms.Padding(5);
            this.authButtom.Name = "authButtom";
            this.authButtom.Size = new System.Drawing.Size(181, 41);
            this.authButtom.TabIndex = 41;
            this.authButtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authButtom.Click += new System.EventHandler(this.authButtom_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(30, 249);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(258, 25);
            this.bunifuCustomLabel4.TabIndex = 40;
            this.bunifuCustomLabel4.Text = "Войти как администратор";
            // 
            // isAdmin
            // 
            this.isAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.isAdmin.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.isAdmin.Checked = false;
            this.isAdmin.CheckedOnColor = System.Drawing.Color.ForestGreen;
            this.isAdmin.ForeColor = System.Drawing.Color.White;
            this.isAdmin.Location = new System.Drawing.Point(366, 254);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(20, 20);
            this.isAdmin.TabIndex = 39;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(30, 182);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel3.TabIndex = 38;
            this.bunifuCustomLabel3.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderColorFocused = System.Drawing.Color.ForestGreen;
            this.PasswordTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.PasswordTextBox.BorderColorMouseHover = System.Drawing.Color.ForestGreen;
            this.PasswordTextBox.BorderThickness = 3;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.isPassword = true;
            this.PasswordTextBox.Location = new System.Drawing.Point(152, 172);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(234, 35);
            this.PasswordTextBox.TabIndex = 37;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderColorFocused = System.Drawing.Color.ForestGreen;
            this.LoginTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.LoginTextBox.BorderColorMouseHover = System.Drawing.Color.ForestGreen;
            this.LoginTextBox.BorderThickness = 3;
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.isPassword = false;
            this.LoginTextBox.Location = new System.Drawing.Point(153, 105);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(234, 35);
            this.LoginTextBox.TabIndex = 36;
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(323, -1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 33;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(357, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 32;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(30, 115);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Логин";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.ForestGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(-1, -1);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(206, 76);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Поиск\r\n         продуктов";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(398, 365);
            this.Controls.Add(this.rightsErrorLabel);
            this.Controls.Add(this.wrongLoginLabel);
            this.Controls.Add(this.wrongPassLabel);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.authButtom);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel rightsErrorLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel wrongLoginLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel wrongPassLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 authButtom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox isAdmin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox PasswordTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox LoginTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

