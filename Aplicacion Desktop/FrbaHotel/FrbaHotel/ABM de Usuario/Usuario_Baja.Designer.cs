namespace FrbaHotel.ABM_de_Usuario
{
    partial class Usuario_Baja
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
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TodosRolesHoteles = new System.Windows.Forms.Button();
            this.lb_roles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_FechaNacimiento = new System.Windows.Forms.TextBox();
            this.txt_TipoDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Usuario_Direccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Usuario_Telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Usuario_Mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Usuario_Apellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario_NroDocumento = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(285, 355);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(113, 37);
            this.btn_Baja.TabIndex = 21;
            this.btn_Baja.Text = "Dar de Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(418, 355);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 37);
            this.btn_Cancelar.TabIndex = 20;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TodosRolesHoteles);
            this.groupBox3.Controls.Add(this.lb_roles);
            this.groupBox3.Location = new System.Drawing.Point(22, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 203);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles en el Hotel Actual";
            // 
            // btn_TodosRolesHoteles
            // 
            this.btn_TodosRolesHoteles.Location = new System.Drawing.Point(193, 82);
            this.btn_TodosRolesHoteles.Name = "btn_TodosRolesHoteles";
            this.btn_TodosRolesHoteles.Size = new System.Drawing.Size(165, 37);
            this.btn_TodosRolesHoteles.TabIndex = 4;
            this.btn_TodosRolesHoteles.Text = "Ver todos los Roles de todos los Hoteles";
            this.btn_TodosRolesHoteles.UseVisualStyleBackColor = true;
            this.btn_TodosRolesHoteles.Click += new System.EventHandler(this.btn_TodosRolesHoteles_Click);
            // 
            // lb_roles
            // 
            this.lb_roles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_roles.FormattingEnabled = true;
            this.lb_roles.Location = new System.Drawing.Point(18, 23);
            this.lb_roles.Name = "lb_roles";
            this.lb_roles.Size = new System.Drawing.Size(165, 160);
            this.lb_roles.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Estado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Username);
            this.groupBox2.Location = new System.Drawing.Point(22, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 98);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Logueo";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(157, 59);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.ReadOnly = true;
            this.txt_Estado.Size = new System.Drawing.Size(196, 20);
            this.txt_Estado.TabIndex = 10;
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
            this.txt_Username.ReadOnly = true;
            this.txt_Username.Size = new System.Drawing.Size(196, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_FechaNacimiento);
            this.groupBox1.Controls.Add(this.txt_TipoDocumento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Usuario_Direccion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Usuario_Telefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Usuario_Mail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Usuario_Apellido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Usuario_NroDocumento);
            this.groupBox1.Controls.Add(this.txt_Usuario_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(423, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 314);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txt_FechaNacimiento
            // 
            this.txt_FechaNacimiento.Location = new System.Drawing.Point(153, 212);
            this.txt_FechaNacimiento.Name = "txt_FechaNacimiento";
            this.txt_FechaNacimiento.ReadOnly = true;
            this.txt_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.txt_FechaNacimiento.TabIndex = 21;
            // 
            // txt_TipoDocumento
            // 
            this.txt_TipoDocumento.Location = new System.Drawing.Point(153, 82);
            this.txt_TipoDocumento.Name = "txt_TipoDocumento";
            this.txt_TipoDocumento.ReadOnly = true;
            this.txt_TipoDocumento.Size = new System.Drawing.Size(200, 20);
            this.txt_TipoDocumento.TabIndex = 20;
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
            this.txt_Usuario_Direccion.ReadOnly = true;
            this.txt_Usuario_Direccion.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Direccion.TabIndex = 6;
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
            this.txt_Usuario_Telefono.ReadOnly = true;
            this.txt_Usuario_Telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Telefono.TabIndex = 5;
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
            this.txt_Usuario_Mail.ReadOnly = true;
            this.txt_Usuario_Mail.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Mail.TabIndex = 4;
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
            this.txt_Usuario_Apellido.ReadOnly = true;
            this.txt_Usuario_Apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Apellido.TabIndex = 1;
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
            this.txt_Usuario_NroDocumento.ReadOnly = true;
            this.txt_Usuario_NroDocumento.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_NroDocumento.TabIndex = 3;
            // 
            // txt_Usuario_Nombre
            // 
            this.txt_Usuario_Nombre.Location = new System.Drawing.Point(153, 30);
            this.txt_Usuario_Nombre.Name = "txt_Usuario_Nombre";
            this.txt_Usuario_Nombre.ReadOnly = true;
            this.txt_Usuario_Nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_Usuario_Nombre.TabIndex = 0;
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
            // Usuario_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Cancelar);
            this.Name = "Usuario_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Usuario";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_TodosRolesHoteles;
        private System.Windows.Forms.ListBox lb_roles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Usuario_Direccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Usuario_Telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Usuario_Mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Usuario_Apellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario_NroDocumento;
        private System.Windows.Forms.TextBox txt_Usuario_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_FechaNacimiento;
        private System.Windows.Forms.TextBox txt_TipoDocumento;
    }
}