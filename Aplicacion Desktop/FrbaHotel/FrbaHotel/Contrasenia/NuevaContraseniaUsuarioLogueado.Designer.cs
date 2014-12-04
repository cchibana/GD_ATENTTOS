namespace FrbaHotel.Contrasenia
{
    partial class NuevaContraseniaUsuarioLogueado
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ContraseniaNueva1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ContraseniaActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ContraseniaNueva2 = new System.Windows.Forms.TextBox();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(125, 138);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(170, 36);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar Nueva Contraseña";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña Nueva";
            // 
            // txt_ContraseniaNueva1
            // 
            this.txt_ContraseniaNueva1.Location = new System.Drawing.Point(185, 75);
            this.txt_ContraseniaNueva1.Name = "txt_ContraseniaNueva1";
            this.txt_ContraseniaNueva1.Size = new System.Drawing.Size(212, 20);
            this.txt_ContraseniaNueva1.TabIndex = 1;
            this.txt_ContraseniaNueva1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña Actual";
            // 
            // txt_ContraseniaActual
            // 
            this.txt_ContraseniaActual.Location = new System.Drawing.Point(185, 49);
            this.txt_ContraseniaActual.Name = "txt_ContraseniaActual";
            this.txt_ContraseniaActual.Size = new System.Drawing.Size(212, 20);
            this.txt_ContraseniaActual.TabIndex = 0;
            this.txt_ContraseniaActual.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Confirmar Contraseña Nueva";
            // 
            // txt_ContraseniaNueva2
            // 
            this.txt_ContraseniaNueva2.Location = new System.Drawing.Point(185, 101);
            this.txt_ContraseniaNueva2.Name = "txt_ContraseniaNueva2";
            this.txt_ContraseniaNueva2.Size = new System.Drawing.Size(212, 20);
            this.txt_ContraseniaNueva2.TabIndex = 2;
            this.txt_ContraseniaNueva2.UseSystemPasswordChar = true;
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(182, 15);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(131, 17);
            this.lbl_NombreUsuario.TabIndex = 14;
            this.lbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // NuevaContraseniaUsuarioLogueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 186);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ContraseniaNueva2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ContraseniaActual);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ContraseniaNueva1);
            this.Controls.Add(this.label1);
            this.Name = "NuevaContraseniaUsuarioLogueado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña Propia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ContraseniaNueva1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ContraseniaActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ContraseniaNueva2;
        private System.Windows.Forms.Label lbl_NombreUsuario;
    }
}