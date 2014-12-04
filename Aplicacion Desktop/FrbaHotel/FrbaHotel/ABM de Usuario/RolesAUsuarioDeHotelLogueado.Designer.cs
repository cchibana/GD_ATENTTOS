namespace FrbaHotel.ABM_de_Usuario
{
    partial class RolesAUsuarioDeHotelLogueado
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
            this.gb_Roles = new System.Windows.Forms.GroupBox();
            this.btn_QuitarRol = new System.Windows.Forms.Button();
            this.lb_roles = new System.Windows.Forms.ListBox();
            this.btn_AgregarRol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Rol = new System.Windows.Forms.ComboBox();
            this.btn_GuardarRoles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gb_Roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Roles
            // 
            this.gb_Roles.Controls.Add(this.btn_QuitarRol);
            this.gb_Roles.Controls.Add(this.lb_roles);
            this.gb_Roles.Controls.Add(this.btn_AgregarRol);
            this.gb_Roles.Controls.Add(this.label5);
            this.gb_Roles.Controls.Add(this.cb_Rol);
            this.gb_Roles.Location = new System.Drawing.Point(12, 52);
            this.gb_Roles.Name = "gb_Roles";
            this.gb_Roles.Size = new System.Drawing.Size(376, 195);
            this.gb_Roles.TabIndex = 2;
            this.gb_Roles.TabStop = false;
            this.gb_Roles.Text = "Roles en este hotel ";
            // 
            // btn_QuitarRol
            // 
            this.btn_QuitarRol.Location = new System.Drawing.Point(30, 151);
            this.btn_QuitarRol.Name = "btn_QuitarRol";
            this.btn_QuitarRol.Size = new System.Drawing.Size(145, 33);
            this.btn_QuitarRol.TabIndex = 3;
            this.btn_QuitarRol.Text = "Quitar Rol";
            this.btn_QuitarRol.UseVisualStyleBackColor = true;
            this.btn_QuitarRol.Click += new System.EventHandler(this.btn_QuitarRol_Click);
            // 
            // lb_roles
            // 
            this.lb_roles.FormattingEnabled = true;
            this.lb_roles.Location = new System.Drawing.Point(188, 24);
            this.lb_roles.Name = "lb_roles";
            this.lb_roles.Size = new System.Drawing.Size(165, 160);
            this.lb_roles.TabIndex = 0;
            // 
            // btn_AgregarRol
            // 
            this.btn_AgregarRol.Location = new System.Drawing.Point(30, 75);
            this.btn_AgregarRol.Name = "btn_AgregarRol";
            this.btn_AgregarRol.Size = new System.Drawing.Size(145, 33);
            this.btn_AgregarRol.TabIndex = 2;
            this.btn_AgregarRol.Text = "Agregar Rol";
            this.btn_AgregarRol.UseVisualStyleBackColor = true;
            this.btn_AgregarRol.Click += new System.EventHandler(this.btn_AgregarRol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // cb_Rol
            // 
            this.cb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rol.FormattingEnabled = true;
            this.cb_Rol.Location = new System.Drawing.Point(30, 49);
            this.cb_Rol.Name = "cb_Rol";
            this.cb_Rol.Size = new System.Drawing.Size(145, 21);
            this.cb_Rol.TabIndex = 1;
            // 
            // btn_GuardarRoles
            // 
            this.btn_GuardarRoles.Location = new System.Drawing.Point(48, 272);
            this.btn_GuardarRoles.Name = "btn_GuardarRoles";
            this.btn_GuardarRoles.Size = new System.Drawing.Size(139, 34);
            this.btn_GuardarRoles.TabIndex = 3;
            this.btn_GuardarRoles.Text = "Guardar";
            this.btn_GuardarRoles.UseVisualStyleBackColor = true;
            this.btn_GuardarRoles.Click += new System.EventHandler(this.btn_GuardarRoles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(197, 18);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(29, 17);
            this.lbl_nombreUsuario.TabIndex = 10;
            this.lbl_nombreUsuario.Text = "Rol";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(200, 272);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(139, 34);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // RolesAUsuarioDeHotelLogueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 318);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GuardarRoles);
            this.Controls.Add(this.gb_Roles);
            this.Name = "RolesAUsuarioDeHotelLogueado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar roles al usuario seleccionado";
            this.gb_Roles.ResumeLayout(false);
            this.gb_Roles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Roles;
        private System.Windows.Forms.Button btn_QuitarRol;
        private System.Windows.Forms.ListBox lb_roles;
        private System.Windows.Forms.Button btn_AgregarRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Rol;
        private System.Windows.Forms.Button btn_GuardarRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}