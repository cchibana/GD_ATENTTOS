namespace FrbaHotel.Login
{
    partial class LoginHotelRol
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.listViewHotelRol = new System.Windows.Forms.ListView();
            this.c_hotel_id = new System.Windows.Forms.ColumnHeader();
            this.c_hotel_nombre = new System.Windows.Forms.ColumnHeader();
            this.c_rol = new System.Windows.Forms.ColumnHeader();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un hotel y un rol";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(122, 238);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(124, 39);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // listViewHotelRol
            // 
            this.listViewHotelRol.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_hotel_id,
            this.c_hotel_nombre,
            this.c_rol});
            this.listViewHotelRol.FullRowSelect = true;
            this.listViewHotelRol.Location = new System.Drawing.Point(43, 64);
            this.listViewHotelRol.MultiSelect = false;
            this.listViewHotelRol.Name = "listViewHotelRol";
            this.listViewHotelRol.Size = new System.Drawing.Size(441, 154);
            this.listViewHotelRol.TabIndex = 1;
            this.listViewHotelRol.UseCompatibleStateImageBehavior = false;
            this.listViewHotelRol.View = System.Windows.Forms.View.Details;
            // 
            // c_hotel_id
            // 
            this.c_hotel_id.Text = "Código de Hotel";
            this.c_hotel_id.Width = 91;
            // 
            // c_hotel_nombre
            // 
            this.c_hotel_nombre.Text = "Nombre de Hotel";
            this.c_hotel_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_rol
            // 
            this.c_rol.Text = "Rol";
            this.c_rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(287, 238);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(124, 39);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // LoginHotelRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 299);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.listViewHotelRol);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "LoginHotelRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ListView listViewHotelRol;
        private System.Windows.Forms.ColumnHeader c_hotel_id;
        private System.Windows.Forms.ColumnHeader c_hotel_nombre;
        private System.Windows.Forms.ColumnHeader c_rol;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}