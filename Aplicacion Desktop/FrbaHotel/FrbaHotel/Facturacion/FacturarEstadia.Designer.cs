namespace FrbaHotel.Facturacion
{
    partial class FacturarEstadia
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NroEstadia = new System.Windows.Forms.TextBox();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NroTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Banco = new System.Windows.Forms.TextBox();
            this.gb_PagoTarjeta = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_FormaDePago = new System.Windows.Forms.ComboBox();
            this.gb_PagoTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número de Estadía";
            // 
            // txt_NroEstadia
            // 
            this.txt_NroEstadia.Location = new System.Drawing.Point(200, 37);
            this.txt_NroEstadia.Name = "txt_NroEstadia";
            this.txt_NroEstadia.Size = new System.Drawing.Size(158, 20);
            this.txt_NroEstadia.TabIndex = 8;
            this.txt_NroEstadia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Location = new System.Drawing.Point(172, 220);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(135, 35);
            this.btn_Facturar.TabIndex = 7;
            this.btn_Facturar.Text = "Facturar Estadía";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número de Tarjeta";
            // 
            // txt_NroTarjeta
            // 
            this.txt_NroTarjeta.Location = new System.Drawing.Point(152, 30);
            this.txt_NroTarjeta.Name = "txt_NroTarjeta";
            this.txt_NroTarjeta.Size = new System.Drawing.Size(158, 20);
            this.txt_NroTarjeta.TabIndex = 13;
            this.txt_NroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNum);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Banco";
            // 
            // txt_Banco
            // 
            this.txt_Banco.Location = new System.Drawing.Point(152, 56);
            this.txt_Banco.Name = "txt_Banco";
            this.txt_Banco.Size = new System.Drawing.Size(158, 20);
            this.txt_Banco.TabIndex = 15;
            // 
            // gb_PagoTarjeta
            // 
            this.gb_PagoTarjeta.Controls.Add(this.txt_NroTarjeta);
            this.gb_PagoTarjeta.Controls.Add(this.label3);
            this.gb_PagoTarjeta.Controls.Add(this.label1);
            this.gb_PagoTarjeta.Controls.Add(this.txt_Banco);
            this.gb_PagoTarjeta.Enabled = false;
            this.gb_PagoTarjeta.Location = new System.Drawing.Point(48, 114);
            this.gb_PagoTarjeta.Name = "gb_PagoTarjeta";
            this.gb_PagoTarjeta.Size = new System.Drawing.Size(355, 100);
            this.gb_PagoTarjeta.TabIndex = 17;
            this.gb_PagoTarjeta.TabStop = false;
            this.gb_PagoTarjeta.Text = "Datos del pago con tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Forma de Pago";
            // 
            // cb_FormaDePago
            // 
            this.cb_FormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FormaDePago.FormattingEnabled = true;
            this.cb_FormaDePago.Location = new System.Drawing.Point(200, 73);
            this.cb_FormaDePago.Name = "cb_FormaDePago";
            this.cb_FormaDePago.Size = new System.Drawing.Size(158, 21);
            this.cb_FormaDePago.TabIndex = 19;
            this.cb_FormaDePago.SelectedIndexChanged += new System.EventHandler(this.cb_FormaDePago_SelectedIndexChanged);
            // 
            // FacturarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 291);
            this.Controls.Add(this.cb_FormaDePago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb_PagoTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NroEstadia);
            this.Controls.Add(this.btn_Facturar);
            this.Name = "FacturarEstadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar Estadia";
            this.gb_PagoTarjeta.ResumeLayout(false);
            this.gb_PagoTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NroEstadia;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NroTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Banco;
        private System.Windows.Forms.GroupBox gb_PagoTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_FormaDePago;
    }
}