﻿namespace FrbaHotel.ABM_de_Hotel
{
    partial class Hotel_Alta
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
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_fecha_creacion = new System.Windows.Forms.Label();
            this.chkBox_desayuno = new System.Windows.Forms.CheckBox();
            this.chkBox_media_pens = new System.Windows.Forms.CheckBox();
            this.chkBox_all_incl = new System.Windows.Forms.CheckBox();
            this.cbox_estrellas = new System.Windows.Forms.ComboBox();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gBox_regimenes = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(296, 194);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 50;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_fecha_creacion
            // 
            this.lbl_fecha_creacion.AutoSize = true;
            this.lbl_fecha_creacion.Location = new System.Drawing.Point(21, 221);
            this.lbl_fecha_creacion.Name = "lbl_fecha_creacion";
            this.lbl_fecha_creacion.Size = new System.Drawing.Size(82, 13);
            this.lbl_fecha_creacion.TabIndex = 48;
            this.lbl_fecha_creacion.Text = "Fecha Creación";
            // 
            // chkBox_desayuno
            // 
            this.chkBox_desayuno.AutoSize = true;
            this.chkBox_desayuno.Location = new System.Drawing.Point(322, 86);
            this.chkBox_desayuno.Name = "chkBox_desayuno";
            this.chkBox_desayuno.Size = new System.Drawing.Size(74, 17);
            this.chkBox_desayuno.TabIndex = 45;
            this.chkBox_desayuno.Text = "Desayuno";
            this.chkBox_desayuno.UseVisualStyleBackColor = true;
            // 
            // chkBox_media_pens
            // 
            this.chkBox_media_pens.AutoSize = true;
            this.chkBox_media_pens.Location = new System.Drawing.Point(322, 64);
            this.chkBox_media_pens.Name = "chkBox_media_pens";
            this.chkBox_media_pens.Size = new System.Drawing.Size(96, 17);
            this.chkBox_media_pens.TabIndex = 44;
            this.chkBox_media_pens.Text = "Media Pensión";
            this.chkBox_media_pens.UseVisualStyleBackColor = true;
            // 
            // chkBox_all_incl
            // 
            this.chkBox_all_incl.AutoSize = true;
            this.chkBox_all_incl.Location = new System.Drawing.Point(322, 41);
            this.chkBox_all_incl.Name = "chkBox_all_incl";
            this.chkBox_all_incl.Size = new System.Drawing.Size(81, 17);
            this.chkBox_all_incl.TabIndex = 43;
            this.chkBox_all_incl.Text = "All inclusive";
            this.chkBox_all_incl.UseVisualStyleBackColor = true;
            // 
            // cbox_estrellas
            // 
            this.cbox_estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estrellas.FormattingEnabled = true;
            this.cbox_estrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_estrellas.Location = new System.Drawing.Point(123, 191);
            this.cbox_estrellas.Name = "cbox_estrellas";
            this.cbox_estrellas.Size = new System.Drawing.Size(100, 21);
            this.cbox_estrellas.TabIndex = 42;
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(21, 194);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(46, 13);
            this.lbl_estrellas.TabIndex = 41;
            this.lbl_estrellas.Text = "Estrellas";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(21, 168);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 40;
            this.lbl_pais.Text = "País";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(123, 165);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
            this.txt_pais.TabIndex = 39;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(21, 142);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 38;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(123, 139);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad.TabIndex = 37;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(21, 116);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 36;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(123, 113);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 35;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(21, 90);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 34;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(123, 87);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 33;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(21, 64);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 32;
            this.lbl_mail.Text = "Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(123, 61);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 31;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 30;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(123, 35);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 29;
            // 
            // gBox_regimenes
            // 
            this.gBox_regimenes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_regimenes.Location = new System.Drawing.Point(293, 18);
            this.gBox_regimenes.Name = "gBox_regimenes";
            this.gBox_regimenes.Size = new System.Drawing.Size(194, 137);
            this.gBox_regimenes.TabIndex = 46;
            this.gBox_regimenes.TabStop = false;
            this.gBox_regimenes.Text = "Regímenes";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(227, 281);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 52;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(343, 281);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbox_estado.Location = new System.Drawing.Point(368, 191);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(100, 21);
            this.cbox_estado.TabIndex = 73;
            // 
            // Hotel_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 340);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_fecha_creacion);
            this.Controls.Add(this.chkBox_desayuno);
            this.Controls.Add(this.chkBox_media_pens);
            this.Controls.Add(this.chkBox_all_incl);
            this.Controls.Add(this.cbox_estrellas);
            this.Controls.Add(this.lbl_estrellas);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.gBox_regimenes);
            this.Name = "Hotel_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_fecha_creacion;
        private System.Windows.Forms.CheckBox chkBox_desayuno;
        private System.Windows.Forms.CheckBox chkBox_media_pens;
        private System.Windows.Forms.CheckBox chkBox_all_incl;
        private System.Windows.Forms.ComboBox cbox_estrellas;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox gBox_regimenes;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbox_estado;
    }
}