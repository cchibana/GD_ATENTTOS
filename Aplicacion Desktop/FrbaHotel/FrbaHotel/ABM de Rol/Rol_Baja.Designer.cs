namespace FrbaHotel.ABM_de_Rol
{
    partial class Rol_Baja
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
            this.button2 = new System.Windows.Forms.Button();
            this.lv_Roles = new System.Windows.Forms.ListView();
            this.nombreRol = new System.Windows.Forms.ColumnHeader();
            this.estadoRol = new System.Windows.Forms.ColumnHeader();
            this.btn_ActualizarListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deshabilitar Rol Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lv_Roles
            // 
            this.lv_Roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreRol,
            this.estadoRol});
            this.lv_Roles.FullRowSelect = true;
            this.lv_Roles.Location = new System.Drawing.Point(73, 52);
            this.lv_Roles.MultiSelect = false;
            this.lv_Roles.Name = "lv_Roles";
            this.lv_Roles.Size = new System.Drawing.Size(269, 274);
            this.lv_Roles.TabIndex = 2;
            this.lv_Roles.UseCompatibleStateImageBehavior = false;
            this.lv_Roles.View = System.Windows.Forms.View.Details;
            // 
            // nombreRol
            // 
            this.nombreRol.Text = "Nombre del Rol";
            // 
            // estadoRol
            // 
            this.estadoRol.Text = "Estado del Rol";
            this.estadoRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estadoRol.Width = 92;
            // 
            // btn_ActualizarListado
            // 
            this.btn_ActualizarListado.Location = new System.Drawing.Point(111, 370);
            this.btn_ActualizarListado.Name = "btn_ActualizarListado";
            this.btn_ActualizarListado.Size = new System.Drawing.Size(183, 30);
            this.btn_ActualizarListado.TabIndex = 5;
            this.btn_ActualizarListado.Text = "Actualizar Listado";
            this.btn_ActualizarListado.UseVisualStyleBackColor = true;
            this.btn_ActualizarListado.Click += new System.EventHandler(this.btn_ActualizarListado_Click);
            // 
            // Rol_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrbaHotel.Properties.Resources.IMAGEN2bn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 440);
            this.Controls.Add(this.btn_ActualizarListado);
            this.Controls.Add(this.lv_Roles);
            this.Controls.Add(this.button2);
            this.Name = "Rol_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol_Baja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lv_Roles;
        private System.Windows.Forms.ColumnHeader nombreRol;
        private System.Windows.Forms.ColumnHeader estadoRol;
        private System.Windows.Forms.Button btn_ActualizarListado;



    }
}