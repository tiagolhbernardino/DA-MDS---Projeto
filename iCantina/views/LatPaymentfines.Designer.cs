namespace iCantina.views
{
    partial class LatPaymentfines
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
            this.listBoxtempos = new System.Windows.Forms.ListBox();
            this.labelhoras = new System.Windows.Forms.Label();
            this.labelMulta = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.labeltemp = new System.Windows.Forms.Label();
            this.buttonParar = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxtempos
            // 
            this.listBoxtempos.FormattingEnabled = true;
            this.listBoxtempos.ItemHeight = 16;
            this.listBoxtempos.Location = new System.Drawing.Point(503, 160);
            this.listBoxtempos.Name = "listBoxtempos";
            this.listBoxtempos.Size = new System.Drawing.Size(161, 84);
            this.listBoxtempos.TabIndex = 0;
            // 
            // labelhoras
            // 
            this.labelhoras.AutoSize = true;
            this.labelhoras.Location = new System.Drawing.Point(500, 141);
            this.labelhoras.Name = "labelhoras";
            this.labelhoras.Size = new System.Drawing.Size(44, 16);
            this.labelhoras.TabIndex = 2;
            this.labelhoras.Text = "Horas";
            // 
            // labelMulta
            // 
            this.labelMulta.AutoSize = true;
            this.labelMulta.Location = new System.Drawing.Point(193, 252);
            this.labelMulta.Name = "labelMulta";
            this.labelMulta.Size = new System.Drawing.Size(103, 16);
            this.labelMulta.TabIndex = 3;
            this.labelMulta.Text = "Valor da Multa €";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(199, 105);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Inicio";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(599, 311);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 6;
            this.buttonsearch.Text = "Procurar";
            this.buttonsearch.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(503, 354);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(599, 353);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(196, 179);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(100, 22);
            this.textBoxHoras.TabIndex = 9;
            this.textBoxHoras.Text = "00:00";
            this.textBoxHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Location = new System.Drawing.Point(196, 160);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(44, 16);
            this.labeltemp.TabIndex = 10;
            this.labeltemp.Text = "Horas";
            // 
            // buttonParar
            // 
            this.buttonParar.Location = new System.Drawing.Point(196, 353);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(75, 23);
            this.buttonParar.TabIndex = 11;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(311, 252);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(17, 16);
            this.labelValor.TabIndex = 12;
            this.labelValor.Text = "€:";
            // 
            // LatPaymentfines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMulta);
            this.Controls.Add(this.labelhoras);
            this.Controls.Add(this.listBoxtempos);
            this.Name = "LatPaymentfines";
            this.Text = "LatPaymentfines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxtempos;
        private System.Windows.Forms.Label labelhoras;
        private System.Windows.Forms.Label labelMulta;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Label labelValor;
    }
}