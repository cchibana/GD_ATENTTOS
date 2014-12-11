namespace FrbaHotel.Cancelar_Reserva
{
    partial class Cancelar_Reserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_BuscarReserva = new System.Windows.Forms.Button();
            this.txt_NroReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gb_Reserva = new System.Windows.Forms.GroupBox();
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
            this.btn_CancelarReserva = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.gb_Importes = new System.Windows.Forms.GroupBox();
            this.txt_CantNoches = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ImporteDia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_ImporteTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.lbl_Motivo = new System.Windows.Forms.Label();
            this.gb_Cliente.SuspendLayout();
            this.gb_Reserva.SuspendLayout();
            this.gb_Importes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarReserva
            // 
            this.btn_BuscarReserva.Location = new System.Drawing.Point(318, 50);
            this.btn_BuscarReserva.Name = "btn_BuscarReserva";
            this.btn_BuscarReserva.Size = new System.Drawing.Size(118, 25);
            this.btn_BuscarReserva.TabIndex = 52;
            this.btn_BuscarReserva.Text = "Buscar Reserva";
            this.btn_BuscarReserva.UseVisualStyleBackColor = true;
            this.btn_BuscarReserva.Click += new System.EventHandler(this.btn_BuscarReserva_Click);
            // 
            // txt_NroReserva
            // 
            this.txt_NroReserva.Location = new System.Drawing.Point(157, 53);
            this.txt_NroReserva.Name = "txt_NroReserva";
            this.txt_NroReserva.Size = new System.Drawing.Size(155, 20);
            this.txt_NroReserva.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Número de Reserva";
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
            this.gb_Cliente.Location = new System.Drawing.Point(26, 91);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(867, 136);
            this.gb_Cliente.TabIndex = 53;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Datos del Cliente";
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
            // txt_MailCliente
            // 
            this.txt_MailCliente.Location = new System.Drawing.Point(564, 88);
            this.txt_MailCliente.Name = "txt_MailCliente";
            this.txt_MailCliente.ReadOnly = true;
            this.txt_MailCliente.Size = new System.Drawing.Size(248, 20);
            this.txt_MailCliente.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(415, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mail";
            // 
            // txt_TipoIdentificacionCliente
            // 
            this.txt_TipoIdentificacionCliente.Location = new System.Drawing.Point(564, 33);
            this.txt_TipoIdentificacionCliente.Name = "txt_TipoIdentificacionCliente";
            this.txt_TipoIdentificacionCliente.ReadOnly = true;
            this.txt_TipoIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoIdentificacionCliente.TabIndex = 9;
            // 
            // txt_NroIdentificacionCliente
            // 
            this.txt_NroIdentificacionCliente.Location = new System.Drawing.Point(564, 61);
            this.txt_NroIdentificacionCliente.Name = "txt_NroIdentificacionCliente";
            this.txt_NroIdentificacionCliente.ReadOnly = true;
            this.txt_NroIdentificacionCliente.Size = new System.Drawing.Size(178, 20);
            this.txt_NroIdentificacionCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(415, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Identificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(415, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Número de Identificación";
            // 
            // gb_Reserva
            // 
            this.gb_Reserva.Controls.Add(this.dgv_HabitacionesReserva);
            this.gb_Reserva.Controls.Add(this.txt_FechaEgresoReserva);
            this.gb_Reserva.Controls.Add(this.txt_TipoRegimenReserva);
            this.gb_Reserva.Controls.Add(this.txt_FechaIngresoReserva);
            this.gb_Reserva.Controls.Add(this.txt_CiudadReserva);
            this.gb_Reserva.Controls.Add(this.label8);
            this.gb_Reserva.Controls.Add(this.txt_HotelReserva);
            this.gb_Reserva.Controls.Add(this.label9);
            this.gb_Reserva.Controls.Add(this.label10);
            this.gb_Reserva.Controls.Add(this.label11);
            this.gb_Reserva.Controls.Add(this.label12);
            this.gb_Reserva.Location = new System.Drawing.Point(26, 239);
            this.gb_Reserva.Name = "gb_Reserva";
            this.gb_Reserva.Size = new System.Drawing.Size(1206, 288);
            this.gb_Reserva.TabIndex = 54;
            this.gb_Reserva.TabStop = false;
            this.gb_Reserva.Text = "Datos de la reserva";
            // 
            // txt_FechaEgresoReserva
            // 
            this.txt_FechaEgresoReserva.Location = new System.Drawing.Point(538, 60);
            this.txt_FechaEgresoReserva.Name = "txt_FechaEgresoReserva";
            this.txt_FechaEgresoReserva.ReadOnly = true;
            this.txt_FechaEgresoReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_FechaEgresoReserva.TabIndex = 27;
            // 
            // txt_TipoRegimenReserva
            // 
            this.txt_TipoRegimenReserva.Location = new System.Drawing.Point(913, 34);
            this.txt_TipoRegimenReserva.Name = "txt_TipoRegimenReserva";
            this.txt_TipoRegimenReserva.ReadOnly = true;
            this.txt_TipoRegimenReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_TipoRegimenReserva.TabIndex = 25;
            // 
            // txt_FechaIngresoReserva
            // 
            this.txt_FechaIngresoReserva.Location = new System.Drawing.Point(538, 34);
            this.txt_FechaIngresoReserva.Name = "txt_FechaIngresoReserva";
            this.txt_FechaIngresoReserva.ReadOnly = true;
            this.txt_FechaIngresoReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_FechaIngresoReserva.TabIndex = 17;
            // 
            // txt_CiudadReserva
            // 
            this.txt_CiudadReserva.Location = new System.Drawing.Point(163, 34);
            this.txt_CiudadReserva.Name = "txt_CiudadReserva";
            this.txt_CiudadReserva.ReadOnly = true;
            this.txt_CiudadReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_CiudadReserva.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(788, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo de Régimen";
            // 
            // txt_HotelReserva
            // 
            this.txt_HotelReserva.Location = new System.Drawing.Point(163, 60);
            this.txt_HotelReserva.Name = "txt_HotelReserva";
            this.txt_HotelReserva.ReadOnly = true;
            this.txt_HotelReserva.Size = new System.Drawing.Size(178, 20);
            this.txt_HotelReserva.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de Egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hotel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ciudad";
            // 
            // btn_CancelarReserva
            // 
            this.btn_CancelarReserva.Location = new System.Drawing.Point(461, 576);
            this.btn_CancelarReserva.Name = "btn_CancelarReserva";
            this.btn_CancelarReserva.Size = new System.Drawing.Size(159, 33);
            this.btn_CancelarReserva.TabIndex = 55;
            this.btn_CancelarReserva.Text = "Cancelar Reserva";
            this.btn_CancelarReserva.UseVisualStyleBackColor = true;
            this.btn_CancelarReserva.Click += new System.EventHandler(this.btn_CancelarReserva_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(626, 576);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(159, 33);
            this.btn_Cerrar.TabIndex = 56;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
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
            this.gb_Importes.Location = new System.Drawing.Point(899, 62);
            this.gb_Importes.Name = "gb_Importes";
            this.gb_Importes.Size = new System.Drawing.Size(333, 165);
            this.gb_Importes.TabIndex = 57;
            this.gb_Importes.TabStop = false;
            this.gb_Importes.Text = "Importes";
            this.gb_Importes.Visible = false;
            // 
            // txt_CantNoches
            // 
            this.txt_CantNoches.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.txt_ImporteDia.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.txt_ImporteTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.dgv_HabitacionesReserva.Location = new System.Drawing.Point(25, 102);
            this.dgv_HabitacionesReserva.MultiSelect = false;
            this.dgv_HabitacionesReserva.Name = "dgv_HabitacionesReserva";
            this.dgv_HabitacionesReserva.ReadOnly = true;
            this.dgv_HabitacionesReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HabitacionesReserva.Size = new System.Drawing.Size(1153, 172);
            this.dgv_HabitacionesReserva.TabIndex = 48;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaInicio.HeaderText = "Fecha Inicio de Reserva";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle2;
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
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(157, 537);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(1075, 20);
            this.txt_motivo.TabIndex = 16;
            // 
            // lbl_Motivo
            // 
            this.lbl_Motivo.AutoSize = true;
            this.lbl_Motivo.Location = new System.Drawing.Point(23, 540);
            this.lbl_Motivo.Name = "lbl_Motivo";
            this.lbl_Motivo.Size = new System.Drawing.Size(127, 13);
            this.lbl_Motivo.TabIndex = 58;
            this.lbl_Motivo.Text = "Motivo de la Cancelación";
            // 
            // Cancelar_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 644);
            this.Controls.Add(this.lbl_Motivo);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.gb_Importes);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_CancelarReserva);
            this.Controls.Add(this.gb_Reserva);
            this.Controls.Add(this.gb_Cliente);
            this.Controls.Add(this.btn_BuscarReserva);
            this.Controls.Add(this.txt_NroReserva);
            this.Controls.Add(this.label1);
            this.Name = "Cancelar_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Reserva";
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            this.gb_Reserva.ResumeLayout(false);
            this.gb_Reserva.PerformLayout();
            this.gb_Importes.ResumeLayout(false);
            this.gb_Importes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HabitacionesReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarReserva;
        private System.Windows.Forms.TextBox txt_NroReserva;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox gb_Reserva;
        private System.Windows.Forms.TextBox txt_FechaEgresoReserva;
        private System.Windows.Forms.TextBox txt_TipoRegimenReserva;
        private System.Windows.Forms.TextBox txt_FechaIngresoReserva;
        private System.Windows.Forms.TextBox txt_CiudadReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_HotelReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_CancelarReserva;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.GroupBox gb_Importes;
        private System.Windows.Forms.TextBox txt_CantNoches;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ImporteDia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_ImporteTotal;
        private System.Windows.Forms.Label label18;
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
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label lbl_Motivo;
    }
}