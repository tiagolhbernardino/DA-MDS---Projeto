namespace iCantina.views
{
    partial class FormReservations
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTeacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBoxDishes = new System.Windows.Forms.ListBox();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSeacher = new Guna.UI2.WinForms.Guna2Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(582, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(443, 690);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.monthCalendar1);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.textBoxTeacher);
            this.guna2Panel2.Controls.Add(this.textBoxStudent);
            this.guna2Panel2.Controls.Add(this.listBox2);
            this.guna2Panel2.Controls.Add(this.listBoxDishes);
            this.guna2Panel2.Controls.Add(this.buttonCreate);
            this.guna2Panel2.Controls.Add(this.buttonEdit);
            this.guna2Panel2.Controls.Add(this.buttonDelete);
            this.guna2Panel2.Controls.Add(this.buttonSeacher);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(582, 690);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Estudante:";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.AutoRoundedCorners = true;
            this.textBoxTeacher.BorderRadius = 16;
            this.textBoxTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTeacher.DefaultText = "";
            this.textBoxTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Location = new System.Drawing.Point(397, 82);
            this.textBoxTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.PasswordChar = '\0';
            this.textBoxTeacher.PlaceholderText = "";
            this.textBoxTeacher.SelectedText = "";
            this.textBoxTeacher.Size = new System.Drawing.Size(159, 35);
            this.textBoxTeacher.TabIndex = 36;
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.AutoRoundedCorners = true;
            this.textBoxStudent.BorderRadius = 16;
            this.textBoxStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStudent.DefaultText = "";
            this.textBoxStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Location = new System.Drawing.Point(397, 23);
            this.textBoxStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.PasswordChar = '\0';
            this.textBoxStudent.PlaceholderText = "";
            this.textBoxStudent.SelectedText = "";
            this.textBoxStudent.Size = new System.Drawing.Size(159, 35);
            this.textBoxStudent.TabIndex = 35;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(326, 155);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 388);
            this.listBox2.TabIndex = 34;
            // 
            // listBoxDishes
            // 
            this.listBoxDishes.FormattingEnabled = true;
            this.listBoxDishes.ItemHeight = 16;
            this.listBoxDishes.Location = new System.Drawing.Point(12, 251);
            this.listBoxDishes.Name = "listBoxDishes";
            this.listBoxDishes.Size = new System.Drawing.Size(285, 292);
            this.listBoxDishes.TabIndex = 33;
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
            this.buttonCreate.Location = new System.Drawing.Point(160, 620);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 40);
            this.buttonCreate.TabIndex = 31;
            this.buttonCreate.Text = "Criar";
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
            this.buttonEdit.Location = new System.Drawing.Point(308, 620);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 40);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Editar";
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
            this.buttonDelete.Location = new System.Drawing.Point(456, 620);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Eliminar";
            // 
            // buttonSeacher
            // 
            this.buttonSeacher.AutoRoundedCorners = true;
            this.buttonSeacher.BorderRadius = 19;
            this.buttonSeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSeacher.FillColor = System.Drawing.Color.Peru;
            this.buttonSeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSeacher.ForeColor = System.Drawing.Color.White;
            this.buttonSeacher.Location = new System.Drawing.Point(12, 620);
            this.buttonSeacher.Name = "buttonSeacher";
            this.buttonSeacher.Size = new System.Drawing.Size(100, 40);
            this.buttonSeacher.TabIndex = 30;
            this.buttonSeacher.Text = "Procurar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 39;
            // 
            // FormReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 690);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservations";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBoxDishes;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonSeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTeacher;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStudent;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}