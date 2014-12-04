namespace FrbaHotel.ABM_de_Usuario
{
    partial class TodasLosRolesyHotelesDeUnUsuario
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
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_estadoUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(154, 29);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(131, 17);
            this.lbl_nombreUsuario.TabIndex = 7;
            this.lbl_nombreUsuario.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_usuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.Location = new System.Drawing.Point(25, 109);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(274, 248);
            this.dgv_usuarios.TabIndex = 23;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(115, 390);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(105, 35);
            this.btn_Cerrar.TabIndex = 24;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_estadoUsuario
            // 
            this.lbl_estadoUsuario.AutoSize = true;
            this.lbl_estadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoUsuario.Location = new System.Drawing.Point(154, 60);
            this.lbl_estadoUsuario.Name = "lbl_estadoUsuario";
            this.lbl_estadoUsuario.Size = new System.Drawing.Size(131, 17);
            this.lbl_estadoUsuario.TabIndex = 26;
            this.lbl_estadoUsuario.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado del Usuario";
            // 
            // TodasLosRolesyHotelesDeUnUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 437);
            this.Controls.Add(this.lbl_estadoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "TodasLosRolesyHotelesDeUnUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles y Hoteles del Usuario Seleccionado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lbl_estadoUsuario;
        private System.Windows.Forms.Label label3;
    }
}