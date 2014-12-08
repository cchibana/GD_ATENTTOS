namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_DatosFinales
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
            this.txt_MailCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NroIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TipoIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NroCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Habitaciones = new System.Windows.Forms.DataGridView();
            this.txt_FechaEgresoReserva = new System.Windows.Forms.TextBox();
            this.txt_TipoRegimenReserva = new System.Windows.Forms.TextBox();
            this.txt_FechaIngresoReserva = new System.Windows.Forms.TextBox();
            this.txt_CiudadReserva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_HotelReserva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MailCliente
            // 
            this.txt_MailCliente.Location = new System.Drawing.Point(601, 88);
            this.txt_MailCliente.Name = "txt_MailCliente";
            this.txt_MailCliente.ReadOnly = true;
            this.txt_MailCliente.Size = new System.Drawing.Size(248, 20);
            this.txt_MailCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(452, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de Identificación";
            // 
            // txt_NroIdentificacionCliente
            // 
            this.txt_NroIdentificacionCliente.Location = new System.Drawing.Point(601, 61);
            this.txt_NroIdentificacionCliente.Name = "txt_NroIdentificacionCliente";
            this.txt_NroIdentificacionCliente.ReadOnly = true;
            this.txt_NroIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroIdentificacionCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(452, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(452, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Identificación";
            // 
            // txt_TipoIdentificacionCliente
            // 
            this.txt_TipoIdentificacionCliente.Location = new System.Drawing.Point(601, 33);
            this.txt_TipoIdentificacionCliente.Name = "txt_TipoIdentificacionCliente";
            this.txt_TipoIdentificacionCliente.ReadOnly = true;
            this.txt_TipoIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoIdentificacionCliente.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ApellidoCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_NroCliente);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_MailCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TipoIdentificacionCliente);
            this.groupBox1.Controls.Add(this.txt_NroIdentificacionCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 136);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(194, 88);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.ReadOnly = true;
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_ApellidoCliente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(45, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido";
            // 
            // txt_NroCliente
            // 
            this.txt_NroCliente.Location = new System.Drawing.Point(194, 33);
            this.txt_NroCliente.Name = "txt_NroCliente";
            this.txt_NroCliente.ReadOnly = true;
            this.txt_NroCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroCliente.TabIndex = 15;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(194, 61);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.ReadOnly = true;
            this.txt_NombreCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NombreCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(45, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Habitaciones);
            this.groupBox2.Controls.Add(this.txt_FechaEgresoReserva);
            this.groupBox2.Controls.Add(this.txt_TipoRegimenReserva);
            this.groupBox2.Controls.Add(this.txt_FechaIngresoReserva);
            this.groupBox2.Controls.Add(this.txt_CiudadReserva);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_HotelReserva);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(25, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 358);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la reserva";
            // 
            // dgv_Habitaciones
            // 
            this.dgv_Habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Habitaciones.Location = new System.Drawing.Point(25, 132);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.Size = new System.Drawing.Size(850, 203);
            this.dgv_Habitaciones.TabIndex = 28;
            // 
            // txt_FechaEgresoReserva
            // 
            this.txt_FechaEgresoReserva.Location = new System.Drawing.Point(601, 60);
            this.txt_FechaEgresoReserva.Name = "txt_FechaEgresoReserva";
            this.txt_FechaEgresoReserva.ReadOnly = true;
            this.txt_FechaEgresoReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_FechaEgresoReserva.TabIndex = 27;
            // 
            // txt_TipoRegimenReserva
            // 
            this.txt_TipoRegimenReserva.Location = new System.Drawing.Point(194, 89);
            this.txt_TipoRegimenReserva.Name = "txt_TipoRegimenReserva";
            this.txt_TipoRegimenReserva.ReadOnly = true;
            this.txt_TipoRegimenReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoRegimenReserva.TabIndex = 25;
            // 
            // txt_FechaIngresoReserva
            // 
            this.txt_FechaIngresoReserva.Location = new System.Drawing.Point(601, 34);
            this.txt_FechaIngresoReserva.Name = "txt_FechaIngresoReserva";
            this.txt_FechaIngresoReserva.ReadOnly = true;
            this.txt_FechaIngresoReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_FechaIngresoReserva.TabIndex = 17;
            // 
            // txt_CiudadReserva
            // 
            this.txt_CiudadReserva.Location = new System.Drawing.Point(194, 37);
            this.txt_CiudadReserva.Name = "txt_CiudadReserva";
            this.txt_CiudadReserva.ReadOnly = true;
            this.txt_CiudadReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_CiudadReserva.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo de Régimen";
            // 
            // txt_HotelReserva
            // 
            this.txt_HotelReserva.Location = new System.Drawing.Point(194, 63);
            this.txt_HotelReserva.Name = "txt_HotelReserva";
            this.txt_HotelReserva.ReadOnly = true;
            this.txt_HotelReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_HotelReserva.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de Egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hotel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ciudad";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(377, 579);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(159, 33);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Reserva_DatosFinales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 636);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva_DatosFinales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NroIdentificacionCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TipoIdentificacionCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NroCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_Habitaciones;
        private System.Windows.Forms.TextBox txt_FechaEgresoReserva;
        private System.Windows.Forms.TextBox txt_TipoRegimenReserva;
        private System.Windows.Forms.TextBox txt_FechaIngresoReserva;
        private System.Windows.Forms.TextBox txt_CiudadReserva;
        private System.Windows.Forms.TextBox txt_HotelReserva;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}