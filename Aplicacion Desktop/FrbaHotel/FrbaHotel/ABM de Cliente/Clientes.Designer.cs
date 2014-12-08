namespace FrbaHotel.ABM_de_Cliente
{
    partial class Clientes
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.cbox_tipodoc = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_Doc = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(369, 145);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 0;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(471, 145);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(314, 354);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta.TabIndex = 2;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Enabled = false;
            this.btn_Modificacion.Location = new System.Drawing.Point(414, 354);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(77, 23);
            this.btn_Modificacion.TabIndex = 3;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            this.btn_Modificacion.Click += new System.EventHandler(this.btn_Modificacion_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Enabled = false;
            this.btn_Baja.Location = new System.Drawing.Point(526, 354);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja.TabIndex = 4;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
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
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(173, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(104, 45);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(173, 20);
            this.txt_apellido.TabIndex = 7;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressAlfa);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(104, 71);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(173, 20);
            this.txt_mail.TabIndex = 8;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Apellido.Location = new System.Drawing.Point(7, 48);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 9;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_email.Location = new System.Drawing.Point(7, 74);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(34, 13);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "e-mail";
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(459, 45);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(130, 20);
            this.txt_nro_doc.TabIndex = 12;
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_nro_doc.Location = new System.Drawing.Point(362, 48);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(82, 13);
            this.lbl_nro_doc.TabIndex = 11;
            this.lbl_nro_doc.Text = "Nro Documento";
            // 
            // cbox_tipodoc
            // 
            this.cbox_tipodoc.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "Pasaporte"});
            this.cbox_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipodoc.FormattingEnabled = true;
            this.cbox_tipodoc.Location = new System.Drawing.Point(459, 18);
            this.cbox_tipodoc.Name = "cbox_tipodoc";
            this.cbox_tipodoc.Size = new System.Drawing.Size(130, 21);
            this.cbox_tipodoc.TabIndex = 13;
            // 
            // lbl_tipo_Doc
            // 
            this.lbl_tipo_Doc.AutoSize = true;
            this.lbl_tipo_Doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_tipo_Doc.Location = new System.Drawing.Point(362, 21);
            this.lbl_tipo_Doc.Name = "lbl_tipo_Doc";
            this.lbl_tipo_Doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_Doc.TabIndex = 14;
            this.lbl_tipo_Doc.Text = "Tipo Doc";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(22, 194);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(623, 110);
            this.dgv_clientes.TabIndex = 15;
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick);
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.txt_nombre);
            this.gBox_filtros.Controls.Add(this.lbl_tipo_Doc);
            this.gBox_filtros.Controls.Add(this.lbl_Nombre);
            this.gBox_filtros.Controls.Add(this.cbox_tipodoc);
            this.gBox_filtros.Controls.Add(this.txt_apellido);
            this.gBox_filtros.Controls.Add(this.txt_nro_doc);
            this.gBox_filtros.Controls.Add(this.txt_mail);
            this.gBox_filtros.Controls.Add(this.lbl_nro_doc);
            this.gBox_filtros.Controls.Add(this.lbl_Apellido);
            this.gBox_filtros.Controls.Add(this.lbl_email);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(12, 12);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(639, 115);
            this.gBox_filtros.TabIndex = 16;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 417);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.gBox_filtros.ResumeLayout(false);
            this.gBox_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificacion;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.ComboBox cbox_tipodoc;
        private System.Windows.Forms.Label lbl_tipo_Doc;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.GroupBox gBox_filtros;
    }
}