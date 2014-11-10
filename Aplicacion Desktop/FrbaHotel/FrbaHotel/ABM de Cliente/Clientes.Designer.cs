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
            this.cbox_tipo_doc = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_Doc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBox_filtros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBox_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(259, 127);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 0;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(365, 127);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(100, 295);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta.TabIndex = 2;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(200, 295);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(77, 23);
            this.btn_Modificacion.TabIndex = 3;
            this.btn_Modificacion.Text = "Modificacion";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            this.btn_Modificacion.Click += new System.EventHandler(this.btn_Modificacion_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(312, 295);
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
            this.lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(104, 45);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 7;
            this.txt_apellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(104, 71);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 8;
            this.txt_mail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.lbl_Apellido.Click += new System.EventHandler(this.lbl_Apellido_Click);
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
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(353, 45);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(100, 20);
            this.txt_nro_doc.TabIndex = 12;
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_nro_doc.Location = new System.Drawing.Point(256, 48);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(82, 13);
            this.lbl_nro_doc.TabIndex = 11;
            this.lbl_nro_doc.Text = "Nro Documento";
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
            this.cbox_tipo_doc.Location = new System.Drawing.Point(353, 18);
            this.cbox_tipo_doc.Name = "cbox_tipo_doc";
            this.cbox_tipo_doc.Size = new System.Drawing.Size(100, 21);
            this.cbox_tipo_doc.TabIndex = 13;
            this.cbox_tipo_doc.SelectedIndexChanged += new System.EventHandler(this.cBox_tipo_doc_SelectedIndexChanged);
            // 
            // lbl_tipo_Doc
            // 
            this.lbl_tipo_Doc.AutoSize = true;
            this.lbl_tipo_Doc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_tipo_Doc.Location = new System.Drawing.Point(256, 21);
            this.lbl_tipo_Doc.Name = "lbl_tipo_Doc";
            this.lbl_tipo_Doc.Size = new System.Drawing.Size(51, 13);
            this.lbl_tipo_Doc.TabIndex = 14;
            this.lbl_tipo_Doc.Text = "Tipo Doc";
            this.lbl_tipo_Doc.Click += new System.EventHandler(this.lbl_tipo_Doc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(28, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 88);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // gBox_filtros
            // 
            this.gBox_filtros.Controls.Add(this.txt_nombre);
            this.gBox_filtros.Controls.Add(this.lbl_tipo_Doc);
            this.gBox_filtros.Controls.Add(this.lbl_Nombre);
            this.gBox_filtros.Controls.Add(this.cbox_tipo_doc);
            this.gBox_filtros.Controls.Add(this.txt_apellido);
            this.gBox_filtros.Controls.Add(this.txt_nro_doc);
            this.gBox_filtros.Controls.Add(this.txt_mail);
            this.gBox_filtros.Controls.Add(this.lbl_nro_doc);
            this.gBox_filtros.Controls.Add(this.lbl_Apellido);
            this.gBox_filtros.Controls.Add(this.lbl_email);
            this.gBox_filtros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBox_filtros.Location = new System.Drawing.Point(12, 12);
            this.gBox_filtros.Name = "gBox_filtros";
            this.gBox_filtros.Size = new System.Drawing.Size(473, 109);
            this.gBox_filtros.TabIndex = 16;
            this.gBox_filtros.TabStop = false;
            this.gBox_filtros.Text = "Filtros";
            this.gBox_filtros.Enter += new System.EventHandler(this.gBox_filtros_Enter);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.gBox_filtros);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cbox_tipo_doc;
        private System.Windows.Forms.Label lbl_tipo_Doc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gBox_filtros;
    }
}