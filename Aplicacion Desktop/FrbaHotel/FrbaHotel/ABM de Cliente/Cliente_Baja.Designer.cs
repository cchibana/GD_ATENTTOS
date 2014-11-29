﻿namespace FrbaHotel.ABM_de_Cliente
{
    partial class Cliente_Baja
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
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.cBox_tipo_doc = new System.Windows.Forms.ComboBox();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.date_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbox_estado.Location = new System.Drawing.Point(485, 116);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(120, 21);
            this.cbox_estado.TabIndex = 70;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(401, 119);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 69;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(96, 248);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.ReadOnly = true;
            this.txt_pais.Size = new System.Drawing.Size(180, 20);
            this.txt_pais.TabIndex = 68;
            this.txt_pais.TextChanged += new System.EventHandler(this.txt_pais_TextChanged);
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(12, 251);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 67;
            this.lbl_pais.Text = "País";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(96, 222);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.ReadOnly = true;
            this.txt_localidad.Size = new System.Drawing.Size(180, 20);
            this.txt_localidad.TabIndex = 66;
            this.txt_localidad.TextChanged += new System.EventHandler(this.txt_localidad_TextChanged);
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Location = new System.Drawing.Point(12, 225);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(53, 13);
            this.lbl_localidad.TabIndex = 65;
            this.lbl_localidad.Text = "Localidad";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(96, 196);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(180, 20);
            this.txt_direccion.TabIndex = 64;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(12, 199);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 63;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(96, 170);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 62;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 173);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 61;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 146);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 60;
            this.lbl_mail.Text = "E-mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(96, 143);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.ReadOnly = true;
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 59;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Location = new System.Drawing.Point(12, 119);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(60, 13);
            this.lbl_fecha_nac.TabIndex = 58;
            this.lbl_fecha_nac.Text = "Fecha Nac";
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(96, 89);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.ReadOnly = true;
            this.txt_nacionalidad.Size = new System.Drawing.Size(180, 20);
            this.txt_nacionalidad.TabIndex = 56;
            this.txt_nacionalidad.TextChanged += new System.EventHandler(this.txt_nacionalidad_TextChanged);
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Location = new System.Drawing.Point(12, 92);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lbl_nacionalidad.TabIndex = 55;
            this.lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // cBox_tipo_doc
            // 
            this.cBox_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_tipo_doc.Enabled = false;
            this.cBox_tipo_doc.FormattingEnabled = true;
            this.cBox_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cBox_tipo_doc.Location = new System.Drawing.Point(485, 37);
            this.cBox_tipo_doc.Name = "cBox_tipo_doc";
            this.cBox_tipo_doc.Size = new System.Drawing.Size(120, 21);
            this.cBox_tipo_doc.TabIndex = 54;
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(485, 64);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.ReadOnly = true;
            this.txt_nro_doc.Size = new System.Drawing.Size(120, 20);
            this.txt_nro_doc.TabIndex = 53;
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(401, 67);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(47, 13);
            this.lbl_nro_doc.TabIndex = 52;
            this.lbl_nro_doc.Text = "Nro Doc";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(401, 40);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_doc.TabIndex = 51;
            this.lbl_tipo_doc.Text = "Tipo Doc";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(96, 63);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(180, 20);
            this.txt_apellido.TabIndex = 50;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(96, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 49;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 66);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 48;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 47;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(371, 325);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 71;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(485, 325);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 72;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // date_nacimiento
            // 
            this.date_nacimiento.Enabled = false;
            this.date_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_nacimiento.Location = new System.Drawing.Point(96, 115);
            this.date_nacimiento.Name = "date_nacimiento";
            this.date_nacimiento.Size = new System.Drawing.Size(180, 20);
            this.date_nacimiento.TabIndex = 73;
            this.date_nacimiento.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.date_nacimiento.ValueChanged += new System.EventHandler(this.date_nacimiento_ValueChanged);
            // 
            // Cliente_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.date_nacimiento);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_localidad);
            this.Controls.Add(this.lbl_localidad);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_fecha_nac);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.cBox_tipo_doc);
            this.Controls.Add(this.txt_nro_doc);
            this.Controls.Add(this.lbl_nro_doc);
            this.Controls.Add(this.lbl_tipo_doc);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Cliente_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Cliente";
            this.Load += new System.EventHandler(this.Cliente_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.ComboBox cBox_tipo_doc;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox txt_nacionalidad;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.DateTimePicker date_nacimiento;
        public System.Windows.Forms.TextBox txt_pais;
        public System.Windows.Forms.TextBox txt_localidad;
        public System.Windows.Forms.TextBox txt_direccion;
        public System.Windows.Forms.TextBox txt_telefono;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_nro_doc;
    }
}