namespace iCantina.views
{
    partial class Faturas
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNameClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.listBoxInvoice = new System.Windows.Forms.ListBox();
            this.buttonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTeacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.monthCalendarInvoice = new System.Windows.Forms.MonthCalendar();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.labelNameClient);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.labelError);
            this.guna2Panel2.Controls.Add(this.listBoxClient);
            this.guna2Panel2.Controls.Add(this.listBoxInvoice);
            this.guna2Panel2.Controls.Add(this.buttonPrint);
            this.guna2Panel2.Controls.Add(this.buttonSearch);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.textBoxTeacher);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.textBoxStudent);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(332, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(693, 690);
            this.guna2Panel2.TabIndex = 40;
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Location = new System.Drawing.Point(92, 160);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(107, 16);
            this.labelNameClient.TabIndex = 10;
            this.labelNameClient.Text = "Nome do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(143, 121);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(107, 16);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Não encontrado!";
            this.labelError.Visible = false;
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(42, 198);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(83, 468);
            this.listBoxClient.TabIndex = 7;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // listBoxInvoice
            // 
            this.listBoxInvoice.FormattingEnabled = true;
            this.listBoxInvoice.ItemHeight = 16;
            this.listBoxInvoice.Location = new System.Drawing.Point(146, 197);
            this.listBoxInvoice.Name = "listBoxInvoice";
            this.listBoxInvoice.Size = new System.Drawing.Size(493, 468);
            this.listBoxInvoice.TabIndex = 6;
            // 
            // buttonPrint
            // 
            this.buttonPrint.AutoRoundedCorners = true;
            this.buttonPrint.BorderRadius = 18;
            this.buttonPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(423, 121);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(99, 39);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "Imprimir";
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoRoundedCorners = true;
            this.buttonSearch.BorderRadius = 18;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(540, 121);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 39);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Professor:";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.AutoRoundedCorners = true;
            this.textBoxTeacher.BorderRadius = 14;
            this.textBoxTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTeacher.DefaultText = "";
            this.textBoxTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTeacher.Location = new System.Drawing.Point(146, 67);
            this.textBoxTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.PasswordChar = '\0';
            this.textBoxTeacher.PlaceholderText = "";
            this.textBoxTeacher.SelectedText = "";
            this.textBoxTeacher.Size = new System.Drawing.Size(493, 30);
            this.textBoxTeacher.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno:";
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.AutoRoundedCorners = true;
            this.textBoxStudent.BorderRadius = 14;
            this.textBoxStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStudent.DefaultText = "";
            this.textBoxStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStudent.Location = new System.Drawing.Point(146, 29);
            this.textBoxStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.PasswordChar = '\0';
            this.textBoxStudent.PlaceholderText = "";
            this.textBoxStudent.SelectedText = "";
            this.textBoxStudent.Size = new System.Drawing.Size(493, 30);
            this.textBoxStudent.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(332, 690);
            this.guna2Panel1.TabIndex = 42;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.monthCalendarInvoice);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(332, 272);
            this.guna2Panel4.TabIndex = 1;
            // 
            // monthCalendarInvoice
            // 
            this.monthCalendarInvoice.Location = new System.Drawing.Point(12, 34);
            this.monthCalendarInvoice.Name = "monthCalendarInvoice";
            this.monthCalendarInvoice.TabIndex = 0;
            this.monthCalendarInvoice.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarInvoice_DateSelected);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.listBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 270);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(332, 420);
            this.guna2Panel3.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 388);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Faturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1025, 690);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Faturas";
            this.Text = "Faturas";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.MonthCalendar monthCalendarInvoice;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStudent;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.ListBox listBoxInvoice;
        private Guna.UI2.WinForms.Guna2Button buttonPrint;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelError;
    }
}