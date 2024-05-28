namespace iCantina
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.labelPalavraPasse = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilizador.Location = new System.Drawing.Point(264, 206);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(136, 29);
            this.labelUtilizador.TabIndex = 0;
            this.labelUtilizador.Text = "Username: ";
            // 
            // labelPalavraPasse
            // 
            this.labelPalavraPasse.AutoSize = true;
            this.labelPalavraPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalavraPasse.Location = new System.Drawing.Point(264, 274);
            this.labelPalavraPasse.Name = "labelPalavraPasse";
            this.labelPalavraPasse.Size = new System.Drawing.Size(132, 29);
            this.labelPalavraPasse.TabIndex = 1;
            this.labelPalavraPasse.Text = "Password: ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(395, 201);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(245, 35);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(394, 269);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(245, 35);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(508, 350);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(130, 34);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.BackColor = System.Drawing.Color.White;
            this.labelErro.ForeColor = System.Drawing.Color.Gray;
            this.labelErro.Location = new System.Drawing.Point(269, 316);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(51, 20);
            this.labelErro.TabIndex = 4;
            this.labelErro.Text = "label1";
            this.labelErro.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(904, 562);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPalavraPasse);
            this.Controls.Add(this.labelUtilizador);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.Label labelPalavraPasse;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelErro;
    }
}

