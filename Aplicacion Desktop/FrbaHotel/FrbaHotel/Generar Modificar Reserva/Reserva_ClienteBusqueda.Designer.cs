namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class Reserva_ClienteBusqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NroIdentificacion = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tipoIdentificacionCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.btn_AltaNuevoCliente = new System.Windows.Forms.Button();
            this.dgv_ClienteReserva = new System.Windows.Forms.DataGridView();
            this.btn_ConfirmarReserva = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClienteReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Identificación";
            // 
            // txt_NroIdentificacion
            // 
            this.txt_NroIdentificacion.Location = new System.Drawing.Point(290, 58);
            this.txt_NroIdentificacion.Name = "txt_NroIdentificacion";
            this.txt_NroIdentificacion.Size = new System.Drawing.Size(278, 20);
            this.txt_NroIdentificacion.TabIndex = 1;
            this.txt_NroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(290, 84);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(278, 20);
            this.txt_Mail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Identificación";
            // 
            // cb_tipoIdentificacionCliente
            // 
            this.cb_tipoIdentificacionCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoIdentificacionCliente.FormattingEnabled = true;
            this.cb_tipoIdentificacionCliente.Location = new System.Drawing.Point(290, 32);
            this.cb_tipoIdentificacionCliente.Name = "cb_tipoIdentificacionCliente";
            this.cb_tipoIdentificacionCliente.Size = new System.Drawing.Size(153, 21);
            this.cb_tipoIdentificacionCliente.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.btn_BuscarCliente);
            this.groupBox1.Controls.Add(this.txt_Mail);
            this.groupBox1.Controls.Add(this.cb_tipoIdentificacionCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NroIdentificacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(380, 123);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(105, 33);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Limpiar Campos";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(269, 123);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(105, 33);
            this.btn_BuscarCliente.TabIndex = 6;
            this.btn_BuscarCliente.Text = "Buscar Cliente";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // btn_AltaNuevoCliente
            // 
            this.btn_AltaNuevoCliente.Location = new System.Drawing.Point(31, 356);
            this.btn_AltaNuevoCliente.Name = "btn_AltaNuevoCliente";
            this.btn_AltaNuevoCliente.Size = new System.Drawing.Size(159, 33);
            this.btn_AltaNuevoCliente.TabIndex = 7;
            this.btn_AltaNuevoCliente.Text = "Alta de Nuevo Cliente";
            this.btn_AltaNuevoCliente.UseVisualStyleBackColor = true;
            this.btn_AltaNuevoCliente.Click += new System.EventHandler(this.btn_AltaNuevoCliente_Click);
            // 
            // dgv_ClienteReserva
            // 
            this.dgv_ClienteReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClienteReserva.Location = new System.Drawing.Point(31, 220);
            this.dgv_ClienteReserva.MultiSelect = false;
            this.dgv_ClienteReserva.Name = "dgv_ClienteReserva";
            this.dgv_ClienteReserva.ReadOnly = true;
            this.dgv_ClienteReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClienteReserva.Size = new System.Drawing.Size(749, 120);
            this.dgv_ClienteReserva.TabIndex = 8;
            // 
            // btn_ConfirmarReserva
            // 
            this.btn_ConfirmarReserva.Location = new System.Drawing.Point(456, 356);
            this.btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            this.btn_ConfirmarReserva.Size = new System.Drawing.Size(159, 33);
            this.btn_ConfirmarReserva.TabIndex = 9;
            this.btn_ConfirmarReserva.Text = "Confirmar Reserva";
            this.btn_ConfirmarReserva.UseVisualStyleBackColor = true;
            this.btn_ConfirmarReserva.Click += new System.EventHandler(this.btn_ConfirmarReserva_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(621, 356);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(159, 33);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Reserva_ClienteBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 429);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_ConfirmarReserva);
            this.Controls.Add(this.dgv_ClienteReserva);
            this.Controls.Add(this.btn_AltaNuevoCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reserva_ClienteBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva: Datos del Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClienteReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NroIdentificacion;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tipoIdentificacionCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Button btn_AltaNuevoCliente;
        private System.Windows.Forms.DataGridView dgv_ClienteReserva;
        private System.Windows.Forms.Button btn_ConfirmarReserva;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}