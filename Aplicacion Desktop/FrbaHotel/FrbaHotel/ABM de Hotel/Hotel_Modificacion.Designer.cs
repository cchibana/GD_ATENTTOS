namespace FrbaHotel.ABM_de_Hotel
{
    partial class Hotel_Modificacion
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_fecha_creacion = new System.Windows.Forms.Label();
            this.cbox_estrellas = new System.Windows.Forms.ComboBox();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.date_creacion = new System.Windows.Forms.DateTimePicker();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_estrellas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_pais = new System.Windows.Forms.ComboBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbox_ciudad = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(429, 355);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 78;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(313, 355);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 77;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(368, 110);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 75;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_fecha_creacion
            // 
            this.lbl_fecha_creacion.AutoSize = true;
            this.lbl_fecha_creacion.Location = new System.Drawing.Point(17, 290);
            this.lbl_fecha_creacion.Name = "lbl_fecha_creacion";
            this.lbl_fecha_creacion.Size = new System.Drawing.Size(82, 13);
            this.lbl_fecha_creacion.TabIndex = 73;
            this.lbl_fecha_creacion.Text = "Fecha Creación";
            // 
            // cbox_estrellas
            // 
            this.cbox_estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estrellas.FormattingEnabled = true;
            this.cbox_estrellas.Location = new System.Drawing.Point(6, 18);
            this.cbox_estrellas.Name = "cbox_estrellas";
            this.cbox_estrellas.Size = new System.Drawing.Size(91, 21);
            this.cbox_estrellas.TabIndex = 67;
            this.cbox_estrellas.SelectedIndexChanged += new System.EventHandler(this.CambiarEstrellas);
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(368, 51);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(46, 13);
            this.lbl_estrellas.TabIndex = 66;
            this.lbl_estrellas.Text = "Estrellas";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(17, 238);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 65;
            this.lbl_pais.Text = "País";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(17, 180);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 63;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(119, 177);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.ReadOnly = true;
            this.txt_ciudad.Size = new System.Drawing.Size(104, 20);
            this.txt_ciudad.TabIndex = 62;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(17, 84);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 59;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(119, 81);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 58;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(17, 58);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 57;
            this.lbl_mail.Text = "Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(119, 55);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 56;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 55;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(119, 29);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 54;
            // 
            // date_creacion
            // 
            this.date_creacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_creacion.Location = new System.Drawing.Point(119, 287);
            this.date_creacion.Name = "date_creacion";
            this.date_creacion.Size = new System.Drawing.Size(180, 20);
            this.date_creacion.TabIndex = 79;
            this.date_creacion.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(6, 16);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(91, 21);
            this.cbox_estado.TabIndex = 80;
            this.cbox_estado.SelectedIndexChanged += new System.EventHandler(this.CambiarEstado);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(17, 136);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 84;
            this.lbl_numero.Text = "Número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(119, 133);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(180, 20);
            this.txt_numero.TabIndex = 83;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(17, 110);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_calle.TabIndex = 82;
            this.lbl_calle.Text = "Calle";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(119, 107);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(180, 20);
            this.txt_calle.TabIndex = 81;
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(429, 107);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(89, 20);
            this.txt_estado.TabIndex = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbox_estado);
            this.groupBox3.Location = new System.Drawing.Point(524, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 45);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar";
            // 
            // txt_estrellas
            // 
            this.txt_estrellas.Enabled = false;
            this.txt_estrellas.Location = new System.Drawing.Point(429, 48);
            this.txt_estrellas.Name = "txt_estrellas";
            this.txt_estrellas.Size = new System.Drawing.Size(89, 20);
            this.txt_estrellas.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_estrellas);
            this.groupBox1.Location = new System.Drawing.Point(524, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 45);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar";
            // 
            // cbox_pais
            // 
            this.cbox_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_pais.FormattingEnabled = true;
            this.cbox_pais.Location = new System.Drawing.Point(6, 18);
            this.cbox_pais.Name = "cbox_pais";
            this.cbox_pais.Size = new System.Drawing.Size(91, 21);
            this.cbox_pais.TabIndex = 104;
            this.cbox_pais.SelectedIndexChanged += new System.EventHandler(this.CambiarPais);
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(119, 238);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.ReadOnly = true;
            this.txt_pais.Size = new System.Drawing.Size(104, 20);
            this.txt_pais.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbox_pais);
            this.groupBox2.Location = new System.Drawing.Point(238, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 45);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbox_ciudad);
            this.groupBox4.Location = new System.Drawing.Point(238, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 45);
            this.groupBox4.TabIndex = 107;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar";
            // 
            // cbox_ciudad
            // 
            this.cbox_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ciudad.FormattingEnabled = true;
            this.cbox_ciudad.Location = new System.Drawing.Point(6, 18);
            this.cbox_ciudad.Name = "cbox_ciudad";
            this.cbox_ciudad.Size = new System.Drawing.Size(91, 21);
            this.cbox_ciudad.TabIndex = 104;
            this.cbox_ciudad.SelectedIndexChanged += new System.EventHandler(this.CambiarCiudad);
            // 
            // Hotel_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_estrellas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_calle);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.date_creacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_fecha_creacion);
            this.Controls.Add(this.lbl_estrellas);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Hotel_Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Hotel";
            this.Load += new System.EventHandler(this.Hotel_Modificacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_fecha_creacion;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_calle;
        public System.Windows.Forms.ComboBox cbox_estrellas;
        public System.Windows.Forms.TextBox txt_ciudad;
        public System.Windows.Forms.TextBox txt_telefono;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.DateTimePicker date_creacion;
        public System.Windows.Forms.ComboBox cbox_estado;
        public System.Windows.Forms.TextBox txt_numero;
        public System.Windows.Forms.TextBox txt_calle;
        public System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_estrellas;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbox_pais;
        public System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox cbox_ciudad;

    }
}