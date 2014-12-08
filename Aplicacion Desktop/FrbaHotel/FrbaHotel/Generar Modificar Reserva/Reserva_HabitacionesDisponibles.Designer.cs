namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_HabitacionesDisponibles
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
            this.btn_AgregarAReserva = new System.Windows.Forms.Button();
            this.dgv_HabitacionesDisponibles = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarAReserva
            // 
            this.btn_AgregarAReserva.Location = new System.Drawing.Point(427, 337);
            this.btn_AgregarAReserva.Name = "btn_AgregarAReserva";
            this.btn_AgregarAReserva.Size = new System.Drawing.Size(115, 38);
            this.btn_AgregarAReserva.TabIndex = 0;
            this.btn_AgregarAReserva.Text = "Agregar a Reserva";
            this.btn_AgregarAReserva.UseVisualStyleBackColor = true;
            this.btn_AgregarAReserva.Click += new System.EventHandler(this.btn_AgregarAReserva_Click);
            // 
            // dgv_HabitacionesDisponibles
            // 
            this.dgv_HabitacionesDisponibles.AllowUserToAddRows = false;
            this.dgv_HabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HabitacionesDisponibles.Location = new System.Drawing.Point(27, 43);
            this.dgv_HabitacionesDisponibles.MultiSelect = false;
            this.dgv_HabitacionesDisponibles.Name = "dgv_HabitacionesDisponibles";
            this.dgv_HabitacionesDisponibles.ReadOnly = true;
            this.dgv_HabitacionesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesDisponibles.Size = new System.Drawing.Size(1045, 288);
            this.dgv_HabitacionesDisponibles.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(571, 337);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(115, 38);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Reserva_HabitacionesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 418);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_HabitacionesDisponibles);
            this.Controls.Add(this.btn_AgregarAReserva);
            this.Name = "Reserva_HabitacionesDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitaciones Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarAReserva;
        private System.Windows.Forms.DataGridView dgv_HabitacionesDisponibles;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}