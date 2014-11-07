namespace FrbaHotel
{
    partial class Form1
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
            this.btn_contrasenia = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_contrasenia
            // 
            this.btn_contrasenia.Location = new System.Drawing.Point(54, 39);
            this.btn_contrasenia.Name = "btn_contrasenia";
            this.btn_contrasenia.Size = new System.Drawing.Size(184, 46);
            this.btn_contrasenia.TabIndex = 0;
            this.btn_contrasenia.Text = "Cifrar Contraseñas";
            this.btn_contrasenia.UseVisualStyleBackColor = true;
            this.btn_contrasenia.Click += new System.EventHandler(this.btn_contrasenia_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(54, 113);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(184, 46);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "FRBA-Hoteles";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 206);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_contrasenia);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_contrasenia;
        private System.Windows.Forms.Button btn_login;
    }
}