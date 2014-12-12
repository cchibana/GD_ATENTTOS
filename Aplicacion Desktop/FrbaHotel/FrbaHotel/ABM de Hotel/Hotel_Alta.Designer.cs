namespace FrbaHotel.ABM_de_Hotel
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
            this.cbox_estrellas = new System.Windows.Forms.ComboBox();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.date_creacion = new System.Windows.Forms.DateTimePicker();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.cbox_pais = new System.Windows.Forms.ComboBox();
            this.cbox_ciudad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(407, 118);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 50;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_fecha_creacion
            // 
            this.lbl_fecha_creacion.AutoSize = true;
            this.lbl_fecha_creacion.Location = new System.Drawing.Point(28, 246);
            this.lbl_fecha_creacion.Name = "lbl_fecha_creacion";
            this.lbl_fecha_creacion.Size = new System.Drawing.Size(82, 13);
            this.lbl_fecha_creacion.TabIndex = 48;
            this.lbl_fecha_creacion.Text = "Fecha Creación";
            // 
            // cbox_estrellas
            // 
            this.cbox_estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estrellas.FormattingEnabled = true;
            this.cbox_estrellas.Location = new System.Drawing.Point(479, 60);
            this.cbox_estrellas.Name = "cbox_estrellas";
            this.cbox_estrellas.Size = new System.Drawing.Size(138, 21);
            this.cbox_estrellas.TabIndex = 42;
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.Location = new System.Drawing.Point(407, 63);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(46, 13);
            this.lbl_estrellas.TabIndex = 41;
            this.lbl_estrellas.Text = "Estrellas";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(28, 219);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 40;
            this.lbl_pais.Text = "País";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(28, 193);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 38;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(28, 141);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_calle.TabIndex = 36;
            this.lbl_calle.Text = "Calle";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(130, 138);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(180, 20);
            this.txt_calle.TabIndex = 35;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(28, 115);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 34;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(130, 112);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 33;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(28, 89);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 32;
            this.lbl_mail.Text = "Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(130, 86);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 31;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(28, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 30;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(130, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 29;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(312, 348);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 52;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(428, 348);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // date_creacion
            // 
            this.date_creacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_creacion.Location = new System.Drawing.Point(130, 243);
            this.date_creacion.Name = "date_creacion";
            this.date_creacion.Size = new System.Drawing.Size(180, 20);
            this.date_creacion.TabIndex = 54;
            this.date_creacion.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbox_estado.Location = new System.Drawing.Point(479, 115);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(138, 21);
            this.cbox_estado.TabIndex = 73;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(28, 167);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 75;
            this.lbl_numero.Text = "Número";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(130, 164);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(180, 20);
            this.txt_numero.TabIndex = 74;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // cbox_pais
            // 
            this.cbox_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_pais.FormattingEnabled = true;
            this.cbox_pais.Location = new System.Drawing.Point(130, 216);
            this.cbox_pais.Name = "cbox_pais";
            this.cbox_pais.Size = new System.Drawing.Size(180, 21);
            this.cbox_pais.TabIndex = 76;
            // 
            // cbox_ciudad
            // 
            this.cbox_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ciudad.FormattingEnabled = true;
            this.cbox_ciudad.Location = new System.Drawing.Point(130, 190);
            this.cbox_ciudad.Name = "cbox_ciudad";
            this.cbox_ciudad.Size = new System.Drawing.Size(180, 21);
            this.cbox_ciudad.TabIndex = 77;
            // 
            // Hotel_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.cbox_ciudad);
            this.Controls.Add(this.cbox_pais);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.date_creacion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_fecha_creacion);
            this.Controls.Add(this.cbox_estrellas);
            this.Controls.Add(this.lbl_estrellas);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.lbl_calle);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Hotel_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Hotel";
            this.Load += new System.EventHandler(this.Hotel_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_fecha_creacion;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_numero;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_telefono;
        public System.Windows.Forms.ComboBox cbox_estrellas;
        public System.Windows.Forms.TextBox txt_calle;
        public System.Windows.Forms.DateTimePicker date_creacion;
        public System.Windows.Forms.ComboBox cbox_estado;
        public System.Windows.Forms.TextBox txt_numero;
        public System.Windows.Forms.ComboBox cbox_pais;
        public System.Windows.Forms.ComboBox cbox_ciudad;
    }
}