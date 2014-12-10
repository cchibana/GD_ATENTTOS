namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitacion_Baja
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
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_tipohab = new System.Windows.Forms.TextBox();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.lbl_hotel = new System.Windows.Forms.Label();
            this.lbl_porcentual = new System.Windows.Forms.Label();
            this.txt_porcentual = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(43, 245);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 42;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(113, 242);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(180, 20);
            this.txt_descripcion.TabIndex = 41;
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Location = new System.Drawing.Point(15, 16);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(82, 21);
            this.cbox_estado.TabIndex = 39;
            this.cbox_estado.SelectedIndexChanged += new System.EventHandler(this.CambiarEstado);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(225, 341);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(354, 341);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(113, 111);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.ReadOnly = true;
            this.txt_piso.Size = new System.Drawing.Size(180, 20);
            this.txt_piso.TabIndex = 34;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(113, 69);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(180, 20);
            this.txt_numero.TabIndex = 33;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(43, 203);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 32;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Location = new System.Drawing.Point(43, 158);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 31;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Location = new System.Drawing.Point(43, 114);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 30;
            this.lbl_piso.Text = "Piso";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(43, 72);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Número";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(452, 129);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(89, 20);
            this.txt_estado.TabIndex = 103;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbox_estado);
            this.groupBox3.Location = new System.Drawing.Point(547, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 45);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Estado";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(113, 155);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.ReadOnly = true;
            this.txt_ubicacion.Size = new System.Drawing.Size(180, 20);
            this.txt_ubicacion.TabIndex = 104;
            // 
            // txt_tipohab
            // 
            this.txt_tipohab.Location = new System.Drawing.Point(113, 200);
            this.txt_tipohab.Name = "txt_tipohab";
            this.txt_tipohab.ReadOnly = true;
            this.txt_tipohab.Size = new System.Drawing.Size(180, 20);
            this.txt_tipohab.TabIndex = 105;
            // 
            // txt_hotel
            // 
            this.txt_hotel.Enabled = false;
            this.txt_hotel.Location = new System.Drawing.Point(309, 12);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.Size = new System.Drawing.Size(94, 20);
            this.txt_hotel.TabIndex = 107;
            this.txt_hotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_hotel
            // 
            this.lbl_hotel.AutoSize = true;
            this.lbl_hotel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hotel.Location = new System.Drawing.Point(250, 15);
            this.lbl_hotel.Name = "lbl_hotel";
            this.lbl_hotel.Size = new System.Drawing.Size(32, 13);
            this.lbl_hotel.TabIndex = 106;
            this.lbl_hotel.Text = "Hotel";
            // 
            // lbl_porcentual
            // 
            this.lbl_porcentual.AutoSize = true;
            this.lbl_porcentual.Location = new System.Drawing.Point(43, 289);
            this.lbl_porcentual.Name = "lbl_porcentual";
            this.lbl_porcentual.Size = new System.Drawing.Size(58, 13);
            this.lbl_porcentual.TabIndex = 109;
            this.lbl_porcentual.Text = "Porcentual";
            // 
            // txt_porcentual
            // 
            this.txt_porcentual.Location = new System.Drawing.Point(113, 286);
            this.txt_porcentual.Name = "txt_porcentual";
            this.txt_porcentual.ReadOnly = true;
            this.txt_porcentual.Size = new System.Drawing.Size(180, 20);
            this.txt_porcentual.TabIndex = 108;
            // 
            // Habitacion_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.lbl_porcentual);
            this.Controls.Add(this.txt_porcentual);
            this.Controls.Add(this.txt_hotel);
            this.Controls.Add(this.lbl_hotel);
            this.Controls.Add(this.txt_tipohab);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_piso);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Habitacion_Baja";
            this.Text = "Habitacion_Baja";
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_numero;
        public System.Windows.Forms.TextBox txt_numero;
        public System.Windows.Forms.TextBox txt_piso;
        public System.Windows.Forms.TextBox txt_descripcion;
        public System.Windows.Forms.ComboBox cbox_estado;
        public System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_ubicacion;
        public System.Windows.Forms.TextBox txt_tipohab;
        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.Label lbl_hotel;
        private System.Windows.Forms.Label lbl_porcentual;
        public System.Windows.Forms.TextBox txt_porcentual;
    }
}