namespace FrbaHotel.ABM_de_Usuario
{
    partial class Usuarios
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_tipo_Doc = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cbox_tipo_doc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(38, 186);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(443, 125);
            this.dgv_clientes.TabIndex = 22;
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(330, 328);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(91, 31);
            this.btn_Baja.TabIndex = 21;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(219, 328);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(93, 31);
            this.btn_Modificacion.TabIndex = 20;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            this.btn_Modificacion.Click += new System.EventHandler(this.btn_Modificacion_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(109, 328);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(91, 31);
            this.btn_Alta.TabIndex = 19;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(392, 132);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(89, 27);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(286, 132);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(89, 27);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.txt_nombre);
            this.gBox_filtros.Controls.Add(this.lbl_tipo_Doc);
            this.gBox_filtros.Controls.Add(this.lbl_Nombre);
            this.gBox_filtros.Controls.Add(this.cbox_tipo_doc);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(38, 21);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(441, 102);
            this.gBox_filtros.TabIndex = 23;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(146, 30);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // lbl_tipo_Doc
            // 
            this.lbl_tipo_Doc.AutoSize = true;
            this.lbl_tipo_Doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_tipo_Doc.Location = new System.Drawing.Point(26, 66);
            this.lbl_tipo_Doc.Name = "lbl_tipo_Doc";
            this.lbl_tipo_Doc.Size = new System.Drawing.Size(96, 13);
            this.lbl_tipo_Doc.TabIndex = 14;
            this.lbl_tipo_Doc.Text = "Estado del Usuario";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Nombre.Location = new System.Drawing.Point(26, 30);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(98, 13);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre de Usuario";
            // 
            // cbox_tipo_doc
            // 
            this.cbox_tipo_doc.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte"});
            this.cbox_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_doc.FormattingEnabled = true;
            this.cbox_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cbox_tipo_doc.Location = new System.Drawing.Point(146, 63);
            this.cbox_tipo_doc.Name = "cbox_tipo_doc";
            this.cbox_tipo_doc.Size = new System.Drawing.Size(100, 21);
            this.cbox_tipo_doc.TabIndex = 13;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 370);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.gBox_filtros.ResumeLayout(false);
            this.gBox_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificacion;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.GroupBox gBox_filtros;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_tipo_Doc;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ComboBox cbox_tipo_doc;
    }
}