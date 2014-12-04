namespace FrbaHotel.ABM_de_Usuario
{
    partial class Usuarios
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
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.btn_TodosRolesHoteles = new System.Windows.Forms.Button();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cb_EstadoUsuario = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_Doc = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panelUsuarios.SuspendLayout();
            this.gBox_filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(687, 610);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(118, 43);
            this.btn_Baja.TabIndex = 34;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(539, 610);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(120, 43);
            this.btn_Modificacion.TabIndex = 33;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            this.btn_Modificacion.Click += new System.EventHandler(this.btn_Modificacion_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(394, 610);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(118, 43);
            this.btn_Alta.TabIndex = 32;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(43, 304);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(1096, 286);
            this.dgv_usuarios.TabIndex = 31;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(850, 229);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(134, 41);
            this.btn_Buscar.TabIndex = 36;
            this.btn_Buscar.Text = "Buscar Usuarios";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(1003, 229);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(136, 41);
            this.btn_Limpiar.TabIndex = 35;
            this.btn_Limpiar.Text = "Limpiar Campos";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.btn_TodosRolesHoteles);
            this.panelUsuarios.Controls.Add(this.btn_Baja);
            this.panelUsuarios.Controls.Add(this.btn_Modificacion);
            this.panelUsuarios.Controls.Add(this.btn_Limpiar);
            this.panelUsuarios.Controls.Add(this.btn_Alta);
            this.panelUsuarios.Controls.Add(this.btn_Buscar);
            this.panelUsuarios.Controls.Add(this.gBox_filtros);
            this.panelUsuarios.Controls.Add(this.dgv_usuarios);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(1183, 665);
            this.panelUsuarios.TabIndex = 37;
            // 
            // btn_TodosRolesHoteles
            // 
            this.btn_TodosRolesHoteles.Location = new System.Drawing.Point(974, 610);
            this.btn_TodosRolesHoteles.Name = "btn_TodosRolesHoteles";
            this.btn_TodosRolesHoteles.Size = new System.Drawing.Size(165, 43);
            this.btn_TodosRolesHoteles.TabIndex = 37;
            this.btn_TodosRolesHoteles.Text = "Ver Roles y Hoteles del Usuario";
            this.btn_TodosRolesHoteles.UseVisualStyleBackColor = true;
            this.btn_TodosRolesHoteles.Click += new System.EventHandler(this.btn_TodosRolesHoteles_Click);
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.groupBox2);
            this.gBox_filtros.Controls.Add(this.groupBox1);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(43, 31);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(1096, 192);
            this.gBox_filtros.TabIndex = 1;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.cb_EstadoUsuario);
            this.groupBox2.Controls.Add(this.lbl_tipo_Doc);
            this.groupBox2.Controls.Add(this.lbl_Nombre);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 151);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(154, 33);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // cb_EstadoUsuario
            // 
            this.cb_EstadoUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte"});
            this.cb_EstadoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EstadoUsuario.FormattingEnabled = true;
            this.cb_EstadoUsuario.Location = new System.Drawing.Point(154, 66);
            this.cb_EstadoUsuario.Name = "cb_EstadoUsuario";
            this.cb_EstadoUsuario.Size = new System.Drawing.Size(144, 21);
            this.cb_EstadoUsuario.TabIndex = 13;
            // 
            // lbl_tipo_Doc
            // 
            this.lbl_tipo_Doc.AutoSize = true;
            this.lbl_tipo_Doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_tipo_Doc.Location = new System.Drawing.Point(34, 69);
            this.lbl_tipo_Doc.Name = "lbl_tipo_Doc";
            this.lbl_tipo_Doc.Size = new System.Drawing.Size(96, 13);
            this.lbl_tipo_Doc.TabIndex = 14;
            this.lbl_tipo_Doc.Text = "Estado del Usuario";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Nombre.Location = new System.Drawing.Point(34, 33);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(98, 13);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre de Usuario";
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
            this.groupBox1.Location = new System.Drawing.Point(363, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 151);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // dtp_Usuario_FechaNacimiento
            // 
            this.dtp_Usuario_FechaNacimiento.Location = new System.Drawing.Point(507, 111);
            this.dtp_Usuario_FechaNacimiento.Name = "dtp_Usuario_FechaNacimiento";
            this.dtp_Usuario_FechaNacimiento.Size = new System.Drawing.Size(192, 20);
            this.dtp_Usuario_FechaNacimiento.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // txt_Usuario_Direccion
            // 
            this.txt_Usuario_Direccion.Location = new System.Drawing.Point(507, 82);
            this.txt_Usuario_Direccion.Name = "txt_Usuario_Direccion";
            this.txt_Usuario_Direccion.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_Direccion.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Dirección";
            // 
            // txt_Usuario_Telefono
            // 
            this.txt_Usuario_Telefono.Location = new System.Drawing.Point(507, 56);
            this.txt_Usuario_Telefono.Name = "txt_Usuario_Telefono";
            this.txt_Usuario_Telefono.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_Telefono.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono";
            // 
            // txt_Usuario_Mail
            // 
            this.txt_Usuario_Mail.Location = new System.Drawing.Point(507, 30);
            this.txt_Usuario_Mail.Name = "txt_Usuario_Mail";
            this.txt_Usuario_Mail.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_Mail.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 37);
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
            this.cb_Usuario_TipoDocumento.Size = new System.Drawing.Size(192, 21);
            this.cb_Usuario_TipoDocumento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Documento";
            // 
            // txt_Usuario_Apellido
            // 
            this.txt_Usuario_Apellido.Location = new System.Drawing.Point(153, 56);
            this.txt_Usuario_Apellido.Name = "txt_Usuario_Apellido";
            this.txt_Usuario_Apellido.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_Apellido.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // txt_Usuario_NroDocumento
            // 
            this.txt_Usuario_NroDocumento.Location = new System.Drawing.Point(153, 108);
            this.txt_Usuario_NroDocumento.Name = "txt_Usuario_NroDocumento";
            this.txt_Usuario_NroDocumento.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_NroDocumento.TabIndex = 3;
            // 
            // txt_Usuario_Nombre
            // 
            this.txt_Usuario_Nombre.Location = new System.Drawing.Point(153, 30);
            this.txt_Usuario_Nombre.Name = "txt_Usuario_Nombre";
            this.txt_Usuario_Nombre.Size = new System.Drawing.Size(192, 20);
            this.txt_Usuario_Nombre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 665);
            this.Controls.Add(this.panelUsuarios);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panelUsuarios.ResumeLayout(false);
            this.gBox_filtros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificacion;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.GroupBox gBox_filtros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cb_EstadoUsuario;
        private System.Windows.Forms.Label lbl_tipo_Doc;
        private System.Windows.Forms.Label lbl_Nombre;
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
        private System.Windows.Forms.Button btn_TodosRolesHoteles;

    }
}