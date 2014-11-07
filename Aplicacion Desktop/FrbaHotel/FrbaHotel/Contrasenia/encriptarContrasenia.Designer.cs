namespace FrbaHotel.Contrasenia
{
    partial class encriptarContrasenia
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
            this.btn_encriptarContrasenia = new System.Windows.Forms.Button();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.chb_mostrarCaracteres = new System.Windows.Forms.CheckBox();
            this.txt_hash = new System.Windows.Forms.TextBox();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_encriptarContrasenia
            // 
            this.btn_encriptarContrasenia.Location = new System.Drawing.Point(410, 34);
            this.btn_encriptarContrasenia.Name = "btn_encriptarContrasenia";
            this.btn_encriptarContrasenia.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptarContrasenia.TabIndex = 0;
            this.btn_encriptarContrasenia.Text = "Encriptar";
            this.btn_encriptarContrasenia.UseVisualStyleBackColor = true;
            this.btn_encriptarContrasenia.Click += new System.EventHandler(this.btn_encriptarContrasenia_Click);
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.Location = new System.Drawing.Point(57, 39);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(61, 13);
            this.lbl_contrasenia.TabIndex = 1;
            this.lbl_contrasenia.Text = "Contraseña";
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.AcceptsTab = true;
            this.txt_contrasenia.Location = new System.Drawing.Point(145, 36);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(259, 20);
            this.txt_contrasenia.TabIndex = 2;
            this.txt_contrasenia.UseSystemPasswordChar = true;
            // 
            // chb_mostrarCaracteres
            // 
            this.chb_mostrarCaracteres.AutoSize = true;
            this.chb_mostrarCaracteres.Location = new System.Drawing.Point(145, 62);
            this.chb_mostrarCaracteres.Name = "chb_mostrarCaracteres";
            this.chb_mostrarCaracteres.Size = new System.Drawing.Size(115, 17);
            this.chb_mostrarCaracteres.TabIndex = 3;
            this.chb_mostrarCaracteres.Text = "Mostrar Caracteres";
            this.chb_mostrarCaracteres.UseVisualStyleBackColor = true;
            this.chb_mostrarCaracteres.CheckedChanged += new System.EventHandler(this.chb_mostrarCaracteres_CheckedChanged);
            // 
            // txt_hash
            // 
            this.txt_hash.AcceptsTab = true;
            this.txt_hash.Location = new System.Drawing.Point(126, 23);
            this.txt_hash.Name = "txt_hash";
            this.txt_hash.ReadOnly = true;
            this.txt_hash.Size = new System.Drawing.Size(383, 20);
            this.txt_hash.TabIndex = 5;
            this.txt_hash.Visible = false;
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Location = new System.Drawing.Point(17, 26);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(82, 13);
            this.lbl_hash.TabIndex = 4;
            this.lbl_hash.Text = "Hash Generado";
            this.lbl_hash.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_hash);
            this.panel1.Controls.Add(this.lbl_hash);
            this.panel1.Location = new System.Drawing.Point(17, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 69);
            this.panel1.TabIndex = 6;
            // 
            // encriptarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 176);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chb_mostrarCaracteres);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.btn_encriptarContrasenia);
            this.Name = "encriptarContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encriptar Contraseña";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encriptarContrasenia;
        private System.Windows.Forms.Label lbl_contrasenia;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.CheckBox chb_mostrarCaracteres;
        private System.Windows.Forms.TextBox txt_hash;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.Panel panel1;
    }
}