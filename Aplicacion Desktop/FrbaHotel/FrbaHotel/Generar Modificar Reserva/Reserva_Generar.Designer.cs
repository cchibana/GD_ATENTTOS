namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_Generar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VerDisponibilidad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Regimen = new System.Windows.Forms.ComboBox();
            this.dtp_FechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Ciudad = new System.Windows.Forms.ComboBox();
            this.btn_DatosHotel = new System.Windows.Forms.Button();
            this.dgv_HabitacionesReserva = new System.Windows.Forms.DataGridView();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BorrarHabitacion = new System.Windows.Forms.Button();
            this.Hab_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Tipo_Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Hot_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hot_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_por_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_VerDisponibilidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_TipoHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_Regimen);
            this.groupBox1.Controls.Add(this.dtp_FechaEgreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_FechaIngreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Hotel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Ciudad);
            this.groupBox1.Controls.Add(this.btn_DatosHotel);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la reserva";
            // 
            // btn_VerDisponibilidad
            // 
            this.btn_VerDisponibilidad.Location = new System.Drawing.Point(272, 164);
            this.btn_VerDisponibilidad.Name = "btn_VerDisponibilidad";
            this.btn_VerDisponibilidad.Size = new System.Drawing.Size(126, 31);
            this.btn_VerDisponibilidad.TabIndex = 13;
            this.btn_VerDisponibilidad.Text = "Ver Disponibilidad";
            this.btn_VerDisponibilidad.UseVisualStyleBackColor = true;
            this.btn_VerDisponibilidad.Click += new System.EventHandler(this.btn_VerDisponibilidad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Habitación";
            // 
            // cb_TipoHabitacion
            // 
            this.cb_TipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoHabitacion.FormattingEnabled = true;
            this.cb_TipoHabitacion.Location = new System.Drawing.Point(456, 123);
            this.cb_TipoHabitacion.Name = "cb_TipoHabitacion";
            this.cb_TipoHabitacion.Size = new System.Drawing.Size(200, 21);
            this.cb_TipoHabitacion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Régimen";
            // 
            // cb_Regimen
            // 
            this.cb_Regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Regimen.FormattingEnabled = true;
            this.cb_Regimen.Location = new System.Drawing.Point(456, 99);
            this.cb_Regimen.Name = "cb_Regimen";
            this.cb_Regimen.Size = new System.Drawing.Size(200, 21);
            this.cb_Regimen.TabIndex = 9;
            // 
            // dtp_FechaEgreso
            // 
            this.dtp_FechaEgreso.Location = new System.Drawing.Point(118, 125);
            this.dtp_FechaEgreso.Name = "dtp_FechaEgreso";
            this.dtp_FechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaEgreso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Egreso";
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(118, 99);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotel";
            // 
            // cb_Hotel
            // 
            this.cb_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hotel.FormattingEnabled = true;
            this.cb_Hotel.Location = new System.Drawing.Point(118, 60);
            this.cb_Hotel.Name = "cb_Hotel";
            this.cb_Hotel.Size = new System.Drawing.Size(200, 21);
            this.cb_Hotel.TabIndex = 3;
            this.cb_Hotel.SelectedIndexChanged += new System.EventHandler(this.cb_Hotel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciudad";
            // 
            // cb_Ciudad
            // 
            this.cb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ciudad.FormattingEnabled = true;
            this.cb_Ciudad.Location = new System.Drawing.Point(118, 33);
            this.cb_Ciudad.Name = "cb_Ciudad";
            this.cb_Ciudad.Size = new System.Drawing.Size(200, 21);
            this.cb_Ciudad.TabIndex = 1;
            this.cb_Ciudad.SelectedIndexChanged += new System.EventHandler(this.cb_Ciudad_SelectedIndexChanged);
            // 
            // btn_DatosHotel
            // 
            this.btn_DatosHotel.Location = new System.Drawing.Point(324, 60);
            this.btn_DatosHotel.Name = "btn_DatosHotel";
            this.btn_DatosHotel.Size = new System.Drawing.Size(122, 23);
            this.btn_DatosHotel.TabIndex = 0;
            this.btn_DatosHotel.Text = "Datos del Hotel";
            this.btn_DatosHotel.UseVisualStyleBackColor = true;
            this.btn_DatosHotel.Click += new System.EventHandler(this.btn_DatosHotel_Click);
            // 
            // dgv_HabitacionesReserva
            // 
            this.dgv_HabitacionesReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HabitacionesReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hab_Numero,
            this.Hab_Descripcion,
            this.Hab_Piso,
            this.Hab_Ubicacion,
            this.Hab_Tipo_Habitacion,
            this.Hab_Hot_Codigo,
            this.Hot_Nombre,
            this.Reg_Codigo,
            this.Reg_Descripcion,
            this.Precio_por_dia});
            this.dgv_HabitacionesReserva.Location = new System.Drawing.Point(13, 260);
            this.dgv_HabitacionesReserva.MultiSelect = false;
            this.dgv_HabitacionesReserva.Name = "dgv_HabitacionesReserva";
            this.dgv_HabitacionesReserva.ReadOnly = true;
            this.dgv_HabitacionesReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesReserva.Size = new System.Drawing.Size(877, 227);
            this.dgv_HabitacionesReserva.TabIndex = 1;
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(359, 535);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(164, 43);
            this.btn_Continuar.TabIndex = 14;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_ConfirmarReserva_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(632, 493);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(126, 31);
            this.btn_LimpiarCampos.TabIndex = 14;
            this.btn_LimpiarCampos.Text = "Limpiar Campos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = true;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(697, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 210);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "$$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Importe Total";
            // 
            // btn_BorrarHabitacion
            // 
            this.btn_BorrarHabitacion.Location = new System.Drawing.Point(764, 493);
            this.btn_BorrarHabitacion.Name = "btn_BorrarHabitacion";
            this.btn_BorrarHabitacion.Size = new System.Drawing.Size(126, 31);
            this.btn_BorrarHabitacion.TabIndex = 16;
            this.btn_BorrarHabitacion.Text = "Borrar Habitación";
            this.btn_BorrarHabitacion.UseVisualStyleBackColor = true;
            this.btn_BorrarHabitacion.Click += new System.EventHandler(this.btn_BorrarHabitacion_Click);
            // 
            // Hab_Numero
            // 
            this.Hab_Numero.HeaderText = "Número de Habitación";
            this.Hab_Numero.Name = "Hab_Numero";
            this.Hab_Numero.ReadOnly = true;
            // 
            // Hab_Descripcion
            // 
            this.Hab_Descripcion.HeaderText = "Tipo de Habitación";
            this.Hab_Descripcion.Name = "Hab_Descripcion";
            this.Hab_Descripcion.ReadOnly = true;
            this.Hab_Descripcion.Width = 110;
            // 
            // Hab_Piso
            // 
            this.Hab_Piso.HeaderText = "Piso de Habitación";
            this.Hab_Piso.Name = "Hab_Piso";
            this.Hab_Piso.ReadOnly = true;
            // 
            // Hab_Ubicacion
            // 
            this.Hab_Ubicacion.HeaderText = "Ubicación";
            this.Hab_Ubicacion.Name = "Hab_Ubicacion";
            this.Hab_Ubicacion.ReadOnly = true;
            // 
            // Hab_Tipo_Habitacion
            // 
            this.Hab_Tipo_Habitacion.HeaderText = "CodigoTipoHabitacion";
            this.Hab_Tipo_Habitacion.Name = "Hab_Tipo_Habitacion";
            this.Hab_Tipo_Habitacion.ReadOnly = true;
            this.Hab_Tipo_Habitacion.Visible = false;
            // 
            // Hab_Hot_Codigo
            // 
            this.Hab_Hot_Codigo.HeaderText = "Código de Hotel";
            this.Hab_Hot_Codigo.Name = "Hab_Hot_Codigo";
            this.Hab_Hot_Codigo.ReadOnly = true;
            // 
            // Hot_Nombre
            // 
            this.Hot_Nombre.HeaderText = "Nombre de Hotel";
            this.Hot_Nombre.Name = "Hot_Nombre";
            this.Hot_Nombre.ReadOnly = true;
            // 
            // Reg_Codigo
            // 
            this.Reg_Codigo.HeaderText = "Tipo de Regimen (Código)";
            this.Reg_Codigo.Name = "Reg_Codigo";
            this.Reg_Codigo.ReadOnly = true;
            this.Reg_Codigo.Visible = false;
            // 
            // Reg_Descripcion
            // 
            this.Reg_Descripcion.HeaderText = "Descripción del Régimen";
            this.Reg_Descripcion.Name = "Reg_Descripcion";
            this.Reg_Descripcion.ReadOnly = true;
            this.Reg_Descripcion.Width = 123;
            // 
            // Precio_por_dia
            // 
            this.Precio_por_dia.HeaderText = "Precio por Día";
            this.Precio_por_dia.Name = "Precio_por_dia";
            this.Precio_por_dia.ReadOnly = true;
            // 
            // Reserva_Generar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 627);
            this.Controls.Add(this.btn_BorrarHabitacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_LimpiarCampos);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.dgv_HabitacionesReserva);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva_Generar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Ciudad;
        private System.Windows.Forms.Button btn_DatosHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TipoHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Regimen;
        private System.Windows.Forms.DateTimePicker dtp_FechaEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.Button btn_VerDisponibilidad;
        private System.Windows.Forms.DataGridView dgv_HabitacionesReserva;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Button btn_LimpiarCampos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BorrarHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Tipo_Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Hot_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hot_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_por_dia;
    }
}