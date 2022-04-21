
namespace Tienda_de_Abarrotes
{
    partial class frmCompras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtPiezas = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPago = new System.Windows.Forms.Label();
            this.rdbCaja = new System.Windows.Forms.RadioButton();
            this.rdbBancos = new System.Windows.Forms.RadioButton();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDeAbarrotesDataSet = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSet();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.ComprasTableAdapter();
            this.inventarioTableAdapter = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.InventarioTableAdapter();
            this.cajaTableAdapter = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.CajaTableAdapter();
            this.bancosTableAdapter = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.BancosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeAbarrotesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Piezas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(207, 204);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 38);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnTtl_Click);
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(38, 110);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(121, 26);
            this.TxtProducto.TabIndex = 9;
            this.TxtProducto.TextChanged += new System.EventHandler(this.TxtProducto_TextChanged);
            // 
            // TxtPiezas
            // 
            this.TxtPiezas.Location = new System.Drawing.Point(207, 110);
            this.TxtPiezas.Name = "TxtPiezas";
            this.TxtPiezas.Size = new System.Drawing.Size(120, 26);
            this.TxtPiezas.TabIndex = 10;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(366, 110);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(120, 26);
            this.TxtValor.TabIndex = 11;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(206, 153);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(0, 20);
            this.Lbl2.TabIndex = 13;
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(610, 331);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(79, 29);
            this.Lbl4.TabIndex = 17;
            this.Lbl4.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor total:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(501, 9);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(51, 20);
            this.LblFecha.TabIndex = 21;
            this.LblFecha.Text = "label5";
            this.LblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(38, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 38);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agegar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAc_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(34, 258);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(119, 20);
            this.lblPago.TabIndex = 26;
            this.lblPago.Text = "Medio de Pago:";
            // 
            // rdbCaja
            // 
            this.rdbCaja.AutoSize = true;
            this.rdbCaja.Location = new System.Drawing.Point(38, 281);
            this.rdbCaja.Name = "rdbCaja";
            this.rdbCaja.Size = new System.Drawing.Size(91, 24);
            this.rdbCaja.TabIndex = 27;
            this.rdbCaja.TabStop = true;
            this.rdbCaja.Text = "Efectivo";
            this.rdbCaja.UseVisualStyleBackColor = true;
            // 
            // rdbBancos
            // 
            this.rdbBancos.AutoSize = true;
            this.rdbBancos.Location = new System.Drawing.Point(38, 311);
            this.rdbBancos.Name = "rdbBancos";
            this.rdbBancos.Size = new System.Drawing.Size(131, 24);
            this.rdbBancos.TabIndex = 28;
            this.rdbBancos.TabStop = true;
            this.rdbBancos.Text = "Transferencia";
            this.rdbBancos.UseVisualStyleBackColor = true;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.tiendaDeAbarrotesDataSet;
            // 
            // tiendaDeAbarrotesDataSet
            // 
            this.tiendaDeAbarrotesDataSet.DataSetName = "tiendaDeAbarrotesDataSet";
            this.tiendaDeAbarrotesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.tiendaDeAbarrotesDataSet;
            // 
            // cajaBindingSource
            // 
            this.cajaBindingSource.DataMember = "Caja";
            this.cajaBindingSource.DataSource = this.tiendaDeAbarrotesDataSet;
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.tiendaDeAbarrotesDataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // cajaTableAdapter
            // 
            this.cajaTableAdapter.ClearBeforeFill = true;
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 383);
            this.Controls.Add(this.rdbBancos);
            this.Controls.Add(this.rdbCaja);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtPiezas);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeAbarrotesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtPiezas;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label label6;
        private Tienda_de_Abarrotes.tiendaDeAbarrotesDataSet tiendaDeAbarrotesDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource cajaBindingSource;
        private tiendaDeAbarrotesDataSetTableAdapters.CajaTableAdapter cajaTableAdapter;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private tiendaDeAbarrotesDataSetTableAdapters.BancosTableAdapter bancosTableAdapter;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.RadioButton rdbCaja;
        private System.Windows.Forms.RadioButton rdbBancos;
    }
}

