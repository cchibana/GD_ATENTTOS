namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitacion_Alta
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.cbox_tipo_hab = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_ubicacion = new System.Windows.Forms.ComboBox();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(29, 24);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Location = new System.Drawing.Point(29, 66);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 1;
            this.lbl_piso.Text = "Piso";
            this.lbl_piso.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Location = new System.Drawing.Point(29, 110);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 2;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(29, 155);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 3;
            this.lbl_tipo.Text = "Tipo";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(99, 21);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(127, 20);
            this.txt_numero.TabIndex = 4;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(99, 63);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(127, 20);
            this.txt_piso.TabIndex = 5;
            // 
            // cbox_tipo_hab
            // 
            this.cbox_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_hab.FormattingEnabled = true;
            this.cbox_tipo_hab.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Doble Twin",
            "Triple",
            "Cuadruple"});
            this.cbox_tipo_hab.Location = new System.Drawing.Point(99, 152);
            this.cbox_tipo_hab.Name = "cbox_tipo_hab";
            this.cbox_tipo_hab.Size = new System.Drawing.Size(127, 21);
            this.cbox_tipo_hab.TabIndex = 7;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(200, 281);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(319, 281);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // cbox_ubicacion
            // 
            this.cbox_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ubicacion.FormattingEnabled = true;
            this.cbox_ubicacion.Items.AddRange(new object[] {
            "Frente",
            "Contrafrente"});
            this.cbox_ubicacion.Location = new System.Drawing.Point(99, 107);
            this.cbox_ubicacion.Name = "cbox_ubicacion";
            this.cbox_ubicacion.Size = new System.Drawing.Size(127, 21);
            this.cbox_ubicacion.TabIndex = 10;
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.cbox_estado.Location = new System.Drawing.Point(366, 62);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(121, 21);
            this.cbox_estado.TabIndex = 11;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(320, 67);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 12;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(99, 194);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(127, 20);
            this.txt_descripcion.TabIndex = 13;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(29, 197);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 14;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // Habitacion_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 345);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.cbox_ubicacion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cbox_tipo_hab);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_piso);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Habitacion_Alta";
            this.Text = "Alta Habitación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.ComboBox cbox_tipo_hab;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbox_ubicacion;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
    }
}