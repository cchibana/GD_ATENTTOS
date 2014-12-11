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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RegHotel = new System.Windows.Forms.Button();
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
            this.Reg_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Tipo_Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hab_Hot_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hot_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_por_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantNoches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotalHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CantNoches = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ImporteDia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ImporteTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BorrarHabitacion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RegHotel);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la reserva";
            // 
            // btn_RegHotel
            // 
            this.btn_RegHotel.Location = new System.Drawing.Point(650, 59);
            this.btn_RegHotel.Name = "btn_RegHotel";
            this.btn_RegHotel.Size = new System.Drawing.Size(148, 23);
            this.btn_RegHotel.TabIndex = 15;
            this.btn_RegHotel.Text = "Ver Regímenes del hotel";
            this.btn_RegHotel.UseVisualStyleBackColor = true;
            this.btn_RegHotel.Click += new System.EventHandler(this.btn_RegHotel_Click);
            // 
            // btn_VerDisponibilidad
            // 
            this.btn_VerDisponibilidad.Location = new System.Drawing.Point(273, 163);
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
            this.label6.Location = new System.Drawing.Point(343, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Habitación";
            // 
            // cb_TipoHabitacion
            // 
            this.cb_TipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoHabitacion.FormattingEnabled = true;
            this.cb_TipoHabitacion.Location = new System.Drawing.Point(444, 87);
            this.cb_TipoHabitacion.Name = "cb_TipoHabitacion";
            this.cb_TipoHabitacion.Size = new System.Drawing.Size(200, 21);
            this.cb_TipoHabitacion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Régimen";
            // 
            // cb_Regimen
            // 
            this.cb_Regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Regimen.FormattingEnabled = true;
            this.cb_Regimen.Location = new System.Drawing.Point(444, 60);
            this.cb_Regimen.Name = "cb_Regimen";
            this.cb_Regimen.Size = new System.Drawing.Size(200, 21);
            this.cb_Regimen.TabIndex = 9;
            this.cb_Regimen.SelectedValueChanged += new System.EventHandler(this.cb_Regimen_SelectedIndexChanged);
            // 
            // dtp_FechaEgreso
            // 
            this.dtp_FechaEgreso.Location = new System.Drawing.Point(118, 85);
            this.dtp_FechaEgreso.Name = "dtp_FechaEgreso";
            this.dtp_FechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaEgreso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Egreso";
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(118, 59);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotel";
            // 
            // cb_Hotel
            // 
            this.cb_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hotel.FormattingEnabled = true;
            this.cb_Hotel.Location = new System.Drawing.Point(444, 30);
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
            this.cb_Ciudad.Location = new System.Drawing.Point(118, 29);
            this.cb_Ciudad.Name = "cb_Ciudad";
            this.cb_Ciudad.Size = new System.Drawing.Size(200, 21);
            this.cb_Ciudad.TabIndex = 1;
            this.cb_Ciudad.SelectedIndexChanged += new System.EventHandler(this.cb_Ciudad_SelectedIndexChanged);
            // 
            // btn_DatosHotel
            // 
            this.btn_DatosHotel.Location = new System.Drawing.Point(650, 29);
            this.btn_DatosHotel.Name = "btn_DatosHotel";
            this.btn_DatosHotel.Size = new System.Drawing.Size(148, 23);
            this.btn_DatosHotel.TabIndex = 0;
            this.btn_DatosHotel.Text = "Datos del Hotel";
            this.btn_DatosHotel.UseVisualStyleBackColor = true;
            this.btn_DatosHotel.Click += new System.EventHandler(this.btn_DatosHotel_Click);
            // 
            // dgv_HabitacionesReserva
            // 
            this.dgv_HabitacionesReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HabitacionesReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reg_Descripcion,
            this.Reg_Codigo,
            this.FechaInicio,
            this.FechaFin,
            this.Hab_Numero,
            this.Hab_Descripcion,
            this.Hab_Piso,
            this.Hab_Ubicacion,
            this.Hab_Tipo_Habitacion,
            this.Hab_Hot_Codigo,
            this.Hot_Nombre,
            this.Precio_por_dia,
            this.cantNoches,
            this.PrecioTotalHab});
            this.dgv_HabitacionesReserva.Location = new System.Drawing.Point(12, 268);
            this.dgv_HabitacionesReserva.MultiSelect = false;
            this.dgv_HabitacionesReserva.Name = "dgv_HabitacionesReserva";
            this.dgv_HabitacionesReserva.ReadOnly = true;
            this.dgv_HabitacionesReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesReserva.Size = new System.Drawing.Size(1153, 227);
            this.dgv_HabitacionesReserva.TabIndex = 1;
            // 
            // Reg_Descripcion
            // 
            this.Reg_Descripcion.HeaderText = "Descripción del Régimen";
            this.Reg_Descripcion.Name = "Reg_Descripcion";
            this.Reg_Descripcion.ReadOnly = true;
            this.Reg_Descripcion.Width = 110;
            // 
            // Reg_Codigo
            // 
            this.Reg_Codigo.HeaderText = "Tipo de Regimen (Código)";
            this.Reg_Codigo.Name = "Reg_Codigo";
            this.Reg_Codigo.ReadOnly = true;
            this.Reg_Codigo.Visible = false;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaInicio.HeaderText = "Fecha Inicio de Reserva";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaFin.HeaderText = "Fecha Fin de Reserva";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
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
            this.Hab_Hot_Codigo.Visible = false;
            // 
            // Hot_Nombre
            // 
            this.Hot_Nombre.HeaderText = "Nombre de Hotel";
            this.Hot_Nombre.Name = "Hot_Nombre";
            this.Hot_Nombre.ReadOnly = true;
            // 
            // Precio_por_dia
            // 
            this.Precio_por_dia.HeaderText = "Precio por Día";
            this.Precio_por_dia.Name = "Precio_por_dia";
            this.Precio_por_dia.ReadOnly = true;
            // 
            // cantNoches
            // 
            this.cantNoches.HeaderText = "Cantidad de Noches";
            this.cantNoches.Name = "cantNoches";
            this.cantNoches.ReadOnly = true;
            // 
            // PrecioTotalHab
            // 
            this.PrecioTotalHab.HeaderText = "Precio Total por Habitación";
            this.PrecioTotalHab.Name = "PrecioTotalHab";
            this.PrecioTotalHab.ReadOnly = true;
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(504, 542);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(164, 43);
            this.btn_Continuar.TabIndex = 14;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_ConfirmarReserva_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(907, 501);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(126, 31);
            this.btn_LimpiarCampos.TabIndex = 14;
            this.btn_LimpiarCampos.Text = "Limpiar Campos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = true;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CantNoches);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ImporteDia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_ImporteTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(822, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 210);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importes";
            // 
            // txt_CantNoches
            // 
            this.txt_CantNoches.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CantNoches.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantNoches.Location = new System.Drawing.Point(207, 54);
            this.txt_CantNoches.Name = "txt_CantNoches";
            this.txt_CantNoches.ReadOnly = true;
            this.txt_CantNoches.Size = new System.Drawing.Size(119, 29);
            this.txt_CantNoches.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(204, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cantidad de Noches";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "USD";
            // 
            // txt_ImporteDia
            // 
            this.txt_ImporteDia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ImporteDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImporteDia.Location = new System.Drawing.Point(56, 54);
            this.txt_ImporteDia.Name = "txt_ImporteDia";
            this.txt_ImporteDia.ReadOnly = true;
            this.txt_ImporteDia.Size = new System.Drawing.Size(100, 29);
            this.txt_ImporteDia.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Importe por día";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "USD";
            // 
            // txt_ImporteTotal
            // 
            this.txt_ImporteTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImporteTotal.Location = new System.Drawing.Point(57, 157);
            this.txt_ImporteTotal.Name = "txt_ImporteTotal";
            this.txt_ImporteTotal.ReadOnly = true;
            this.txt_ImporteTotal.Size = new System.Drawing.Size(269, 29);
            this.txt_ImporteTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Importe Total";
            // 
            // btn_BorrarHabitacion
            // 
            this.btn_BorrarHabitacion.Location = new System.Drawing.Point(1039, 501);
            this.btn_BorrarHabitacion.Name = "btn_BorrarHabitacion";
            this.btn_BorrarHabitacion.Size = new System.Drawing.Size(126, 31);
            this.btn_BorrarHabitacion.TabIndex = 16;
            this.btn_BorrarHabitacion.Text = "Borrar Habitación";
            this.btn_BorrarHabitacion.UseVisualStyleBackColor = true;
            this.btn_BorrarHabitacion.Click += new System.EventHandler(this.btn_BorrarHabitacion_Click);
            // 
            // Reserva_Generar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 627);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BorrarHabitacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ImporteTotal;
        private System.Windows.Forms.TextBox txt_CantNoches;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ImporteDia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Tipo_Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hab_Hot_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hot_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_por_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantNoches;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotalHab;
        private System.Windows.Forms.Button btn_RegHotel;
    }
}