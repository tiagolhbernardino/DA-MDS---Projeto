namespace iCantina.views
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNif = new System.Windows.Forms.Label();
            this.textBoxNif = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBoxEmployers = new System.Windows.Forms.ListBox();
            this.pictureBoxPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Peru;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(199, 573);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 40);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Procurar";
            this.guna2Button1.Click += new System.EventHandler(this.ButtonShearch_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoRoundedCorners = true;
            this.ButtonDelete.BorderRadius = 19;
            this.ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDelete.FillColor = System.Drawing.Color.Peru;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(489, 573);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 40);
            this.ButtonDelete.TabIndex = 26;
            this.ButtonDelete.Text = "Eliminar";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 19;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Peru;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(344, 573);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(100, 40);
            this.guna2Button2.TabIndex = 28;
            this.guna2Button2.Text = "Editar";
            this.guna2Button2.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.AutoRoundedCorners = true;
            this.ButtonCreate.BorderRadius = 19;
            this.ButtonCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCreate.FillColor = System.Drawing.Color.Peru;
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(54, 573);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(100, 40);
            this.ButtonCreate.TabIndex = 27;
            this.ButtonCreate.Text = "Criar";
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(312, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoRoundedCorners = true;
            this.textBoxName.BorderRadius = 12;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(316, 126);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(273, 26);
            this.textBoxName.TabIndex = 33;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.textBoxName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseDown);
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNif.Location = new System.Drawing.Point(50, 386);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(30, 20);
            this.labelNif.TabIndex = 34;
            this.labelNif.Text = "Nif";
            // 
            // textBoxNif
            // 
            this.textBoxNif.AutoRoundedCorners = true;
            this.textBoxNif.BorderRadius = 12;
            this.textBoxNif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNif.DefaultText = "";
            this.textBoxNif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNif.ForeColor = System.Drawing.Color.Silver;
            this.textBoxNif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNif.Location = new System.Drawing.Point(54, 420);
            this.textBoxNif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.PasswordChar = '\0';
            this.textBoxNif.PlaceholderText = "";
            this.textBoxNif.SelectedText = "";
            this.textBoxNif.Size = new System.Drawing.Size(240, 26);
            this.textBoxNif.TabIndex = 35;
            this.textBoxNif.Leave += new System.EventHandler(this.textBoxNif_Leave);
            this.textBoxNif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxNif_MouseDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(480, 387);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 20);
            this.labelPassword.TabIndex = 36;
            this.labelPassword.Text = "Palavra-Pass";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AutoRoundedCorners = true;
            this.textBoxPassword.BorderRadius = 12;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(349, 420);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(240, 26);
            this.textBoxPassword.TabIndex = 37;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome de usuário";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AutoRoundedCorners = true;
            this.textBoxUsername.BorderRadius = 12;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Location = new System.Drawing.Point(316, 226);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(273, 26);
            this.textBoxUsername.TabIndex = 39;
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            this.textBoxUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseDown);
            // 
            // listBoxEmployers
            // 
            this.listBoxEmployers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEmployers.FormattingEnabled = true;
            this.listBoxEmployers.ItemHeight = 16;
            this.listBoxEmployers.Location = new System.Drawing.Point(614, 49);
            this.listBoxEmployers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEmployers.Name = "listBoxEmployers";
            this.listBoxEmployers.Size = new System.Drawing.Size(350, 564);
            this.listBoxEmployers.TabIndex = 35;
            this.listBoxEmployers.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployers_SelectedIndexChanged);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto.BorderRadius = 20;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.FillColor = System.Drawing.Color.Black;
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.ImageRotate = 0F;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(54, 49);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(237, 252);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 40;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxPhoto);
            this.panel1.Controls.Add(this.listBoxEmployers);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxNif);
            this.panel1.Controls.Add(this.labelNif);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.ButtonCreate);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 690);
            this.panel1.TabIndex = 36;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button ButtonCreate;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelNif;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNif;
        private System.Windows.Forms.Label labelPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private System.Windows.Forms.ListBox listBoxEmployers;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Panel panel1;
    }
}