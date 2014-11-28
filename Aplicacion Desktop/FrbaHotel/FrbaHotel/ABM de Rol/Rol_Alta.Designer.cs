namespace FrbaHotel.ABM_de_Rol
{
    partial class Rol_Alta
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
            this.btn_AgregarFuncionalidad = new System.Windows.Forms.Button();
            this.cb_Funcionalidades = new System.Windows.Forms.ComboBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Funcionalidades = new System.Windows.Forms.ListBox();
            this.btn_QuitarFuncionalidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_EstadoRol = new System.Windows.Forms.ComboBox();
            this.btn_GuardarRol = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol";
            // 
            // btn_AgregarFuncionalidad
            // 
            this.btn_AgregarFuncionalidad.Location = new System.Drawing.Point(260, 67);
            this.btn_AgregarFuncionalidad.Name = "btn_AgregarFuncionalidad";
            this.btn_AgregarFuncionalidad.Size = new System.Drawing.Size(182, 30);
            this.btn_AgregarFuncionalidad.TabIndex = 1;
            this.btn_AgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btn_AgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btn_AgregarFuncionalidad.Click += new System.EventHandler(this.btn_AgregarFuncionalidad_Click);
            // 
            // cb_Funcionalidades
            // 
            this.cb_Funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Funcionalidades.FormattingEnabled = true;
            this.cb_Funcionalidades.Location = new System.Drawing.Point(260, 27);
            this.cb_Funcionalidades.Name = "cb_Funcionalidades";
            this.cb_Funcionalidades.Size = new System.Drawing.Size(182, 21);
            this.cb_Funcionalidades.TabIndex = 0;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(118, 21);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(236, 20);
            this.txtNombreRol.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Funcionalidades);
            this.groupBox1.Controls.Add(this.btn_QuitarFuncionalidad);
            this.groupBox1.Controls.Add(this.cb_Funcionalidades);
            this.groupBox1.Controls.Add(this.btn_AgregarFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(20, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Funcionalidades";
            // 
            // lb_Funcionalidades
            // 
            this.lb_Funcionalidades.FormattingEnabled = true;
            this.lb_Funcionalidades.Location = new System.Drawing.Point(20, 29);
            this.lb_Funcionalidades.Name = "lb_Funcionalidades";
            this.lb_Funcionalidades.Size = new System.Drawing.Size(223, 225);
            this.lb_Funcionalidades.TabIndex = 4;
            // 
            // btn_QuitarFuncionalidad
            // 
            this.btn_QuitarFuncionalidad.Location = new System.Drawing.Point(260, 222);
            this.btn_QuitarFuncionalidad.Name = "btn_QuitarFuncionalidad";
            this.btn_QuitarFuncionalidad.Size = new System.Drawing.Size(182, 30);
            this.btn_QuitarFuncionalidad.TabIndex = 3;
            this.btn_QuitarFuncionalidad.Text = "Quitar Funcionalidad";
            this.btn_QuitarFuncionalidad.UseVisualStyleBackColor = true;
            this.btn_QuitarFuncionalidad.Click += new System.EventHandler(this.btn_QuitarFuncionalidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado del Rol";
            // 
            // cb_EstadoRol
            // 
            this.cb_EstadoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EstadoRol.FormattingEnabled = true;
            this.cb_EstadoRol.Location = new System.Drawing.Point(118, 336);
            this.cb_EstadoRol.Name = "cb_EstadoRol";
            this.cb_EstadoRol.Size = new System.Drawing.Size(236, 21);
            this.cb_EstadoRol.TabIndex = 2;
            // 
            // btn_GuardarRol
            // 
            this.btn_GuardarRol.Location = new System.Drawing.Point(81, 381);
            this.btn_GuardarRol.Name = "btn_GuardarRol";
            this.btn_GuardarRol.Size = new System.Drawing.Size(149, 40);
            this.btn_GuardarRol.TabIndex = 3;
            this.btn_GuardarRol.Text = "Guardar Rol";
            this.btn_GuardarRol.UseVisualStyleBackColor = true;
            this.btn_GuardarRol.Click += new System.EventHandler(this.btn_GuardarRol_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(260, 381);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(149, 40);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar Campos";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Rol_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_GuardarRol);
            this.Controls.Add(this.cb_EstadoRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label1);
            this.Name = "Rol_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Rol";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AgregarFuncionalidad;
        private System.Windows.Forms.ComboBox cb_Funcionalidades;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_QuitarFuncionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_EstadoRol;
        private System.Windows.Forms.Button btn_GuardarRol;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ListBox lb_Funcionalidades;
    }
}