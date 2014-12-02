﻿namespace FrbaHotel.ABM_de_Cliente
{
    partial class Cliente_Modificacion
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
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.cbox_tipo_doc = new System.Windows.Forms.ComboBox();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.date_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbox_nacionalidad = new System.Windows.Forms.ComboBox();
            this.txt_dom_dpto = new System.Windows.Forms.TextBox();
            this.lbl_dom_dpto = new System.Windows.Forms.Label();
            this.txt_dom_piso = new System.Windows.Forms.TextBox();
            this.lbl_dom_piso = new System.Windows.Forms.Label();
            this.txt_dom_nro = new System.Windows.Forms.TextBox();
            this.lbl_dom_nro = new System.Windows.Forms.Label();
            this.txt_dom_calle = new System.Windows.Forms.TextBox();
            this.lbl_dom_calle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(107, 300);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(180, 20);
            this.txt_pais.TabIndex = 44;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(12, 303);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 43;
            this.lbl_pais.Text = "País";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(107, 274);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(180, 20);
            this.txt_ciudad.TabIndex = 42;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(12, 277);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 41;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(107, 170);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 38;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 173);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 37;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 146);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 36;
            this.lbl_mail.Text = "E-mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(107, 143);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 35;
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Location = new System.Drawing.Point(12, 119);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(60, 13);
            this.lbl_fecha_nac.TabIndex = 34;
            this.lbl_fecha_nac.Text = "Fecha Nac";
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Location = new System.Drawing.Point(12, 92);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lbl_nacionalidad.TabIndex = 31;
            this.lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // cbox_tipo_doc
            // 
            this.cbox_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_doc.FormattingEnabled = true;
            this.cbox_tipo_doc.Location = new System.Drawing.Point(484, 37);
            this.cbox_tipo_doc.Name = "cbox_tipo_doc";
            this.cbox_tipo_doc.Size = new System.Drawing.Size(120, 21);
            this.cbox_tipo_doc.TabIndex = 30;
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(484, 64);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(120, 20);
            this.txt_nro_doc.TabIndex = 29;
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(400, 67);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(47, 13);
            this.lbl_nro_doc.TabIndex = 28;
            this.lbl_nro_doc.Text = "Nro Doc";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(400, 40);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_doc.TabIndex = 27;
            this.lbl_tipo_doc.Text = "Tipo Doc";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(107, 63);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(180, 20);
            this.txt_apellido.TabIndex = 26;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 25;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 66);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 24;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 23;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(400, 119);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 45;
            this.lbl_estado.Text = "Estado";
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(484, 116);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(120, 21);
            this.cbox_estado.TabIndex = 46;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(370, 349);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 47;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(484, 349);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 48;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // date_nacimiento
            // 
            this.date_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_nacimiento.Location = new System.Drawing.Point(107, 115);
            this.date_nacimiento.Name = "date_nacimiento";
            this.date_nacimiento.Size = new System.Drawing.Size(180, 20);
            this.date_nacimiento.TabIndex = 55;
            this.date_nacimiento.Value = new System.DateTime(2014, 11, 12, 0, 0, 0, 0);
            // 
            // cbox_nacionalidad
            // 
            this.cbox_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_nacionalidad.FormattingEnabled = true;
            this.cbox_nacionalidad.Location = new System.Drawing.Point(107, 90);
            this.cbox_nacionalidad.Name = "cbox_nacionalidad";
            this.cbox_nacionalidad.Size = new System.Drawing.Size(180, 21);
            this.cbox_nacionalidad.TabIndex = 56;
            // 
            // txt_dom_dpto
            // 
            this.txt_dom_dpto.Location = new System.Drawing.Point(222, 248);
            this.txt_dom_dpto.Name = "txt_dom_dpto";
            this.txt_dom_dpto.Size = new System.Drawing.Size(66, 20);
            this.txt_dom_dpto.TabIndex = 89;
            // 
            // lbl_dom_dpto
            // 
            this.lbl_dom_dpto.AutoSize = true;
            this.lbl_dom_dpto.Location = new System.Drawing.Point(189, 251);
            this.lbl_dom_dpto.Name = "lbl_dom_dpto";
            this.lbl_dom_dpto.Size = new System.Drawing.Size(30, 13);
            this.lbl_dom_dpto.TabIndex = 88;
            this.lbl_dom_dpto.Text = "Dpto";
            // 
            // txt_dom_piso
            // 
            this.txt_dom_piso.Location = new System.Drawing.Point(108, 248);
            this.txt_dom_piso.Name = "txt_dom_piso";
            this.txt_dom_piso.Size = new System.Drawing.Size(66, 20);
            this.txt_dom_piso.TabIndex = 87;
            // 
            // lbl_dom_piso
            // 
            this.lbl_dom_piso.AutoSize = true;
            this.lbl_dom_piso.Location = new System.Drawing.Point(14, 251);
            this.lbl_dom_piso.Name = "lbl_dom_piso";
            this.lbl_dom_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_dom_piso.TabIndex = 86;
            this.lbl_dom_piso.Text = "Piso";
            // 
            // txt_dom_nro
            // 
            this.txt_dom_nro.Location = new System.Drawing.Point(107, 222);
            this.txt_dom_nro.Name = "txt_dom_nro";
            this.txt_dom_nro.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_nro.TabIndex = 85;
            this.txt_dom_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_dom_nro
            // 
            this.lbl_dom_nro.AutoSize = true;
            this.lbl_dom_nro.Location = new System.Drawing.Point(13, 225);
            this.lbl_dom_nro.Name = "lbl_dom_nro";
            this.lbl_dom_nro.Size = new System.Drawing.Size(44, 13);
            this.lbl_dom_nro.TabIndex = 84;
            this.lbl_dom_nro.Text = "Número";
            // 
            // txt_dom_calle
            // 
            this.txt_dom_calle.Location = new System.Drawing.Point(107, 196);
            this.txt_dom_calle.Name = "txt_dom_calle";
            this.txt_dom_calle.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_calle.TabIndex = 83;
            // 
            // lbl_dom_calle
            // 
            this.lbl_dom_calle.AutoSize = true;
            this.lbl_dom_calle.Location = new System.Drawing.Point(13, 199);
            this.lbl_dom_calle.Name = "lbl_dom_calle";
            this.lbl_dom_calle.Size = new System.Drawing.Size(81, 13);
            this.lbl_dom_calle.TabIndex = 82;
            this.lbl_dom_calle.Text = "Domicilio - Calle";
            // 
            // Cliente_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.txt_dom_dpto);
            this.Controls.Add(this.lbl_dom_dpto);
            this.Controls.Add(this.txt_dom_piso);
            this.Controls.Add(this.lbl_dom_piso);
            this.Controls.Add(this.txt_dom_nro);
            this.Controls.Add(this.lbl_dom_nro);
            this.Controls.Add(this.txt_dom_calle);
            this.Controls.Add(this.lbl_dom_calle);
            this.Controls.Add(this.cbox_nacionalidad);
            this.Controls.Add(this.date_nacimiento);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_fecha_nac);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.cbox_tipo_doc);
            this.Controls.Add(this.txt_nro_doc);
            this.Controls.Add(this.lbl_nro_doc);
            this.Controls.Add(this.lbl_tipo_doc);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Cliente_Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_pais;
        public System.Windows.Forms.TextBox txt_ciudad;
        public System.Windows.Forms.TextBox txt_telefono;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_nro_doc;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.DateTimePicker date_nacimiento;
        public System.Windows.Forms.ComboBox cbox_nacionalidad;
        private System.Windows.Forms.Label lbl_dom_dpto;
        private System.Windows.Forms.Label lbl_dom_piso;
        private System.Windows.Forms.Label lbl_dom_nro;
        private System.Windows.Forms.Label lbl_dom_calle;
        public System.Windows.Forms.TextBox txt_dom_dpto;
        public System.Windows.Forms.TextBox txt_dom_piso;
        public System.Windows.Forms.TextBox txt_dom_nro;
        public System.Windows.Forms.TextBox txt_dom_calle;
        public System.Windows.Forms.ComboBox cbox_tipo_doc;
        public System.Windows.Forms.ComboBox cbox_estado;
    }
}