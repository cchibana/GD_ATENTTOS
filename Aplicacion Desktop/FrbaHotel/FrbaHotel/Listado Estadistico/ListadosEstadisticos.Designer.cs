namespace FrbaHotel.Listado_Estadistico
{
    partial class ListadosEstadisticos
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
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_anio = new System.Windows.Forms.ComboBox();
            this.cb_trimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nroListado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(569, 44);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(147, 36);
            this.btn_Consultar.TabIndex = 0;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año";
            // 
            // cb_anio
            // 
            this.cb_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_anio.FormattingEnabled = true;
            this.cb_anio.Location = new System.Drawing.Point(75, 35);
            this.cb_anio.Name = "cb_anio";
            this.cb_anio.Size = new System.Drawing.Size(121, 21);
            this.cb_anio.TabIndex = 2;
            // 
            // cb_trimestre
            // 
            this.cb_trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trimestre.FormattingEnabled = true;
            this.cb_trimestre.Location = new System.Drawing.Point(333, 35);
            this.cb_trimestre.Name = "cb_trimestre";
            this.cb_trimestre.Size = new System.Drawing.Size(179, 21);
            this.cb_trimestre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trimestre";
            // 
            // cb_nroListado
            // 
            this.cb_nroListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nroListado.FormattingEnabled = true;
            this.cb_nroListado.Location = new System.Drawing.Point(75, 82);
            this.cb_nroListado.Name = "cb_nroListado";
            this.cb_nroListado.Size = new System.Drawing.Size(437, 21);
            this.cb_nroListado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_anio);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.cb_nroListado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_trimestre);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 290);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(434, 477);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(147, 36);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // ListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 545);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadosEstadisticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados Estadísticos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_anio;
        private System.Windows.Forms.ComboBox cb_trimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nroListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}