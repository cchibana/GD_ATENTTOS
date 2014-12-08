namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_ClienteNuevo
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
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nrodoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_tipodoc = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox_pais = new System.Windows.Forms.ComboBox();
            this.txt_dom_dpto = new System.Windows.Forms.TextBox();
            this.lbl_dom_dpto = new System.Windows.Forms.Label();
            this.txt_dom_piso = new System.Windows.Forms.TextBox();
            this.lbl_dom_piso = new System.Windows.Forms.Label();
            this.txt_dom_nro = new System.Windows.Forms.TextBox();
            this.lbl_dom_nro = new System.Windows.Forms.Label();
            this.txt_dom_calle = new System.Windows.Forms.TextBox();
            this.lbl_dom_calle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(172, 73);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(180, 20);
            this.txt_apellido.TabIndex = 1;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(172, 46);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(172, 155);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mail";
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(172, 129);
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(180, 20);
            this.txt_nrodoc.TabIndex = 3;
            this.txt_nrodoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo de Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Número de Identificación";
            // 
            // cbox_tipodoc
            // 
            this.cbox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipodoc.FormattingEnabled = true;
            this.cbox_tipodoc.Location = new System.Drawing.Point(172, 101);
            this.cbox_tipodoc.Name = "cbox_tipodoc";
            this.cbox_tipodoc.Size = new System.Drawing.Size(180, 21);
            this.cbox_tipodoc.TabIndex = 2;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(172, 181);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(40, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(416, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "País";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(548, 124);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(180, 20);
            this.txt_ciudad.TabIndex = 10;
            this.txt_ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(416, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Ciudad";
            // 
            // cbox_pais
            // 
            this.cbox_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_pais.FormattingEnabled = true;
            this.cbox_pais.Location = new System.Drawing.Point(548, 150);
            this.cbox_pais.Name = "cbox_pais";
            this.cbox_pais.Size = new System.Drawing.Size(180, 21);
            this.cbox_pais.TabIndex = 11;
            // 
            // txt_dom_dpto
            // 
            this.txt_dom_dpto.Location = new System.Drawing.Point(662, 98);
            this.txt_dom_dpto.Name = "txt_dom_dpto";
            this.txt_dom_dpto.Size = new System.Drawing.Size(66, 20);
            this.txt_dom_dpto.TabIndex = 9;
            // 
            // lbl_dom_dpto
            // 
            this.lbl_dom_dpto.AutoSize = true;
            this.lbl_dom_dpto.Location = new System.Drawing.Point(629, 101);
            this.lbl_dom_dpto.Name = "lbl_dom_dpto";
            this.lbl_dom_dpto.Size = new System.Drawing.Size(30, 13);
            this.lbl_dom_dpto.TabIndex = 88;
            this.lbl_dom_dpto.Text = "Dpto";
            // 
            // txt_dom_piso
            // 
            this.txt_dom_piso.Location = new System.Drawing.Point(548, 98);
            this.txt_dom_piso.Name = "txt_dom_piso";
            this.txt_dom_piso.Size = new System.Drawing.Size(67, 20);
            this.txt_dom_piso.TabIndex = 8;
            this.txt_dom_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_dom_piso
            // 
            this.lbl_dom_piso.AutoSize = true;
            this.lbl_dom_piso.Location = new System.Drawing.Point(418, 101);
            this.lbl_dom_piso.Name = "lbl_dom_piso";
            this.lbl_dom_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_dom_piso.TabIndex = 86;
            this.lbl_dom_piso.Text = "Piso";
            // 
            // txt_dom_nro
            // 
            this.txt_dom_nro.Location = new System.Drawing.Point(548, 72);
            this.txt_dom_nro.Name = "txt_dom_nro";
            this.txt_dom_nro.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_nro.TabIndex = 7;
            this.txt_dom_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_dom_nro
            // 
            this.lbl_dom_nro.AutoSize = true;
            this.lbl_dom_nro.Location = new System.Drawing.Point(417, 75);
            this.lbl_dom_nro.Name = "lbl_dom_nro";
            this.lbl_dom_nro.Size = new System.Drawing.Size(44, 13);
            this.lbl_dom_nro.TabIndex = 84;
            this.lbl_dom_nro.Text = "Número";
            // 
            // txt_dom_calle
            // 
            this.txt_dom_calle.Location = new System.Drawing.Point(548, 46);
            this.txt_dom_calle.Name = "txt_dom_calle";
            this.txt_dom_calle.Size = new System.Drawing.Size(180, 20);
            this.txt_dom_calle.TabIndex = 6;
            // 
            // lbl_dom_calle
            // 
            this.lbl_dom_calle.AutoSize = true;
            this.lbl_dom_calle.Location = new System.Drawing.Point(416, 49);
            this.lbl_dom_calle.Name = "lbl_dom_calle";
            this.lbl_dom_calle.Size = new System.Drawing.Size(81, 13);
            this.lbl_dom_calle.TabIndex = 82;
            this.lbl_dom_calle.Text = "Domicilio - Calle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ciudad);
            this.groupBox1.Controls.Add(this.txt_dom_dpto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_dom_dpto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_dom_piso);
            this.groupBox1.Controls.Add(this.txt_nrodoc);
            this.groupBox1.Controls.Add(this.lbl_dom_piso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dom_nro);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.lbl_dom_nro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_dom_calle);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_dom_calle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbox_pais);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbox_tipodoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Location = new System.Drawing.Point(43, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(443, 308);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(159, 33);
            this.btn_Cancelar.TabIndex = 92;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(250, 308);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(159, 33);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Reserva_ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 385);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva_ClienteNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva: Datos del nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nrodoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_tipodoc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbox_pais;
        private System.Windows.Forms.TextBox txt_dom_dpto;
        private System.Windows.Forms.Label lbl_dom_dpto;
        private System.Windows.Forms.TextBox txt_dom_piso;
        private System.Windows.Forms.Label lbl_dom_piso;
        private System.Windows.Forms.TextBox txt_dom_nro;
        private System.Windows.Forms.Label lbl_dom_nro;
        private System.Windows.Forms.TextBox txt_dom_calle;
        private System.Windows.Forms.Label lbl_dom_calle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
    }
}