namespace FrbaHotel.ABM_de_Hotel
{
    partial class Hoteles
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
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificacion = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.dgv_hoteles = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cbox_estrellas = new System.Windows.Forms.ComboBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoteles)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_baja
            // 
            this.btn_baja.Enabled = false;
            this.btn_baja.Location = new System.Drawing.Point(408, 353);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 5;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Enabled = false;
            this.btn_modificacion.Location = new System.Drawing.Point(288, 353);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(75, 23);
            this.btn_modificacion.TabIndex = 4;
            this.btn_modificacion.Text = "Modificación";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.btn_modificacion_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(178, 353);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 3;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // dgv_hoteles
            // 
            this.dgv_hoteles.AllowUserToAddRows = false;
            this.dgv_hoteles.AllowUserToDeleteRows = false;
            this.dgv_hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoteles.Location = new System.Drawing.Point(30, 182);
            this.dgv_hoteles.MultiSelect = false;
            this.dgv_hoteles.Name = "dgv_hoteles";
            this.dgv_hoteles.ReadOnly = true;
            this.dgv_hoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoteles.Size = new System.Drawing.Size(594, 130);
            this.dgv_hoteles.TabIndex = 19;
            this.dgv_hoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(358, 133);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(252, 133);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.txt_ciudad);
            this.gBox_filtros.Controls.Add(this.txt_nombre);
            this.gBox_filtros.Controls.Add(this.lbl_estrellas);
            this.gBox_filtros.Controls.Add(this.lbl_Nombre);
            this.gBox_filtros.Controls.Add(this.cbox_estrellas);
            this.gBox_filtros.Controls.Add(this.txt_pais);
            this.gBox_filtros.Controls.Add(this.lbl_ciudad);
            this.gBox_filtros.Controls.Add(this.lbl_pais);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(30, 18);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(600, 109);
            this.gBox_filtros.TabIndex = 20;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_estrellas.Location = new System.Drawing.Point(359, 22);
            this.lbl_estrellas.Name = "lbl_estrellas";
            this.lbl_estrellas.Size = new System.Drawing.Size(46, 13);
            this.lbl_estrellas.TabIndex = 14;
            this.lbl_estrellas.Text = "Estrellas";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Nombre.Location = new System.Drawing.Point(7, 22);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // cbox_estrellas
            // 
            this.cbox_estrellas.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte"});
            this.cbox_estrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estrellas.FormattingEnabled = true;
            this.cbox_estrellas.Location = new System.Drawing.Point(456, 19);
            this.cbox_estrellas.Name = "cbox_estrellas";
            this.cbox_estrellas.Size = new System.Drawing.Size(100, 21);
            this.cbox_estrellas.TabIndex = 13;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(104, 71);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(180, 20);
            this.txt_pais.TabIndex = 8;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_ciudad.Location = new System.Drawing.Point(7, 48);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 9;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_pais.Location = new System.Drawing.Point(7, 74);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(29, 13);
            this.lbl_pais.TabIndex = 10;
            this.lbl_pais.Text = "País";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(104, 45);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(180, 20);
            this.txt_ciudad.TabIndex = 15;
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.dgv_hoteles);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modificacion);
            this.Controls.Add(this.btn_alta);
            this.Name = "Hoteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoteles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoteles)).EndInit();
            this.gBox_filtros.ResumeLayout(false);
            this.gBox_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.DataGridView dgv_hoteles;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.GroupBox gBox_filtros;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ComboBox cbox_estrellas;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_ciudad;
    }
}