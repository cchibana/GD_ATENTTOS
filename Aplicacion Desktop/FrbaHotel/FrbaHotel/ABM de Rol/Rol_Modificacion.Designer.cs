namespace FrbaHotel.ABM_de_Rol
{
    partial class Rol_Modificacion
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarListado = new System.Windows.Forms.Button();
            this.lv_Roles = new System.Windows.Forms.ListView();
            this.NombreRol = new System.Windows.Forms.ColumnHeader();
            this.EstadoRol = new System.Windows.Forms.ColumnHeader();
            this.btn_HabilitarRolSeleccionado = new System.Windows.Forms.Button();
            this.btn_ModificarRolSeleccionado = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.btn_GuardarRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_QuitarFuncionalidad = new System.Windows.Forms.Button();
            this.lb_Funcionalidades = new System.Windows.Forms.ListBox();
            this.cb_Funcionalidades = new System.Windows.Forms.ComboBox();
            this.btn_AgregarFuncionalidad = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ActualizarListado);
            this.groupBox3.Controls.Add(this.lv_Roles);
            this.groupBox3.Controls.Add(this.btn_HabilitarRolSeleccionado);
            this.groupBox3.Controls.Add(this.btn_ModificarRolSeleccionado);
            this.groupBox3.Location = new System.Drawing.Point(29, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 452);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Roles";
            // 
            // btn_ActualizarListado
            // 
            this.btn_ActualizarListado.Location = new System.Drawing.Point(60, 416);
            this.btn_ActualizarListado.Name = "btn_ActualizarListado";
            this.btn_ActualizarListado.Size = new System.Drawing.Size(183, 30);
            this.btn_ActualizarListado.TabIndex = 4;
            this.btn_ActualizarListado.Text = "Actualizar Listado";
            this.btn_ActualizarListado.UseVisualStyleBackColor = true;
            this.btn_ActualizarListado.Click += new System.EventHandler(this.btn_ActualizarListado_Click);
            // 
            // lv_Roles
            // 
            this.lv_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreRol,
            this.EstadoRol});
            this.lv_Roles.FullRowSelect = true;
            this.lv_Roles.Location = new System.Drawing.Point(16, 19);
            this.lv_Roles.MultiSelect = false;
            this.lv_Roles.Name = "lv_Roles";
            this.lv_Roles.Size = new System.Drawing.Size(270, 276);
            this.lv_Roles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Roles.TabIndex = 3;
            this.lv_Roles.UseCompatibleStateImageBehavior = false;
            this.lv_Roles.View = System.Windows.Forms.View.Details;
            // 
            // NombreRol
            // 
            this.NombreRol.Text = "Nombre del Rol";
            this.NombreRol.Width = 147;
            // 
            // EstadoRol
            // 
            this.EstadoRol.Text = "Estado del Rol";
            this.EstadoRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EstadoRol.Width = 119;
            // 
            // btn_HabilitarRolSeleccionado
            // 
            this.btn_HabilitarRolSeleccionado.Location = new System.Drawing.Point(60, 354);
            this.btn_HabilitarRolSeleccionado.Name = "btn_HabilitarRolSeleccionado";
            this.btn_HabilitarRolSeleccionado.Size = new System.Drawing.Size(183, 30);
            this.btn_HabilitarRolSeleccionado.TabIndex = 2;
            this.btn_HabilitarRolSeleccionado.Text = "Habilitar Rol Seleccionado";
            this.btn_HabilitarRolSeleccionado.UseVisualStyleBackColor = true;
            this.btn_HabilitarRolSeleccionado.Click += new System.EventHandler(this.btn_HabilitarRolSeleccionado_Click);
            // 
            // btn_ModificarRolSeleccionado
            // 
            this.btn_ModificarRolSeleccionado.Location = new System.Drawing.Point(60, 318);
            this.btn_ModificarRolSeleccionado.Name = "btn_ModificarRolSeleccionado";
            this.btn_ModificarRolSeleccionado.Size = new System.Drawing.Size(183, 30);
            this.btn_ModificarRolSeleccionado.TabIndex = 1;
            this.btn_ModificarRolSeleccionado.Text = "Modificar Rol Seleccionado";
            this.btn_ModificarRolSeleccionado.UseVisualStyleBackColor = true;
            this.btn_ModificarRolSeleccionado.Click += new System.EventHandler(this.btn_ModificarRolSeleccionado_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(452, 43);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(236, 20);
            this.txtNombreRol.TabIndex = 1;
            // 
            // btn_GuardarRol
            // 
            this.btn_GuardarRol.Location = new System.Drawing.Point(487, 378);
            this.btn_GuardarRol.Name = "btn_GuardarRol";
            this.btn_GuardarRol.Size = new System.Drawing.Size(201, 40);
            this.btn_GuardarRol.TabIndex = 3;
            this.btn_GuardarRol.Text = "Guardar Modificación";
            this.btn_GuardarRol.UseVisualStyleBackColor = true;
            this.btn_GuardarRol.Click += new System.EventHandler(this.btn_GuardarRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre del Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_QuitarFuncionalidad);
            this.groupBox1.Controls.Add(this.lb_Funcionalidades);
            this.groupBox1.Controls.Add(this.cb_Funcionalidades);
            this.groupBox1.Controls.Add(this.btn_AgregarFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(354, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Funcionalidades";
            // 
            // btn_QuitarFuncionalidad
            // 
            this.btn_QuitarFuncionalidad.Location = new System.Drawing.Point(238, 224);
            this.btn_QuitarFuncionalidad.Name = "btn_QuitarFuncionalidad";
            this.btn_QuitarFuncionalidad.Size = new System.Drawing.Size(177, 30);
            this.btn_QuitarFuncionalidad.TabIndex = 3;
            this.btn_QuitarFuncionalidad.Text = "Quitar Funcionalidad";
            this.btn_QuitarFuncionalidad.UseVisualStyleBackColor = true;
            this.btn_QuitarFuncionalidad.Click += new System.EventHandler(this.btn_QuitarFuncionalidad_Click);
            // 
            // lb_Funcionalidades
            // 
            this.lb_Funcionalidades.FormattingEnabled = true;
            this.lb_Funcionalidades.Location = new System.Drawing.Point(17, 29);
            this.lb_Funcionalidades.Name = "lb_Funcionalidades";
            this.lb_Funcionalidades.Size = new System.Drawing.Size(205, 225);
            this.lb_Funcionalidades.TabIndex = 2;
            // 
            // cb_Funcionalidades
            // 
            this.cb_Funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Funcionalidades.FormattingEnabled = true;
            this.cb_Funcionalidades.Location = new System.Drawing.Point(238, 29);
            this.cb_Funcionalidades.Name = "cb_Funcionalidades";
            this.cb_Funcionalidades.Size = new System.Drawing.Size(177, 21);
            this.cb_Funcionalidades.TabIndex = 0;
            // 
            // btn_AgregarFuncionalidad
            // 
            this.btn_AgregarFuncionalidad.Location = new System.Drawing.Point(238, 58);
            this.btn_AgregarFuncionalidad.Name = "btn_AgregarFuncionalidad";
            this.btn_AgregarFuncionalidad.Size = new System.Drawing.Size(177, 30);
            this.btn_AgregarFuncionalidad.TabIndex = 1;
            this.btn_AgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btn_AgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btn_AgregarFuncionalidad.Click += new System.EventHandler(this.btn_AgregarFuncionalidad_Click);
            // 
            // Rol_Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.btn_GuardarRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Rol_Modificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Rol";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_HabilitarRolSeleccionado;
        private System.Windows.Forms.Button btn_ModificarRolSeleccionado;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Button btn_GuardarRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_QuitarFuncionalidad;
        private System.Windows.Forms.ListBox lb_Funcionalidades;
        private System.Windows.Forms.ComboBox cb_Funcionalidades;
        private System.Windows.Forms.Button btn_AgregarFuncionalidad;
        private System.Windows.Forms.ListView lv_Roles;
        private System.Windows.Forms.ColumnHeader NombreRol;
        private System.Windows.Forms.ColumnHeader EstadoRol;
        private System.Windows.Forms.Button btn_ActualizarListado;

    }
}