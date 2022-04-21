namespace Tienda_de_Abarrotes
{
    partial class frmMovimientos
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
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(12, 25);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(161, 20);
            this.lblMovimiento.TabIndex = 0;
            this.lblMovimiento.Text = "Movimiento a realizar:";
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(16, 48);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(77, 24);
            this.rdbVenta.TabIndex = 1;
            this.rdbVenta.TabStop = true;
            this.rdbVenta.Text = "Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Location = new System.Drawing.Point(16, 78);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(90, 24);
            this.rdbCompra.TabIndex = 2;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(87, 123);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 39);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 174);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rdbCompra);
            this.Controls.Add(this.rdbVenta);
            this.Controls.Add(this.lblMovimiento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimientos";
            this.Text = "Movimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.Button btnContinuar;
    }
}