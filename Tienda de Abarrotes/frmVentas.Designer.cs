namespace Tienda_de_Abarrotes
{
    partial class frmVentas
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
            this.components = new System.ComponentModel.Container();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPiezas = new System.Windows.Forms.Label();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbPiezas = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rdbCaja = new System.Windows.Forms.RadioButton();
            this.rdbBancos = new System.Windows.Forms.RadioButton();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.tiendaDeAbarrotesDataSet = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Tienda_de_Abarrotes.tiendaDeAbarrotesDataSetTableAdapters.InventarioTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piezasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeAbarrotesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(153, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(109, 32);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(26, 67);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(98, 25);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezas.Location = new System.Drawing.Point(184, 67);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(77, 25);
            this.lblPiezas.TabIndex = 2;
            this.lblPiezas.Text = "Piezas";
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(31, 95);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(138, 26);
            this.txbProducto.TabIndex = 3;
            // 
            // txbPiezas
            // 
            this.txbPiezas.Location = new System.Drawing.Point(189, 95);
            this.txbPiezas.Name = "txbPiezas";
            this.txbPiezas.Size = new System.Drawing.Size(138, 26);
            this.txbPiezas.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 34);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(156, 160);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 34);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(300, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // rdbCaja
            // 
            this.rdbCaja.AutoSize = true;
            this.rdbCaja.Checked = true;
            this.rdbCaja.Location = new System.Drawing.Point(31, 241);
            this.rdbCaja.Name = "rdbCaja";
            this.rdbCaja.Size = new System.Drawing.Size(91, 24);
            this.rdbCaja.TabIndex = 8;
            this.rdbCaja.TabStop = true;
            this.rdbCaja.Text = "Efectivo";
            this.rdbCaja.UseVisualStyleBackColor = true;
            // 
            // rdbBancos
            // 
            this.rdbBancos.AutoSize = true;
            this.rdbBancos.Location = new System.Drawing.Point(31, 271);
            this.rdbBancos.Name = "rdbBancos";
            this.rdbBancos.Size = new System.Drawing.Size(131, 24);
            this.rdbBancos.TabIndex = 9;
            this.rdbBancos.TabStop = true;
            this.rdbBancos.Text = "Transferencia";
            this.rdbBancos.UseVisualStyleBackColor = true;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(27, 213);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(129, 20);
            this.lblPago.TabIndex = 10;
            this.lblPago.Text = "Método de pago:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(273, 294);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(333, 294);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(18, 20);
            this.lblValorTotal.TabIndex = 12;
            this.lblValorTotal.Text = "0";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoGenerateColumns = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.piezasDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dgvInventario.DataSource = this.inventarioBindingSource;
            this.dgvInventario.Location = new System.Drawing.Point(312, 188);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(101, 77);
            this.dgvInventario.TabIndex = 13;
            this.dgvInventario.Visible = false;
            // 
            // tiendaDeAbarrotesDataSet
            // 
            this.tiendaDeAbarrotesDataSet.DataSetName = "tiendaDeAbarrotesDataSet";
            this.tiendaDeAbarrotesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.tiendaDeAbarrotesDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // piezasDataGridViewTextBoxColumn
            // 
            this.piezasDataGridViewTextBoxColumn.DataPropertyName = "Piezas";
            this.piezasDataGridViewTextBoxColumn.HeaderText = "Piezas";
            this.piezasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.piezasDataGridViewTextBoxColumn.Name = "piezasDataGridViewTextBoxColumn";
            this.piezasDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Precio_Unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio_Unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor_Total";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 323);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.rdbBancos);
            this.Controls.Add(this.rdbCaja);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbPiezas);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.lblPiezas);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblVentas);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeAbarrotesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPiezas;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbPiezas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rdbCaja;
        private System.Windows.Forms.RadioButton rdbBancos;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridView dgvInventario;
        private tiendaDeAbarrotesDataSet tiendaDeAbarrotesDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private tiendaDeAbarrotesDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piezasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}