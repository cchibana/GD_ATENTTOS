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
            this.lb_Roles = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Roles
            // 
            this.lb_Roles.FormattingEnabled = true;
            this.lb_Roles.Location = new System.Drawing.Point(27, 18);
            this.lb_Roles.Name = "lb_Roles";
            this.lb_Roles.Size = new System.Drawing.Size(328, 303);
            this.lb_Roles.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deshabilitar Rol Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Rol_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_Roles);
            this.Name = "Rol_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol_Baja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Roles;
        private System.Windows.Forms.Button button2;



    }
}