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
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.txt_fechanac = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 16);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(13, 42);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(97, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(97, 39);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(325, 40);
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(100, 20);
            this.txt_nrodoc.TabIndex = 7;
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(241, 43);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(47, 13);
            this.lbl_nro_doc.TabIndex = 5;
            this.lbl_nro_doc.Text = "Nro Doc";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(241, 16);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_doc.TabIndex = 4;
            this.lbl_tipo_doc.Text = "Tipo Doc";
            // 
            // cbox_tipodoc
            // 
            this.cbox_tipodoc.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cbox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipodoc.FormattingEnabled = true;
            this.cbox_tipodoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cbox_tipodoc.Location = new System.Drawing.Point(325, 10);
            this.cbox_tipodoc.Name = "cbox_tipodoc";
            this.cbox_tipodoc.Size = new System.Drawing.Size(100, 21);
            this.cbox_tipodoc.TabIndex = 8;
            this.cbox_tipodoc.SelectedIndexChanged += new System.EventHandler(this.cbox_tipodoc_SelectedIndexChanged);
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Location = new System.Drawing.Point(13, 68);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lbl_nacionalidad.TabIndex = 9;
            this.lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(97, 65);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txt_nacionalidad.TabIndex = 10;
            // 
            // txt_fechanac
            // 
            this.txt_fechanac.Location = new System.Drawing.Point(97, 92);
            this.txt_fechanac.Name = "txt_fechanac";
            this.txt_fechanac.Size = new System.Drawing.Size(100, 20);
            this.txt_fechanac.TabIndex = 11;
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Location = new System.Drawing.Point(13, 95);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(60, 13);
            this.lbl_fecha_nac.TabIndex = 12;
            this.lbl_fecha_nac.Text = "Fecha Nac";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(97, 119);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 13;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(13, 122);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 14;
            this.lbl_mail.Text = "E-mail";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(13, 149);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 15;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(98, 146);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 16;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(97, 172);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 18;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(13, 175);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 17;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(97, 198);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(100, 20);
            this.txt_localidad.TabIndex = 20;
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Location = new System.Drawing.Point(13, 201);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(53, 13);
            this.lbl_localidad.TabIndex = 19;
            this.lbl_localidad.Text = "Localidad";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(97, 224);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
            this.txt_pais.TabIndex = 22;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(13, 227);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 21;
            this.lbl_pais.Text = "País";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(141, 293);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(260, 292);
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
            this.cbox_estado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbox_estado.Location = new System.Drawing.Point(325, 119);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(100, 21);
            this.cbox_estado.TabIndex = 72;
            this.cbox_estado.SelectedIndexChanged += new System.EventHandler(this.cbox_estado_SelectedIndexChanged);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(241, 122);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 71;
            this.lbl_estado.Text = "Estado";
            this.lbl_estado.Click += new System.EventHandler(this.lbl_estado_Click);
            // 
            // Cliente_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 366);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
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
            this.Controls.Add(this.txt_fechanac);
            this.Controls.Add(this.txt_nacionalidad);
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
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.TextBox txt_fechanac;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
    }
}