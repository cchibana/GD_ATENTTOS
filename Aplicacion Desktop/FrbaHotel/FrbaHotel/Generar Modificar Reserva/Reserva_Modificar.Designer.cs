namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NroReserva = new System.Windows.Forms.TextBox();
            this.gb_Reserva = new System.Windows.Forms.GroupBox();
            this.btn_BorrarHabitacion = new System.Windows.Forms.Button();
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
            this.dtp_FechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cb_Regimen = new System.Windows.Forms.ComboBox();
            this.cb_Hotel = new System.Windows.Forms.ComboBox();
            this.cb_Ciudad = new System.Windows.Forms.ComboBox();
            this.btn_VerDisponibilidad = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NroCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MailCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TipoIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.txt_NroIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_GuardarModificaciones = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_BuscarReserva = new System.Windows.Forms.Button();
            this.gb_Importes = new System.Windows.Forms.GroupBox();
            this.txt_CantNoches = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ImporteDia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_ImporteTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gb_Reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).BeginInit();
            this.gb_Cliente.SuspendLayout();
            this.gb_Importes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Reserva";
            // 
            // txt_NroReserva
            // 
            this.txt_NroReserva.Location = new System.Drawing.Point(144, 44);
            this.txt_NroReserva.Name = "txt_NroReserva";
            this.txt_NroReserva.Size = new System.Drawing.Size(155, 20);
            this.txt_NroReserva.TabIndex = 2;
            // 
            // gb_Reserva
            // 
            this.gb_Reserva.Controls.Add(this.btn_BorrarHabitacion);
            this.gb_Reserva.Controls.Add(this.dgv_HabitacionesReserva);
            this.gb_Reserva.Controls.Add(this.dtp_FechaEgreso);
            this.gb_Reserva.Controls.Add(this.dtp_FechaIngreso);
            this.gb_Reserva.Controls.Add(this.cb_Regimen);
            this.gb_Reserva.Controls.Add(this.cb_Hotel);
            this.gb_Reserva.Controls.Add(this.cb_Ciudad);
            this.gb_Reserva.Controls.Add(this.btn_VerDisponibilidad);
            this.gb_Reserva.Controls.Add(this.label13);
            this.gb_Reserva.Controls.Add(this.cb_TipoHabitacion);
            this.gb_Reserva.Controls.Add(this.label8);
            this.gb_Reserva.Controls.Add(this.label9);
            this.gb_Reserva.Controls.Add(this.label10);
            this.gb_Reserva.Controls.Add(this.label11);
            this.gb_Reserva.Controls.Add(this.label12);
            this.gb_Reserva.Location = new System.Drawing.Point(26, 221);
            this.gb_Reserva.Name = "gb_Reserva";
            this.gb_Reserva.Size = new System.Drawing.Size(1197, 321);
            this.gb_Reserva.TabIndex = 12;
            this.gb_Reserva.TabStop = false;
            this.gb_Reserva.Text = "Datos de la reserva";
            this.gb_Reserva.Visible = false;
            // 
            // btn_BorrarHabitacion
            // 
            this.btn_BorrarHabitacion.Location = new System.Drawing.Point(1051, 279);
            this.btn_BorrarHabitacion.Name = "btn_BorrarHabitacion";
            this.btn_BorrarHabitacion.Size = new System.Drawing.Size(126, 31);
            this.btn_BorrarHabitacion.TabIndex = 52;
            this.btn_BorrarHabitacion.Text = "Borrar Habitación";
            this.btn_BorrarHabitacion.UseVisualStyleBackColor = true;
            this.btn_BorrarHabitacion.Click += new System.EventHandler(this.btn_BorrarHabitacion_Click);
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
            this.dgv_HabitacionesReserva.Location = new System.Drawing.Point(24, 101);
            this.dgv_HabitacionesReserva.MultiSelect = false;
            this.dgv_HabitacionesReserva.Name = "dgv_HabitacionesReserva";
            this.dgv_HabitacionesReserva.ReadOnly = true;
            this.dgv_HabitacionesReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesReserva.Size = new System.Drawing.Size(1153, 172);
            this.dgv_HabitacionesReserva.TabIndex = 47;
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
            // dtp_FechaEgreso
            // 
            this.dtp_FechaEgreso.Location = new System.Drawing.Point(418, 58);
            this.dtp_FechaEgreso.Name = "dtp_FechaEgreso";
            this.dtp_FechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaEgreso.TabIndex = 46;
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(418, 32);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 45;
            // 
            // cb_Regimen
            // 
            this.cb_Regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Regimen.FormattingEnabled = true;
            this.cb_Regimen.Location = new System.Drawing.Point(768, 31);
            this.cb_Regimen.Name = "cb_Regimen";
            this.cb_Regimen.Size = new System.Drawing.Size(156, 21);
            this.cb_Regimen.TabIndex = 44;
            this.cb_Regimen.SelectedIndexChanged += new System.EventHandler(this.cb_Regimen_SelectedIndexChanged);
            // 
            // cb_Hotel
            // 
            this.cb_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hotel.FormattingEnabled = true;
            this.cb_Hotel.Location = new System.Drawing.Point(105, 58);
            this.cb_Hotel.Name = "cb_Hotel";
            this.cb_Hotel.Size = new System.Drawing.Size(156, 21);
            this.cb_Hotel.TabIndex = 43;
            this.cb_Hotel.SelectedIndexChanged += new System.EventHandler(this.cb_Hotel_SelectedIndexChanged);
            // 
            // cb_Ciudad
            // 
            this.cb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ciudad.FormattingEnabled = true;
            this.cb_Ciudad.Location = new System.Drawing.Point(105, 31);
            this.cb_Ciudad.Name = "cb_Ciudad";
            this.cb_Ciudad.Size = new System.Drawing.Size(156, 21);
            this.cb_Ciudad.TabIndex = 42;
            this.cb_Ciudad.SelectedIndexChanged += new System.EventHandler(this.cb_Ciudad_SelectedIndexChanged);
            // 
            // btn_VerDisponibilidad
            // 
            this.btn_VerDisponibilidad.Location = new System.Drawing.Point(981, 31);
            this.btn_VerDisponibilidad.Name = "btn_VerDisponibilidad";
            this.btn_VerDisponibilidad.Size = new System.Drawing.Size(188, 51);
            this.btn_VerDisponibilidad.TabIndex = 41;
            this.btn_VerDisponibilidad.Text = "Buscar Habitaciones Disponibles";
            this.btn_VerDisponibilidad.UseVisualStyleBackColor = true;
            this.btn_VerDisponibilidad.Click += new System.EventHandler(this.btn_VerDisponibilidad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(667, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Tipo de Habitación";
            // 
            // cb_TipoHabitacion
            // 
            this.cb_TipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoHabitacion.FormattingEnabled = true;
            this.cb_TipoHabitacion.Location = new System.Drawing.Point(768, 61);
            this.cb_TipoHabitacion.Name = "cb_TipoHabitacion";
            this.cb_TipoHabitacion.Size = new System.Drawing.Size(156, 21);
            this.cb_TipoHabitacion.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo de Régimen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de Egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hotel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ciudad";
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.txt_ApellidoCliente);
            this.gb_Cliente.Controls.Add(this.label4);
            this.gb_Cliente.Controls.Add(this.txt_NroCliente);
            this.gb_Cliente.Controls.Add(this.txt_NombreCliente);
            this.gb_Cliente.Controls.Add(this.label5);
            this.gb_Cliente.Controls.Add(this.label6);
            this.gb_Cliente.Controls.Add(this.txt_MailCliente);
            this.gb_Cliente.Controls.Add(this.label2);
            this.gb_Cliente.Controls.Add(this.txt_TipoIdentificacionCliente);
            this.gb_Cliente.Controls.Add(this.txt_NroIdentificacionCliente);
            this.gb_Cliente.Controls.Add(this.label3);
            this.gb_Cliente.Controls.Add(this.label7);
            this.gb_Cliente.Location = new System.Drawing.Point(26, 89);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(846, 126);
            this.gb_Cliente.TabIndex = 13;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Datos del Cliente";
            this.gb_Cliente.Visible = false;
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(174, 88);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.ReadOnly = true;
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_ApellidoCliente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido";
            // 
            // txt_NroCliente
            // 
            this.txt_NroCliente.Location = new System.Drawing.Point(174, 33);
            this.txt_NroCliente.Name = "txt_NroCliente";
            this.txt_NroCliente.ReadOnly = true;
            this.txt_NroCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroCliente.TabIndex = 15;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(174, 61);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.ReadOnly = true;
            this.txt_NombreCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NombreCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(25, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(25, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            // 
            // txt_MailCliente
            // 
            this.txt_MailCliente.Location = new System.Drawing.Point(559, 88);
            this.txt_MailCliente.Name = "txt_MailCliente";
            this.txt_MailCliente.ReadOnly = true;
            this.txt_MailCliente.Size = new System.Drawing.Size(248, 20);
            this.txt_MailCliente.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(410, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mail";
            // 
            // txt_TipoIdentificacionCliente
            // 
            this.txt_TipoIdentificacionCliente.Location = new System.Drawing.Point(559, 33);
            this.txt_TipoIdentificacionCliente.Name = "txt_TipoIdentificacionCliente";
            this.txt_TipoIdentificacionCliente.ReadOnly = true;
            this.txt_TipoIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoIdentificacionCliente.TabIndex = 9;
            // 
            // txt_NroIdentificacionCliente
            // 
            this.txt_NroIdentificacionCliente.Location = new System.Drawing.Point(559, 61);
            this.txt_NroIdentificacionCliente.Name = "txt_NroIdentificacionCliente";
            this.txt_NroIdentificacionCliente.ReadOnly = true;
            this.txt_NroIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroIdentificacionCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(410, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Identificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(410, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Número de Identificación";
            // 
            // btn_GuardarModificaciones
            // 
            this.btn_GuardarModificaciones.Location = new System.Drawing.Point(464, 548);
            this.btn_GuardarModificaciones.Name = "btn_GuardarModificaciones";
            this.btn_GuardarModificaciones.Size = new System.Drawing.Size(152, 46);
            this.btn_GuardarModificaciones.TabIndex = 47;
            this.btn_GuardarModificaciones.Text = "Guardar Modificaciones";
            this.btn_GuardarModificaciones.UseVisualStyleBackColor = true;
            this.btn_GuardarModificaciones.Click += new System.EventHandler(this.btn_GuardarModificaciones_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(640, 548);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(152, 46);
            this.btn_Cancelar.TabIndex = 48;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_BuscarReserva
            // 
            this.btn_BuscarReserva.Location = new System.Drawing.Point(305, 41);
            this.btn_BuscarReserva.Name = "btn_BuscarReserva";
            this.btn_BuscarReserva.Size = new System.Drawing.Size(118, 25);
            this.btn_BuscarReserva.TabIndex = 49;
            this.btn_BuscarReserva.Text = "Buscar Reserva";
            this.btn_BuscarReserva.UseVisualStyleBackColor = true;
            this.btn_BuscarReserva.Click += new System.EventHandler(this.btn_BuscarReserva_Click);
            // 
            // gb_Importes
            // 
            this.gb_Importes.Controls.Add(this.txt_CantNoches);
            this.gb_Importes.Controls.Add(this.label14);
            this.gb_Importes.Controls.Add(this.label15);
            this.gb_Importes.Controls.Add(this.txt_ImporteDia);
            this.gb_Importes.Controls.Add(this.label16);
            this.gb_Importes.Controls.Add(this.label17);
            this.gb_Importes.Controls.Add(this.txt_ImporteTotal);
            this.gb_Importes.Controls.Add(this.label18);
            this.gb_Importes.Location = new System.Drawing.Point(890, 50);
            this.gb_Importes.Name = "gb_Importes";
            this.gb_Importes.Size = new System.Drawing.Size(333, 165);
            this.gb_Importes.TabIndex = 50;
            this.gb_Importes.TabStop = false;
            this.gb_Importes.Text = "Importes";
            this.gb_Importes.Visible = false;
            // 
            // txt_CantNoches
            // 
            this.txt_CantNoches.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CantNoches.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantNoches.Location = new System.Drawing.Point(229, 45);
            this.txt_CantNoches.Name = "txt_CantNoches";
            this.txt_CantNoches.ReadOnly = true;
            this.txt_CantNoches.Size = new System.Drawing.Size(81, 29);
            this.txt_CantNoches.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(188, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cantidad de Noches";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "USD";
            // 
            // txt_ImporteDia
            // 
            this.txt_ImporteDia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ImporteDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImporteDia.Location = new System.Drawing.Point(60, 45);
            this.txt_ImporteDia.Name = "txt_ImporteDia";
            this.txt_ImporteDia.ReadOnly = true;
            this.txt_ImporteDia.Size = new System.Drawing.Size(100, 29);
            this.txt_ImporteDia.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Importe por día";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "USD";
            // 
            // txt_ImporteTotal
            // 
            this.txt_ImporteTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImporteTotal.Location = new System.Drawing.Point(61, 118);
            this.txt_ImporteTotal.Name = "txt_ImporteTotal";
            this.txt_ImporteTotal.ReadOnly = true;
            this.txt_ImporteTotal.Size = new System.Drawing.Size(249, 29);
            this.txt_ImporteTotal.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Importe Total";
            // 
            // Reserva_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 628);
            this.Controls.Add(this.gb_Importes);
            this.Controls.Add(this.btn_BuscarReserva);
            this.Controls.Add(this.btn_GuardarModificaciones);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.gb_Cliente);
            this.Controls.Add(this.gb_Reserva);
            this.Controls.Add(this.txt_NroReserva);
            this.Controls.Add(this.label1);
            this.Name = "Reserva_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Reserva";
            this.gb_Reserva.ResumeLayout(false);
            this.gb_Reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).EndInit();
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            this.gb_Importes.ResumeLayout(false);
            this.gb_Importes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NroReserva;
        private System.Windows.Forms.GroupBox gb_Reserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NroCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MailCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TipoIdentificacionCliente;
        private System.Windows.Forms.TextBox txt_NroIdentificacionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_FechaEgreso;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.ComboBox cb_Regimen;
        private System.Windows.Forms.ComboBox cb_Hotel;
        private System.Windows.Forms.ComboBox cb_Ciudad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_TipoHabitacion;
        private System.Windows.Forms.Button btn_VerDisponibilidad;
        private System.Windows.Forms.Button btn_GuardarModificaciones;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_BuscarReserva;
        private System.Windows.Forms.DataGridView dgv_HabitacionesReserva;
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
        private System.Windows.Forms.GroupBox gb_Importes;
        private System.Windows.Forms.TextBox txt_CantNoches;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ImporteDia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_ImporteTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_BorrarHabitacion;
    }
}