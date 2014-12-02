namespace FrbaHotel.ABM_de_Cliente
{
    partial class Cliente_Alta
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nrodoc = new System.Windows.Forms.TextBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.cbox_tipodoc = new System.Windows.Forms.ComboBox();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_dom_calle = new System.Windows.Forms.TextBox();
            this.lbl_dom_calle = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.date_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbox_nacionalidad = new System.Windows.Forms.ComboBox();
            this.txt_dom_nro = new System.Windows.Forms.TextBox();
            this.lbl_dom_nro = new System.Windows.Forms.Label();
            this.txt_dom_piso = new System.Windows.Forms.TextBox();
            this.lbl_dom_piso = new System.Windows.Forms.Label();
            this.txt_dom_dpto = new System.Windows.Forms.TextBox();
            this.lbl_dom_dpto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 66);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(96, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(96, 63);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(180, 20);
            this.txt_apellido.TabIndex = 3;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(490, 64);
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(120, 20);
            this.txt_nrodoc.TabIndex = 7;
            this.txt_nrodoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(406, 67);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(47, 13);
            this.lbl_nro_doc.TabIndex = 5;
            this.lbl_nro_doc.Text = "Nro Doc";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(406, 40);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_doc.TabIndex = 4;
            this.lbl_tipo_doc.Text = "Tipo Doc";
            // 
            // cbox_tipodoc
            // 
            this.cbox_tipodoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipodoc.FormattingEnabled = true;
            this.cbox_tipodoc.Location = new System.Drawing.Point(490, 34);
            this.cbox_tipodoc.Name = "cbox_tipodoc";
            this.cbox_tipodoc.Size = new System.Drawing.Size(120, 21);
            this.cbox_tipodoc.TabIndex = 8;
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Location = new System.Drawing.Point(12, 92);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lbl_nacionalidad.TabIndex = 9;
            this.lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Location = new System.Drawing.Point(12, 119);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(60, 13);
            this.lbl_fecha_nac.TabIndex = 12;
            this.lbl_fecha_nac.Text = "Fecha Nac";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(96, 143);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 13;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 146);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 14;
            this.lbl_mail.Text = "E-mail";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 173);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 15;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(97, 170);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 16;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // txt_dom_calle
            // 
            this.txt_dom_calle.Location = new System.Drawing.Point(96, 196);
            this.txt_dom_calle.Name = "txt_dom_calle";
            this.txt_dom_calle.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_calle.TabIndex = 18;
            // 
            // lbl_dom_calle
            // 
            this.lbl_dom_calle.AutoSize = true;
            this.lbl_dom_calle.Location = new System.Drawing.Point(12, 199);
            this.lbl_dom_calle.Name = "lbl_dom_calle";
            this.lbl_dom_calle.Size = new System.Drawing.Size(81, 13);
            this.lbl_dom_calle.TabIndex = 17;
            this.lbl_dom_calle.Text = "Domicilio - Calle";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(96, 274);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(180, 20);
            this.txt_ciudad.TabIndex = 20;
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Location = new System.Drawing.Point(12, 277);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_Ciudad.TabIndex = 19;
            this.lbl_Ciudad.Text = "Ciudad";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(96, 300);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(180, 20);
            this.txt_pais.TabIndex = 22;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(12, 303);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 21;
            this.lbl_pais.Text = "País";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(372, 314);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(490, 314);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(490, 143);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(120, 21);
            this.cbox_estado.TabIndex = 72;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(406, 146);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 71;
            this.lbl_estado.Text = "Estado";
            // 
            // date_nacimiento
            // 
            this.date_nacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_nacimiento.Location = new System.Drawing.Point(97, 117);
            this.date_nacimiento.Name = "date_nacimiento";
            this.date_nacimiento.Size = new System.Drawing.Size(180, 20);
            this.date_nacimiento.TabIndex = 74;
            this.date_nacimiento.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // cbox_nacionalidad
            // 
            this.cbox_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_nacionalidad.FormattingEnabled = true;
            this.cbox_nacionalidad.Location = new System.Drawing.Point(96, 90);
            this.cbox_nacionalidad.Name = "cbox_nacionalidad";
            this.cbox_nacionalidad.Size = new System.Drawing.Size(180, 21);
            this.cbox_nacionalidad.TabIndex = 75;
            // 
            // txt_dom_nro
            // 
            this.txt_dom_nro.Location = new System.Drawing.Point(96, 222);
            this.txt_dom_nro.Name = "txt_dom_nro";
            this.txt_dom_nro.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_nro.TabIndex = 77;
            this.txt_dom_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_dom_nro
            // 
            this.lbl_dom_nro.AutoSize = true;
            this.lbl_dom_nro.Location = new System.Drawing.Point(12, 225);
            this.lbl_dom_nro.Name = "lbl_dom_nro";
            this.lbl_dom_nro.Size = new System.Drawing.Size(44, 13);
            this.lbl_dom_nro.TabIndex = 76;
            this.lbl_dom_nro.Text = "Número";
            // 
            // txt_dom_piso
            // 
            this.txt_dom_piso.Location = new System.Drawing.Point(97, 248);
            this.txt_dom_piso.Name = "txt_dom_piso";
            this.txt_dom_piso.Size = new System.Drawing.Size(66, 20);
            this.txt_dom_piso.TabIndex = 79;
            // 
            // lbl_dom_piso
            // 
            this.lbl_dom_piso.AutoSize = true;
            this.lbl_dom_piso.Location = new System.Drawing.Point(13, 251);
            this.lbl_dom_piso.Name = "lbl_dom_piso";
            this.lbl_dom_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_dom_piso.TabIndex = 78;
            this.lbl_dom_piso.Text = "Piso";
            // 
            // txt_dom_dpto
            // 
            this.txt_dom_dpto.Location = new System.Drawing.Point(211, 248);
            this.txt_dom_dpto.Name = "txt_dom_dpto";
            this.txt_dom_dpto.Size = new System.Drawing.Size(66, 20);
            this.txt_dom_dpto.TabIndex = 81;
            // 
            // lbl_dom_dpto
            // 
            this.lbl_dom_dpto.AutoSize = true;
            this.lbl_dom_dpto.Location = new System.Drawing.Point(178, 251);
            this.lbl_dom_dpto.Name = "lbl_dom_dpto";
            this.lbl_dom_dpto.Size = new System.Drawing.Size(30, 13);
            this.lbl_dom_dpto.TabIndex = 80;
            this.lbl_dom_dpto.Text = "Dpto";
            // 
            // Cliente_Alta
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
            this.Controls.Add(this.cbox_nacionalidad);
            this.Controls.Add(this.date_nacimiento);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.lbl_Ciudad);
            this.Controls.Add(this.txt_dom_calle);
            this.Controls.Add(this.lbl_dom_calle);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_fecha_nac);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.cbox_tipodoc);
            this.Controls.Add(this.txt_nrodoc);
            this.Controls.Add(this.lbl_nro_doc);
            this.Controls.Add(this.lbl_tipo_doc);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Cliente_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.Cliente_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nrodoc;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private System.Windows.Forms.ComboBox cbox_tipodoc;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_dom_calle;
        private System.Windows.Forms.Label lbl_dom_calle;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.DateTimePicker date_nacimiento;
        public System.Windows.Forms.ComboBox cbox_nacionalidad;
        private System.Windows.Forms.TextBox txt_dom_nro;
        private System.Windows.Forms.Label lbl_dom_nro;
        private System.Windows.Forms.TextBox txt_dom_piso;
        private System.Windows.Forms.Label lbl_dom_piso;
        private System.Windows.Forms.TextBox txt_dom_dpto;
        private System.Windows.Forms.Label lbl_dom_dpto;
    }
}