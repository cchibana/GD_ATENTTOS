namespace FrbaHotel.Registrar_Estadia
{
    partial class Estadia_checkIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_hotel = new System.Windows.Forms.TextBox();
            this.lbl_hotel = new System.Windows.Forms.Label();
            this.txt_NroReserva = new System.Windows.Forms.TextBox();
            this.lbl_reserva = new System.Windows.Forms.Label();
            this.btn_buscarReserva = new System.Windows.Forms.Button();
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_NroCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_nroCliente = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_MailCliente = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_TipoIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.txt_NroIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.lbl_tipoIdentif = new System.Windows.Forms.Label();
            this.lbl_nroIdentif = new System.Windows.Forms.Label();
            this.gb_Reserva = new System.Windows.Forms.GroupBox();
            this.txt_tipoHab = new System.Windows.Forms.TextBox();
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
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_FechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaEgreso = new System.Windows.Forms.Label();
            this.lbl_fechaIngreso = new System.Windows.Forms.Label();
            this.gb_Estadia = new System.Windows.Forms.GroupBox();
            this.txt_CantNoches = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.btn_checkIn = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_regimen = new System.Windows.Forms.TextBox();
            this.gb_Cliente.SuspendLayout();
            this.gb_Reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).BeginInit();
            this.gb_Estadia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_hotel
            // 
            this.txt_hotel.Enabled = false;
            this.txt_hotel.Location = new System.Drawing.Point(435, 12);
            this.txt_hotel.Name = "txt_hotel";
            this.txt_hotel.ReadOnly = true;
            this.txt_hotel.Size = new System.Drawing.Size(94, 20);
            this.txt_hotel.TabIndex = 105;
            this.txt_hotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_hotel
            // 
            this.lbl_hotel.AutoSize = true;
            this.lbl_hotel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hotel.Location = new System.Drawing.Point(376, 15);
            this.lbl_hotel.Name = "lbl_hotel";
            this.lbl_hotel.Size = new System.Drawing.Size(32, 13);
            this.lbl_hotel.TabIndex = 104;
            this.lbl_hotel.Text = "Hotel";
            // 
            // txt_NroReserva
            // 
            this.txt_NroReserva.Location = new System.Drawing.Point(224, 56);
            this.txt_NroReserva.Name = "txt_NroReserva";
            this.txt_NroReserva.Size = new System.Drawing.Size(167, 20);
            this.txt_NroReserva.TabIndex = 107;
            // 
            // lbl_reserva
            // 
            this.lbl_reserva.AutoSize = true;
            this.lbl_reserva.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_reserva.Location = new System.Drawing.Point(111, 59);
            this.lbl_reserva.Name = "lbl_reserva";
            this.lbl_reserva.Size = new System.Drawing.Size(102, 13);
            this.lbl_reserva.TabIndex = 106;
            this.lbl_reserva.Text = "Número de Reserva";
            // 
            // btn_buscarReserva
            // 
            this.btn_buscarReserva.Location = new System.Drawing.Point(407, 50);
            this.btn_buscarReserva.Name = "btn_buscarReserva";
            this.btn_buscarReserva.Size = new System.Drawing.Size(84, 31);
            this.btn_buscarReserva.TabIndex = 108;
            this.btn_buscarReserva.Text = "Buscar";
            this.btn_buscarReserva.UseVisualStyleBackColor = true;
            this.btn_buscarReserva.Click += new System.EventHandler(this.btn_BuscarReserva_Click);
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.txt_ApellidoCliente);
            this.gb_Cliente.Controls.Add(this.lbl_apellido);
            this.gb_Cliente.Controls.Add(this.txt_NroCliente);
            this.gb_Cliente.Controls.Add(this.txt_NombreCliente);
            this.gb_Cliente.Controls.Add(this.lbl_nroCliente);
            this.gb_Cliente.Controls.Add(this.lbl_nombre);
            this.gb_Cliente.Controls.Add(this.txt_MailCliente);
            this.gb_Cliente.Controls.Add(this.lbl_mail);
            this.gb_Cliente.Controls.Add(this.txt_TipoIdentificacionCliente);
            this.gb_Cliente.Controls.Add(this.txt_NroIdentificacionCliente);
            this.gb_Cliente.Controls.Add(this.lbl_tipoIdentif);
            this.gb_Cliente.Controls.Add(this.lbl_nroIdentif);
            this.gb_Cliente.Location = new System.Drawing.Point(12, 101);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(812, 119);
            this.gb_Cliente.TabIndex = 110;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Datos del Cliente";
            this.gb_Cliente.Visible = false;
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(164, 81);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.ReadOnly = true;
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_ApellidoCliente.TabIndex = 13;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Location = new System.Drawing.Point(15, 84);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 12;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_NroCliente
            // 
            this.txt_NroCliente.Location = new System.Drawing.Point(164, 26);
            this.txt_NroCliente.Name = "txt_NroCliente";
            this.txt_NroCliente.ReadOnly = true;
            this.txt_NroCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroCliente.TabIndex = 15;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(164, 54);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.ReadOnly = true;
            this.txt_NombreCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NombreCliente.TabIndex = 11;
            // 
            // lbl_nroCliente
            // 
            this.lbl_nroCliente.AutoSize = true;
            this.lbl_nroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroCliente.Location = new System.Drawing.Point(15, 29);
            this.lbl_nroCliente.Name = "lbl_nroCliente";
            this.lbl_nroCliente.Size = new System.Drawing.Size(94, 13);
            this.lbl_nroCliente.TabIndex = 14;
            this.lbl_nroCliente.Text = "Número de Cliente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Location = new System.Drawing.Point(15, 57);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_MailCliente
            // 
            this.txt_MailCliente.Location = new System.Drawing.Point(519, 81);
            this.txt_MailCliente.Name = "txt_MailCliente";
            this.txt_MailCliente.ReadOnly = true;
            this.txt_MailCliente.Size = new System.Drawing.Size(248, 20);
            this.txt_MailCliente.TabIndex = 7;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Location = new System.Drawing.Point(370, 84);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 6;
            this.lbl_mail.Text = "Mail";
            // 
            // txt_TipoIdentificacionCliente
            // 
            this.txt_TipoIdentificacionCliente.Location = new System.Drawing.Point(519, 26);
            this.txt_TipoIdentificacionCliente.Name = "txt_TipoIdentificacionCliente";
            this.txt_TipoIdentificacionCliente.ReadOnly = true;
            this.txt_TipoIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoIdentificacionCliente.TabIndex = 9;
            // 
            // txt_NroIdentificacionCliente
            // 
            this.txt_NroIdentificacionCliente.Location = new System.Drawing.Point(519, 54);
            this.txt_NroIdentificacionCliente.Name = "txt_NroIdentificacionCliente";
            this.txt_NroIdentificacionCliente.ReadOnly = true;
            this.txt_NroIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroIdentificacionCliente.TabIndex = 5;
            // 
            // lbl_tipoIdentif
            // 
            this.lbl_tipoIdentif.AutoSize = true;
            this.lbl_tipoIdentif.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoIdentif.Location = new System.Drawing.Point(370, 29);
            this.lbl_tipoIdentif.Name = "lbl_tipoIdentif";
            this.lbl_tipoIdentif.Size = new System.Drawing.Size(109, 13);
            this.lbl_tipoIdentif.TabIndex = 8;
            this.lbl_tipoIdentif.Text = "Tipo de Identificación";
            // 
            // lbl_nroIdentif
            // 
            this.lbl_nroIdentif.AutoSize = true;
            this.lbl_nroIdentif.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nroIdentif.Location = new System.Drawing.Point(370, 57);
            this.lbl_nroIdentif.Name = "lbl_nroIdentif";
            this.lbl_nroIdentif.Size = new System.Drawing.Size(125, 13);
            this.lbl_nroIdentif.TabIndex = 4;
            this.lbl_nroIdentif.Text = "Número de Identificación";
            // 
            // gb_Reserva
            // 
            this.gb_Reserva.Controls.Add(this.txt_regimen);
            this.gb_Reserva.Controls.Add(this.txt_tipoHab);
            this.gb_Reserva.Controls.Add(this.dgv_HabitacionesReserva);
            this.gb_Reserva.Controls.Add(this.btn_LimpiarCampos);
            this.gb_Reserva.Controls.Add(this.label13);
            this.gb_Reserva.Controls.Add(this.label8);
            this.gb_Reserva.Location = new System.Drawing.Point(12, 241);
            this.gb_Reserva.Name = "gb_Reserva";
            this.gb_Reserva.Size = new System.Drawing.Size(1197, 227);
            this.gb_Reserva.TabIndex = 111;
            this.gb_Reserva.TabStop = false;
            this.gb_Reserva.Text = "Datos de la reserva";
            this.gb_Reserva.Visible = false;
            // 
            // txt_tipoHab
            // 
            this.txt_tipoHab.Location = new System.Drawing.Point(124, 28);
            this.txt_tipoHab.Name = "txt_tipoHab";
            this.txt_tipoHab.ReadOnly = true;
            this.txt_tipoHab.Size = new System.Drawing.Size(156, 20);
            this.txt_tipoHab.TabIndex = 16;
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
            this.dgv_HabitacionesReserva.Location = new System.Drawing.Point(18, 74);
            this.dgv_HabitacionesReserva.MultiSelect = false;
            this.dgv_HabitacionesReserva.Name = "dgv_HabitacionesReserva";
            this.dgv_HabitacionesReserva.ReadOnly = true;
            this.dgv_HabitacionesReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesReserva.Size = new System.Drawing.Size(1153, 132);
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
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaInicio.HeaderText = "Fecha Inicio de Reserva";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle8;
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
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(919, 279);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(126, 31);
            this.btn_LimpiarCampos.TabIndex = 51;
            this.btn_LimpiarCampos.Text = "Limpiar Campos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Tipo de Habitación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo de Régimen";
            // 
            // dtp_FechaEgreso
            // 
            this.dtp_FechaEgreso.Location = new System.Drawing.Point(131, 60);
            this.dtp_FechaEgreso.Name = "dtp_FechaEgreso";
            this.dtp_FechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaEgreso.TabIndex = 46;
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(131, 28);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 45;
            // 
            // lbl_fechaEgreso
            // 
            this.lbl_fechaEgreso.AutoSize = true;
            this.lbl_fechaEgreso.Location = new System.Drawing.Point(16, 66);
            this.lbl_fechaEgreso.Name = "lbl_fechaEgreso";
            this.lbl_fechaEgreso.Size = new System.Drawing.Size(88, 13);
            this.lbl_fechaEgreso.TabIndex = 19;
            this.lbl_fechaEgreso.Text = "Fecha de Egreso";
            // 
            // lbl_fechaIngreso
            // 
            this.lbl_fechaIngreso.AutoSize = true;
            this.lbl_fechaIngreso.Location = new System.Drawing.Point(16, 34);
            this.lbl_fechaIngreso.Name = "lbl_fechaIngreso";
            this.lbl_fechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lbl_fechaIngreso.TabIndex = 17;
            this.lbl_fechaIngreso.Text = "Fecha de Ingreso";
            // 
            // gb_Estadia
            // 
            this.gb_Estadia.Controls.Add(this.dtp_FechaEgreso);
            this.gb_Estadia.Controls.Add(this.txt_CantNoches);
            this.gb_Estadia.Controls.Add(this.dtp_FechaIngreso);
            this.gb_Estadia.Controls.Add(this.lbl_dias);
            this.gb_Estadia.Controls.Add(this.lbl_fechaEgreso);
            this.gb_Estadia.Controls.Add(this.lbl_fechaIngreso);
            this.gb_Estadia.Location = new System.Drawing.Point(841, 74);
            this.gb_Estadia.Name = "gb_Estadia";
            this.gb_Estadia.Size = new System.Drawing.Size(348, 146);
            this.gb_Estadia.TabIndex = 112;
            this.gb_Estadia.TabStop = false;
            this.gb_Estadia.Text = "Estadía";
            this.gb_Estadia.Visible = false;
            // 
            // txt_CantNoches
            // 
            this.txt_CantNoches.Location = new System.Drawing.Point(131, 101);
            this.txt_CantNoches.Name = "txt_CantNoches";
            this.txt_CantNoches.ReadOnly = true;
            this.txt_CantNoches.Size = new System.Drawing.Size(139, 20);
            this.txt_CantNoches.TabIndex = 9;
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dias.Location = new System.Drawing.Point(16, 104);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(90, 13);
            this.lbl_dias.TabIndex = 8;
            this.lbl_dias.Text = "Cantidad de Días";
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.Location = new System.Drawing.Point(501, 505);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(122, 46);
            this.btn_checkIn.TabIndex = 113;
            this.btn_checkIn.Text = "Check In";
            this.btn_checkIn.UseVisualStyleBackColor = true;
            this.btn_checkIn.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(702, 505);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 39);
            this.btn_cancelar.TabIndex = 114;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(685, 12);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(139, 20);
            this.txt_usuario.TabIndex = 116;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_usuario.Location = new System.Drawing.Point(626, 15);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 115;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_regimen
            // 
            this.txt_regimen.Location = new System.Drawing.Point(443, 28);
            this.txt_regimen.Name = "txt_regimen";
            this.txt_regimen.ReadOnly = true;
            this.txt_regimen.Size = new System.Drawing.Size(156, 20);
            this.txt_regimen.TabIndex = 52;
            // 
            // Estadia_checkIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 580);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_checkIn);
            this.Controls.Add(this.gb_Estadia);
            this.Controls.Add(this.gb_Reserva);
            this.Controls.Add(this.gb_Cliente);
            this.Controls.Add(this.btn_buscarReserva);
            this.Controls.Add(this.txt_NroReserva);
            this.Controls.Add(this.lbl_reserva);
            this.Controls.Add(this.txt_hotel);
            this.Controls.Add(this.lbl_hotel);
            this.Name = "Estadia_checkIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadía - Check In";
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            this.gb_Reserva.ResumeLayout(false);
            this.gb_Reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).EndInit();
            this.gb_Estadia.ResumeLayout(false);
            this.gb_Estadia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hotel;
        private System.Windows.Forms.Label lbl_hotel;
        public System.Windows.Forms.TextBox txt_NroReserva;
        private System.Windows.Forms.Label lbl_reserva;
        private System.Windows.Forms.Button btn_buscarReserva;
        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_NroCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label lbl_nroCliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_MailCliente;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_TipoIdentificacionCliente;
        private System.Windows.Forms.TextBox txt_NroIdentificacionCliente;
        private System.Windows.Forms.Label lbl_tipoIdentif;
        private System.Windows.Forms.Label lbl_nroIdentif;
        private System.Windows.Forms.GroupBox gb_Reserva;
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
        private System.Windows.Forms.Button btn_LimpiarCampos;
        private System.Windows.Forms.DateTimePicker dtp_FechaEgreso;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_fechaEgreso;
        private System.Windows.Forms.Label lbl_fechaIngreso;
        private System.Windows.Forms.GroupBox gb_Estadia;
        private System.Windows.Forms.TextBox txt_CantNoches;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Button btn_checkIn;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_tipoHab;
        private System.Windows.Forms.TextBox txt_regimen;
    }
}