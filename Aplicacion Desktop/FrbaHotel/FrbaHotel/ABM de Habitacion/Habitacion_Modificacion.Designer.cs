﻿namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitacion_Modificacion
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
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.cbox_ubicacion = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cbox_tipo_hab = new System.Windows.Forms.ComboBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(32, 227);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 28;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(102, 224);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(180, 20);
            this.txt_descripcion.TabIndex = 27;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(426, 98);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 26;
            this.lbl_estado.Text = "Estado";
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.cbox_estado.Location = new System.Drawing.Point(472, 93);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(121, 21);
            this.cbox_estado.TabIndex = 25;
            // 
            // cbox_ubicacion
            // 
            this.cbox_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ubicacion.FormattingEnabled = true;
            this.cbox_ubicacion.Items.AddRange(new object[] {
            "Frente",
            "Contrafrente"});
            this.cbox_ubicacion.Location = new System.Drawing.Point(102, 137);
            this.cbox_ubicacion.Name = "cbox_ubicacion";
            this.cbox_ubicacion.Size = new System.Drawing.Size(180, 21);
            this.cbox_ubicacion.TabIndex = 24;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(304, 337);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(429, 337);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cbox_tipo_hab
            // 
            this.cbox_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_hab.FormattingEnabled = true;
            this.cbox_tipo_hab.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Doble Twin",
            "Triple",
            "Cuadruple"});
            this.cbox_tipo_hab.Location = new System.Drawing.Point(102, 182);
            this.cbox_tipo_hab.Name = "cbox_tipo_hab";
            this.cbox_tipo_hab.Size = new System.Drawing.Size(180, 21);
            this.cbox_tipo_hab.TabIndex = 21;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(102, 93);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.ReadOnly = true;
            this.txt_piso.Size = new System.Drawing.Size(180, 20);
            this.txt_piso.TabIndex = 20;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(102, 51);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(180, 20);
            this.txt_numero.TabIndex = 19;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(32, 185);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 18;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Location = new System.Drawing.Point(32, 140);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 17;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Location = new System.Drawing.Point(32, 96);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 16;
            this.lbl_piso.Text = "Piso";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(32, 54);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 15;
            this.lbl_numero.Text = "Número";
            // 
            // Habitacion_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.cbox_ubicacion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cbox_tipo_hab);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_piso);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Habitacion_Modificacion";
            this.Text = "Habitacion_Modificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_numero;
        public System.Windows.Forms.TextBox txt_descripcion;
        public System.Windows.Forms.ComboBox cbox_estado;
        public System.Windows.Forms.ComboBox cbox_ubicacion;
        public System.Windows.Forms.ComboBox cbox_tipo_hab;
        public System.Windows.Forms.TextBox txt_piso;
        public System.Windows.Forms.TextBox txt_numero;
    }
}