namespace iCantina.views
{
    partial class ManagerClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerClient));
            this.labelId = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNif = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNif = new System.Windows.Forms.Label();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.checkBoxTeacher = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTeacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxPhotoClient = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.labelmultiescolha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoClient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(313, 47);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 16);
            this.labelId.TabIndex = 34;
            this.labelId.Text = "Nº :";
            this.labelId.Visible = false;
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(614, 49);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(350, 564);
            this.listBoxClient.TabIndex = 20;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(316, 126);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(275, 26);
            this.textBoxName.TabIndex = 37;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(312, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Nome";
            // 
            // textBoxNif
            // 
            this.textBoxNif.BorderRadius = 10;
            this.textBoxNif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNif.DefaultText = "";
            this.textBoxNif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNif.Location = new System.Drawing.Point(316, 226);
            this.textBoxNif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.PasswordChar = '\0';
            this.textBoxNif.PlaceholderText = "";
            this.textBoxNif.SelectedText = "";
            this.textBoxNif.Size = new System.Drawing.Size(275, 26);
            this.textBoxNif.TabIndex = 39;
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNif.Location = new System.Drawing.Point(312, 192);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(30, 20);
            this.labelNif.TabIndex = 38;
            this.labelNif.Text = "Nif";
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.AutoSize = true;
            this.checkBoxStudent.Location = new System.Drawing.Point(397, 353);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Size = new System.Drawing.Size(63, 20);
            this.checkBoxStudent.TabIndex = 41;
            this.checkBoxStudent.Text = "Aluno";
            this.checkBoxStudent.UseVisualStyleBackColor = true;
            this.checkBoxStudent.CheckedChanged += new System.EventHandler(this.checkBoxStudent_CheckedChanged);
            // 
            // checkBoxTeacher
            // 
            this.checkBoxTeacher.AutoSize = true;
            this.checkBoxTeacher.Location = new System.Drawing.Point(126, 353);
            this.checkBoxTeacher.Name = "checkBoxTeacher";
            this.checkBoxTeacher.Size = new System.Drawing.Size(87, 20);
            this.checkBoxTeacher.TabIndex = 40;
            this.checkBoxTeacher.Text = "Professor";
            this.checkBoxTeacher.UseVisualStyleBackColor = true;
            this.checkBoxTeacher.CheckedChanged += new System.EventHandler(this.checkBoxTeacher_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Numero do Cliente";
            this.label1.Visible = false;
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.BorderRadius = 10;
            this.textBoxTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTeacher.DefaultText = "";
            this.textBoxTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Location = new System.Drawing.Point(54, 467);
            this.textBoxTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.PasswordChar = '\0';
            this.textBoxTeacher.PlaceholderText = "";
            this.textBoxTeacher.SelectedText = "";
            this.textBoxTeacher.Size = new System.Drawing.Size(506, 26);
            this.textBoxTeacher.TabIndex = 44;
            this.textBoxTeacher.Visible = false;
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.BorderRadius = 10;
            this.textBoxStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStudent.DefaultText = "";
            this.textBoxStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Location = new System.Drawing.Point(54, 467);
            this.textBoxStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.PasswordChar = '\0';
            this.textBoxStudent.PlaceholderText = "";
            this.textBoxStudent.SelectedText = "";
            this.textBoxStudent.Size = new System.Drawing.Size(537, 26);
            this.textBoxStudent.TabIndex = 45;
            this.textBoxStudent.Visible = false;
            // 
            // pictureBoxPhotoClient
            // 
            this.pictureBoxPhotoClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhotoClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhotoClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhotoClient.Image")));
            this.pictureBoxPhotoClient.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.pictureBoxPhotoClient.ImageRotate = 0F;
            this.pictureBoxPhotoClient.Location = new System.Drawing.Point(54, 49);
            this.pictureBoxPhotoClient.Name = "pictureBoxPhotoClient";
            this.pictureBoxPhotoClient.Size = new System.Drawing.Size(237, 252);
            this.pictureBoxPhotoClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoClient.TabIndex = 46;
            this.pictureBoxPhotoClient.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoRoundedCorners = true;
            this.buttonCreate.BorderRadius = 19;
            this.buttonCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCreate.FillColor = System.Drawing.Color.Peru;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(54, 573);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 40);
            this.buttonCreate.TabIndex = 47;
            this.buttonCreate.Text = "Criar";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoRoundedCorners = true;
            this.buttonSearch.BorderRadius = 19;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.Peru;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(199, 573);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 40);
            this.buttonSearch.TabIndex = 48;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BorderRadius = 19;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.Peru;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(344, 573);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 40);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoRoundedCorners = true;
            this.buttonDelete.BorderRadius = 19;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.Peru;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(489, 573);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 50;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelmultiescolha
            // 
            this.labelmultiescolha.AutoSize = true;
            this.labelmultiescolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmultiescolha.Location = new System.Drawing.Point(50, 433);
            this.labelmultiescolha.Name = "labelmultiescolha";
            this.labelmultiescolha.Size = new System.Drawing.Size(73, 20);
            this.labelmultiescolha.TabIndex = 51;
            this.labelmultiescolha.Text = "Exemplo";
            this.labelmultiescolha.Visible = false;
            // 
            // ManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 690);
            this.Controls.Add(this.labelmultiescolha);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxPhotoClient);
            this.Controls.Add(this.textBoxStudent);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxStudent);
            this.Controls.Add(this.checkBoxTeacher);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.labelNif);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBoxClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListBox listBoxClient;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNif;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.CheckBox checkBoxTeacher;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTeacher;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStudent;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPhotoClient;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private System.Windows.Forms.Label labelmultiescolha;
    }
}