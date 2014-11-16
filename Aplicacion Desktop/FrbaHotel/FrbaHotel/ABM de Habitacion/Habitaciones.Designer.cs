namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitaciones
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
            this.dgv_habitacion = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cbox_tipo_hab = new System.Windows.Forms.ComboBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.cbox_ubicacion = new System.Windows.Forms.ComboBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificacion = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_habitacion
            // 
            this.dgv_habitacion.AllowUserToAddRows = false;
            this.dgv_habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitacion.Location = new System.Drawing.Point(43, 218);
            this.dgv_habitacion.Name = "dgv_habitacion";
            this.dgv_habitacion.Size = new System.Drawing.Size(437, 88);
            this.dgv_habitacion.TabIndex = 26;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(380, 177);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 25;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(274, 177);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 24;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.lbl_tipo);
            this.gBox_filtros.Controls.Add(this.cbox_tipo_hab);
            this.gBox_filtros.Controls.Add(this.txt_numero);
            this.gBox_filtros.Controls.Add(this.lbl_ubicacion);
            this.gBox_filtros.Controls.Add(this.lbl_numero);
            this.gBox_filtros.Controls.Add(this.cbox_ubicacion);
            this.gBox_filtros.Controls.Add(this.txt_piso);
            this.gBox_filtros.Controls.Add(this.txt_descripcion);
            this.gBox_filtros.Controls.Add(this.lbl_piso);
            this.gBox_filtros.Controls.Add(this.lbl_descripcion);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(27, 26);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(473, 134);
            this.gBox_filtros.TabIndex = 27;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_tipo.Location = new System.Drawing.Point(256, 48);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(80, 13);
            this.lbl_tipo.TabIndex = 38;
            this.lbl_tipo.Text = "Tipo habitación";
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
            this.cbox_tipo_hab.Location = new System.Drawing.Point(353, 45);
            this.cbox_tipo_hab.Name = "cbox_tipo_hab";
            this.cbox_tipo_hab.Size = new System.Drawing.Size(101, 21);
            this.cbox_tipo_hab.TabIndex = 37;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(104, 19);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 6;
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_ubicacion.Location = new System.Drawing.Point(256, 21);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 14;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_numero.Location = new System.Drawing.Point(7, 22);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "Número";
            // 
            // cbox_ubicacion
            // 
            this.cbox_ubicacion.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte"});
            this.cbox_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ubicacion.FormattingEnabled = true;
            this.cbox_ubicacion.Items.AddRange(new object[] {
            "Frente",
            "Contrafrente"});
            this.cbox_ubicacion.Location = new System.Drawing.Point(353, 18);
            this.cbox_ubicacion.Name = "cbox_ubicacion";
            this.cbox_ubicacion.Size = new System.Drawing.Size(100, 21);
            this.cbox_ubicacion.TabIndex = 13;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(104, 45);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(100, 20);
            this.txt_piso.TabIndex = 7;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(104, 71);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 8;
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_piso.Location = new System.Drawing.Point(7, 48);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 9;
            this.lbl_piso.Text = "Piso";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_descripcion.Location = new System.Drawing.Point(7, 75);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 10;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(346, 357);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 23;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Location = new System.Drawing.Point(226, 357);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(75, 23);
            this.btn_modificacion.TabIndex = 22;
            this.btn_modificacion.Text = "Modificación";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.btn_modificacion_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(116, 357);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 21;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 433);
            this.Controls.Add(this.dgv_habitacion);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modificacion);
            this.Controls.Add(this.btn_alta);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).EndInit();
            this.gBox_filtros.ResumeLayout(false);
            this.gBox_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_habitacion;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.GroupBox gBox_filtros;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.ComboBox cbox_ubicacion;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cbox_tipo_hab;
    }
}