namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class LogReservas
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
            this.btn_BuscarReserva = new System.Windows.Forms.Button();
            this.txt_NroReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LogReservas = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarReserva
            // 
            this.btn_BuscarReserva.Location = new System.Drawing.Point(303, 44);
            this.btn_BuscarReserva.Name = "btn_BuscarReserva";
            this.btn_BuscarReserva.Size = new System.Drawing.Size(118, 25);
            this.btn_BuscarReserva.TabIndex = 55;
            this.btn_BuscarReserva.Text = "Buscar Reserva";
            this.btn_BuscarReserva.UseVisualStyleBackColor = true;
            this.btn_BuscarReserva.Click += new System.EventHandler(this.btn_BuscarReserva_Click);
            // 
            // txt_NroReserva
            // 
            this.txt_NroReserva.Location = new System.Drawing.Point(140, 46);
            this.txt_NroReserva.Name = "txt_NroReserva";
            this.txt_NroReserva.Size = new System.Drawing.Size(155, 20);
            this.txt_NroReserva.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Número de Reserva";
            // 
            // dgv_LogReservas
            // 
            this.dgv_LogReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogReservas.Location = new System.Drawing.Point(24, 91);
            this.dgv_LogReservas.Name = "dgv_LogReservas";
            this.dgv_LogReservas.Size = new System.Drawing.Size(785, 279);
            this.dgv_LogReservas.TabIndex = 56;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(359, 376);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(118, 35);
            this.btn_Cerrar.TabIndex = 57;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // LogReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_LogReservas);
            this.Controls.Add(this.btn_BuscarReserva);
            this.Controls.Add(this.txt_NroReserva);
            this.Controls.Add(this.label1);
            this.Name = "LogReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarReserva;
        private System.Windows.Forms.TextBox txt_NroReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_LogReservas;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}