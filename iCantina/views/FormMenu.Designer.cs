namespace iCantina.views
{
    partial class FormMenu
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
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxMenuType = new System.Windows.Forms.ListBox();
            this.monthCalendarDay = new System.Windows.Forms.MonthCalendar();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSeacher = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoRoundedCorners = true;
            this.buttonAdd.BorderRadius = 19;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Peru;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(569, 608);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 40);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Adicinar";
            // 
            // listBoxTime
            // 
            this.listBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.ItemHeight = 20;
            this.listBoxTime.Location = new System.Drawing.Point(59, 269);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(137, 284);
            this.listBoxTime.TabIndex = 33;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxTime_SelectedIndexChanged);
            // 
            // listBoxMenuType
            // 
            this.listBoxMenuType.FormattingEnabled = true;
            this.listBoxMenuType.ItemHeight = 16;
            this.listBoxMenuType.Location = new System.Drawing.Point(398, 31);
            this.listBoxMenuType.Name = "listBoxMenuType";
            this.listBoxMenuType.Size = new System.Drawing.Size(271, 532);
            this.listBoxMenuType.TabIndex = 34;
            // 
            // monthCalendarDay
            // 
            this.monthCalendarDay.Location = new System.Drawing.Point(59, 31);
            this.monthCalendarDay.Name = "monthCalendarDay";
            this.monthCalendarDay.TabIndex = 35;
            // 
            // listBoxType
            // 
            this.listBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 20;
            this.listBoxType.Location = new System.Drawing.Point(217, 269);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(139, 284);
            this.listBoxType.TabIndex = 36;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.listBoxType_SelectedIndexChanged);
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
            this.buttonDelete.Location = new System.Drawing.Point(398, 608);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Eliminar";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Location = new System.Drawing.Point(715, 31);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(271, 532);
            this.listBoxMenu.TabIndex = 38;
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
            this.buttonCreate.Location = new System.Drawing.Point(886, 608);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 40);
            this.buttonCreate.TabIndex = 39;
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
            this.buttonEdit.Location = new System.Drawing.Point(715, 608);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 40);
            this.buttonEdit.TabIndex = 40;
            this.buttonEdit.Text = "Editar";
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
            this.buttonSeacher.Location = new System.Drawing.Point(59, 608);
            this.buttonSeacher.Name = "buttonSeacher";
            this.buttonSeacher.Size = new System.Drawing.Size(100, 40);
            this.buttonSeacher.TabIndex = 41;
            this.buttonSeacher.Text = "Procurar";
            this.buttonSeacher.Click += new System.EventHandler(this.buttonSeacher_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 690);
            this.Controls.Add(this.buttonSeacher);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.monthCalendarDay);
            this.Controls.Add(this.listBoxMenuType);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxMenuType;
        private System.Windows.Forms.MonthCalendar monthCalendarDay;
        private System.Windows.Forms.ListBox listBoxType;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxMenu;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
        private System.Windows.Forms.Timer timerMenu;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonSeacher;
    }
}