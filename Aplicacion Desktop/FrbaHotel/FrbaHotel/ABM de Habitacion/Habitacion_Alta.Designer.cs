namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitacion_Alta
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.cbox_tipo_hab = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_ubicacion = new System.Windows.Forms.ComboBox();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.lbl_hotel = new System.Windows.Forms.Label();
            this.lbl_porcentual = new System.Windows.Forms.Label();
            this.txt_porcentual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(29, 87);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Location = new System.Drawing.Point(29, 129);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 1;
            this.lbl_piso.Text = "Piso";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Location = new System.Drawing.Point(29, 173);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 2;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(29, 218);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 3;
            this.lbl_tipo.Text = "Tipo";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(99, 84);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(180, 20);
            this.txt_numero.TabIndex = 4;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(99, 126);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(180, 20);
            this.txt_piso.TabIndex = 5;
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // cbox_tipo_hab
            // 
            this.cbox_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_hab.FormattingEnabled = true;
            this.cbox_tipo_hab.Location = new System.Drawing.Point(99, 215);
            this.cbox_tipo_hab.Name = "cbox_tipo_hab";
            this.cbox_tipo_hab.Size = new System.Drawing.Size(180, 21);
            this.cbox_tipo_hab.TabIndex = 7;
            this.cbox_tipo_hab.SelectedIndexChanged += new System.EventHandler(this.LlenarDescHab);
            this.cbox_tipo_hab.SelectedIndexChanged += new System.EventHandler(this.LlenarPorcentualHab);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(383, 360);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(502, 360);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbox_ubicacion
            // 
            this.cbox_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ubicacion.FormattingEnabled = true;
            this.cbox_ubicacion.Location = new System.Drawing.Point(99, 170);
            this.cbox_ubicacion.Name = "cbox_ubicacion";
            this.cbox_ubicacion.Size = new System.Drawing.Size(180, 21);
            this.cbox_ubicacion.TabIndex = 10;
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(432, 126);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(121, 21);
            this.cbox_estado.TabIndex = 11;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(386, 131);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 12;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(99, 257);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(180, 20);
            this.txt_descripcion.TabIndex = 13;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(29, 260);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_hotel
            // 
            this.txt_hotel.Enabled = false;
            this.txt_hotel.Location = new System.Drawing.Point(294, 27);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(94, 20);
            this.txt_hotel.TabIndex = 109;
            this.txt_hotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_hotel
            // 
            this.lbl_hotel.AutoSize = true;
            this.lbl_hotel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hotel.Location = new System.Drawing.Point(235, 30);
            this.lbl_hotel.Name = "lbl_hotel";
            this.lbl_hotel.Size = new System.Drawing.Size(32, 13);
            this.lbl_hotel.TabIndex = 108;
            this.lbl_hotel.Text = "Hotel";
            // 
            // lbl_porcentual
            // 
            this.lbl_porcentual.AutoSize = true;
            this.lbl_porcentual.Location = new System.Drawing.Point(29, 300);
            this.lbl_porcentual.Name = "lbl_porcentual";
            this.lbl_porcentual.Size = new System.Drawing.Size(58, 13);
            this.lbl_porcentual.TabIndex = 111;
            this.lbl_porcentual.Text = "Porcentual";
            // 
            // txt_porcentual
            // 
            this.txt_porcentual.Enabled = false;
            this.txt_porcentual.Location = new System.Drawing.Point(99, 297);
            this.txt_porcentual.Name = "txt_porcentual";
            this.txt_porcentual.Size = new System.Drawing.Size(180, 20);
            this.txt_porcentual.TabIndex = 110;
            // 
            // Habitacion_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.lbl_porcentual);
            this.Controls.Add(this.txt_porcentual);
            this.Controls.Add(this.txt_hotel);
            this.Controls.Add(this.lbl_hotel);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.cbox_ubicacion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cbox_tipo_hab);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_piso);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Habitacion_Alta";
            this.Text = "Alta Habitación";
            this.Load += new System.EventHandler(this.Habitacion_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.ComboBox cbox_tipo_hab;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbox_ubicacion;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.Label lbl_hotel;
        private System.Windows.Forms.Label lbl_porcentual;
        public System.Windows.Forms.TextBox txt_porcentual;
    }
}