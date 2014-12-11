namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_Regimenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dgv_Regimenes = new System.Windows.Forms.DataGridView();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Regimenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(95, 214);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(118, 35);
            this.btn_Cerrar.TabIndex = 30;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv_Regimenes
            // 
            this.dgv_Regimenes.AllowUserToAddRows = false;
            this.dgv_Regimenes.AllowUserToDeleteRows = false;
            this.dgv_Regimenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Regimenes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Regimenes.Location = new System.Drawing.Point(26, 59);
            this.dgv_Regimenes.MultiSelect = false;
            this.dgv_Regimenes.Name = "dgv_Regimenes";
            this.dgv_Regimenes.ReadOnly = true;
            this.dgv_Regimenes.RowHeadersVisible = false;
            this.dgv_Regimenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Regimenes.Size = new System.Drawing.Size(255, 149);
            this.dgv_Regimenes.TabIndex = 29;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(23, 27);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(228, 17);
            this.lbl_nombreUsuario.TabIndex = 28;
            this.lbl_nombreUsuario.Text = "Regímenes del Hotel Seleccionado";
            // 
            // Reserva_Regimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 264);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_Regimenes);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Name = "Reserva_Regimenes";
            this.Text = "Reserva_Regimenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Regimenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_Regimenes;
        private System.Windows.Forms.Label lbl_nombreUsuario;
    }
}