namespace FrbaHotel.ABM_de_Habitacion
{
    partial class Habitacion_Baja
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
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.cbox_ubicacion = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cbox_tipo_hab = new System.Windows.Forms.ComboBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(56, 218);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_descripcion.TabIndex = 42;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(126, 215);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(127, 20);
            this.txt_descripcion.TabIndex = 41;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(347, 88);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 40;
            this.lbl_estado.Text = "Estado";
            // 
            // cbox_estado
            // 
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada",
            "Inhabilitada"});
            this.cbox_estado.Location = new System.Drawing.Point(393, 83);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(121, 21);
            this.cbox_estado.TabIndex = 39;
            // 
            // cbox_ubicacion
            // 
            this.cbox_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ubicacion.Enabled = false;
            this.cbox_ubicacion.FormattingEnabled = true;
            this.cbox_ubicacion.Items.AddRange(new object[] {
            "Frente",
            "Contrafrente"});
            this.cbox_ubicacion.Location = new System.Drawing.Point(126, 128);
            this.cbox_ubicacion.Name = "cbox_ubicacion";
            this.cbox_ubicacion.Size = new System.Drawing.Size(127, 21);
            this.cbox_ubicacion.TabIndex = 38;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(221, 293);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(350, 293);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cbox_tipo_hab
            // 
            this.cbox_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_hab.Enabled = false;
            this.cbox_tipo_hab.FormattingEnabled = true;
            this.cbox_tipo_hab.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Doble Twin",
            "Triple",
            "Cuadruple"});
            this.cbox_tipo_hab.Location = new System.Drawing.Point(126, 173);
            this.cbox_tipo_hab.Name = "cbox_tipo_hab";
            this.cbox_tipo_hab.Size = new System.Drawing.Size(127, 21);
            this.cbox_tipo_hab.TabIndex = 35;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(126, 84);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.ReadOnly = true;
            this.txt_piso.Size = new System.Drawing.Size(127, 20);
            this.txt_piso.TabIndex = 34;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(126, 42);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(127, 20);
            this.txt_numero.TabIndex = 33;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(56, 176);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 32;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Location = new System.Drawing.Point(56, 131);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(55, 13);
            this.lbl_ubicacion.TabIndex = 31;
            this.lbl_ubicacion.Text = "Ubicación";
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Location = new System.Drawing.Point(56, 87);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(27, 13);
            this.lbl_piso.TabIndex = 30;
            this.lbl_piso.Text = "Piso";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(56, 45);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Número";
            // 
            // Habitacion_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cbox_estado);
            this.Controls.Add(this.cbox_ubicacion);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cbox_tipo_hab);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_piso);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Habitacion_Baja";
            this.Text = "Habitacion_Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.ComboBox cbox_ubicacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbox_tipo_hab;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.Label lbl_numero;
    }
}