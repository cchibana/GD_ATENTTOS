namespace FrbaHotel.ABM_de_Hotel
{
    partial class Hotel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_estrellas = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cbox_estrellas = new System.Windows.Forms.ComboBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(357, 321);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 5;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Location = new System.Drawing.Point(237, 321);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(75, 23);
            this.btn_modificacion.TabIndex = 4;
            this.btn_modificacion.Text = "Modificación";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.btn_modificacion_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(127, 321);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 3;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(46, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 88);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ciudad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "País";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Seleccionar";
            this.Column4.Name = "Column4";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(383, 133);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(277, 133);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.txt_nombre);
            this.gBox_filtros.Controls.Add(this.lbl_estrellas);
            this.gBox_filtros.Controls.Add(this.lbl_Nombre);
            this.gBox_filtros.Controls.Add(this.cbox_estrellas);
            this.gBox_filtros.Controls.Add(this.txt_ciudad);
            this.gBox_filtros.Controls.Add(this.txt_pais);
            this.gBox_filtros.Controls.Add(this.lbl_ciudad);
            this.gBox_filtros.Controls.Add(this.lbl_pais);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(30, 18);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(473, 109);
            this.gBox_filtros.TabIndex = 20;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // lbl_estrellas
            // 
            this.lbl_estrellas.AutoSize = true;
            this.lbl_estrellas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_estrellas.Location = new System.Drawing.Point(256, 21);
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
            this.cbox_estrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_estrellas.Location = new System.Drawing.Point(353, 18);
            this.cbox_estrellas.Name = "cbox_estrellas";
            this.cbox_estrellas.Size = new System.Drawing.Size(100, 21);
            this.cbox_estrellas.TabIndex = 13;
            this.cbox_estrellas.SelectedIndexChanged += new System.EventHandler(this.cbox_estrellas_SelectedIndexChanged);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(104, 45);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad.TabIndex = 7;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(104, 71);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
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
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modificacion);
            this.Controls.Add(this.btn_alta);
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoteles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBox_filtros.ResumeLayout(false);
            this.gBox_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.GroupBox gBox_filtros;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_estrellas;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ComboBox cbox_estrellas;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}