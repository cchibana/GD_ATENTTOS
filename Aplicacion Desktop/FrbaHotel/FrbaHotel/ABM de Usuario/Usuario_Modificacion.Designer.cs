namespace FrbaHotel.ABM_de_Usuario
{
    partial class Usuario_Modificacion
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_QuitarRol = new System.Windows.Forms.Button();
            this.lb_roles = new System.Windows.Forms.ListBox();
            this.btn_AgregarRol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Rol = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Usuario_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Usuario_Direccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Usuario_Telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Usuario_Mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Usuario_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Usuario_Apellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario_NroDocumento = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_EstadoUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NuevaContrasenia = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(265, 386);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(113, 37);
            this.btn_Limpiar.TabIndex = 21;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(450, 386);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(113, 37);
            this.btn_Guardar.TabIndex = 20;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_QuitarRol);
            this.groupBox3.Controls.Add(this.lb_roles);
            this.groupBox3.Controls.Add(this.btn_AgregarRol);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_Rol);
            this.groupBox3.Location = new System.Drawing.Point(25, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 200);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles";
            // 
            // btn_QuitarRol
            // 
            this.btn_QuitarRol.Location = new System.Drawing.Point(30, 151);
            this.btn_QuitarRol.Name = "btn_QuitarRol";
            this.btn_QuitarRol.Size = new System.Drawing.Size(145, 33);
            this.btn_QuitarRol.TabIndex = 14;
            this.btn_QuitarRol.Text = "Quitar Rol";
            this.btn_QuitarRol.UseVisualStyleBackColor = true;
            this.btn_QuitarRol.Click += new System.EventHandler(this.btn_QuitarRol_Click);
            // 
            // lb_roles
            // 
            this.lb_roles.FormattingEnabled = true;
            this.lb_roles.Location = new System.Drawing.Point(188, 24);
            this.lb_roles.Name = "lb_roles";
            this.lb_roles.Size = new System.Drawing.Size(165, 160);
            this.lb_roles.TabIndex = 4;
            // 
            // btn_AgregarRol
            // 
            this.btn_AgregarRol.Location = new System.Drawing.Point(30, 75);
            this.btn_AgregarRol.Name = "btn_AgregarRol";
            this.btn_AgregarRol.Size = new System.Drawing.Size(145, 33);
            this.btn_AgregarRol.TabIndex = 13;
            this.btn_AgregarRol.Text = "Agregar Rol";
            this.btn_AgregarRol.UseVisualStyleBackColor = true;
            this.btn_AgregarRol.Click += new System.EventHandler(this.btn_AgregarRol_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // cb_Rol
            // 
            this.cb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rol.FormattingEnabled = true;
            this.cb_Rol.Location = new System.Drawing.Point(30, 49);
            this.cb_Rol.Name = "cb_Rol";
            this.cb_Rol.Size = new System.Drawing.Size(145, 21);
            this.cb_Rol.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_NuevaContrasenia);
            this.groupBox2.Controls.Add(this.cb_EstadoUsuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Username);
            this.groupBox2.Location = new System.Drawing.Point(25, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 142);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Logueo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(157, 30);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(196, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Usuario_FechaNacimiento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Usuario_Direccion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Usuario_Telefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Usuario_Mail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_Usuario_TipoDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Usuario_Apellido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Usuario_NroDocumento);
            this.groupBox1.Controls.Add(this.txt_Usuario_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(426, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 348);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // dtp_Usuario_FechaNacimiento
            // 
            this.dtp_Usuario_FechaNacimiento.Location = new System.Drawing.Point(153, 215);
            this.dtp_Usuario_FechaNacimiento.Name = "dtp_Usuario_FechaNacimiento";
            this.dtp_Usuario_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_Usuario_FechaNacimiento.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // txt_Usuario_Direccion
            // 
            this.txt_Usuario_Direccion.Location = new System.Drawing.Point(153, 186);
            this.txt_Usuario_Direccion.Name = "txt_Usuario_Direccion";
            this.txt_Usuario_Direccion.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Direccion.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Dirección";
            // 
            // txt_Usuario_Telefono
            // 
            this.txt_Usuario_Telefono.Location = new System.Drawing.Point(153, 160);
            this.txt_Usuario_Telefono.Name = "txt_Usuario_Telefono";
            this.txt_Usuario_Telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Telefono.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono";
            // 
            // txt_Usuario_Mail
            // 
            this.txt_Usuario_Mail.Location = new System.Drawing.Point(153, 134);
            this.txt_Usuario_Mail.Name = "txt_Usuario_Mail";
            this.txt_Usuario_Mail.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Mail.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mail";
            // 
            // cb_Usuario_TipoDocumento
            // 
            this.cb_Usuario_TipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario_TipoDocumento.FormattingEnabled = true;
            this.cb_Usuario_TipoDocumento.Location = new System.Drawing.Point(153, 82);
            this.cb_Usuario_TipoDocumento.Name = "cb_Usuario_TipoDocumento";
            this.cb_Usuario_TipoDocumento.Size = new System.Drawing.Size(200, 21);
            this.cb_Usuario_TipoDocumento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Documento";
            // 
            // txt_Usuario_Apellido
            // 
            this.txt_Usuario_Apellido.Location = new System.Drawing.Point(153, 56);
            this.txt_Usuario_Apellido.Name = "txt_Usuario_Apellido";
            this.txt_Usuario_Apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Apellido.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // txt_Usuario_NroDocumento
            // 
            this.txt_Usuario_NroDocumento.Location = new System.Drawing.Point(153, 108);
            this.txt_Usuario_NroDocumento.Name = "txt_Usuario_NroDocumento";
            this.txt_Usuario_NroDocumento.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_NroDocumento.TabIndex = 11;
            // 
            // txt_Usuario_Nombre
            // 
            this.txt_Usuario_Nombre.Location = new System.Drawing.Point(153, 30);
            this.txt_Usuario_Nombre.Name = "txt_Usuario_Nombre";
            this.txt_Usuario_Nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // cb_EstadoUsuario
            // 
            this.cb_EstadoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EstadoUsuario.FormattingEnabled = true;
            this.cb_EstadoUsuario.Location = new System.Drawing.Point(157, 59);
            this.cb_EstadoUsuario.Name = "cb_EstadoUsuario";
            this.cb_EstadoUsuario.Size = new System.Drawing.Size(196, 21);
            this.cb_EstadoUsuario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estado del Usuario";
            // 
            // btn_NuevaContrasenia
            // 
            this.btn_NuevaContrasenia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_NuevaContrasenia.Location = new System.Drawing.Point(30, 101);
            this.btn_NuevaContrasenia.Name = "btn_NuevaContrasenia";
            this.btn_NuevaContrasenia.Size = new System.Drawing.Size(171, 33);
            this.btn_NuevaContrasenia.TabIndex = 15;
            this.btn_NuevaContrasenia.Text = "Generar nueva Contraseña";
            this.btn_NuevaContrasenia.UseVisualStyleBackColor = true;
            // 
            // Usuario_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "Usuario_Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario_Modificacion";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_QuitarRol;
        private System.Windows.Forms.ListBox lb_roles;
        private System.Windows.Forms.Button btn_AgregarRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Rol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_Usuario_FechaNacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Usuario_Direccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Usuario_Telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Usuario_Mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Usuario_TipoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Usuario_Apellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario_NroDocumento;
        private System.Windows.Forms.TextBox txt_Usuario_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NuevaContrasenia;
        private System.Windows.Forms.ComboBox cb_EstadoUsuario;
        private System.Windows.Forms.Label label2;
    }
}