namespace FrbaHotel.Registrar_Consumible
{
    partial class RegistrarConsumibles
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
            this.btn_RegistrarConsumible = new System.Windows.Forms.Button();
            this.txt_NroEstadia = new System.Windows.Forms.TextBox();
            this.cb_Consumibles = new System.Windows.Forms.ComboBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_RegistrarConsumible
            // 
            this.btn_RegistrarConsumible.Location = new System.Drawing.Point(105, 130);
            this.btn_RegistrarConsumible.Name = "btn_RegistrarConsumible";
            this.btn_RegistrarConsumible.Size = new System.Drawing.Size(135, 35);
            this.btn_RegistrarConsumible.TabIndex = 0;
            this.btn_RegistrarConsumible.Text = "Registrar Consumible";
            this.btn_RegistrarConsumible.UseVisualStyleBackColor = true;
            this.btn_RegistrarConsumible.Click += new System.EventHandler(this.btn_RegistrarConsumible_Click);
            // 
            // txt_NroEstadia
            // 
            this.txt_NroEstadia.Location = new System.Drawing.Point(161, 37);
            this.txt_NroEstadia.Name = "txt_NroEstadia";
            this.txt_NroEstadia.Size = new System.Drawing.Size(158, 20);
            this.txt_NroEstadia.TabIndex = 1;
            this.txt_NroEstadia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // cb_Consumibles
            // 
            this.cb_Consumibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Consumibles.FormattingEnabled = true;
            this.cb_Consumibles.Location = new System.Drawing.Point(161, 65);
            this.cb_Consumibles.Name = "cb_Consumibles";
            this.cb_Consumibles.Size = new System.Drawing.Size(158, 21);
            this.cb_Consumibles.TabIndex = 2;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(161, 92);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(158, 20);
            this.txt_Cantidad.TabIndex = 3;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de Estadía";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item";
            // 
            // RegistrarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cb_Consumibles);
            this.Controls.Add(this.txt_NroEstadia);
            this.Controls.Add(this.btn_RegistrarConsumible);
            this.Name = "RegistrarConsumibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Consumibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrarConsumible;
        private System.Windows.Forms.TextBox txt_NroEstadia;
        private System.Windows.Forms.ComboBox cb_Consumibles;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}