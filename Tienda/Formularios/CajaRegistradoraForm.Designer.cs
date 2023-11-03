
namespace Tienda
{
    partial class CajaRegistradoraForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cajaRegistradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaDataSet = new Tienda.TiendaDataSet();
            this.idProducto_lbl = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.finalizarCompra_btn = new System.Windows.Forms.Button();
            this.total_lbl = new System.Windows.Forms.Label();
            this.totalNum_lbl = new System.Windows.Forms.Label();
            this.cajaRegistradoraTableAdapter = new Tienda.TiendaDataSetTableAdapters.CajaRegistradoraTableAdapter();
            this.inventarioTableAdapter = new Tienda.TiendaDataSetTableAdapters.InventarioTableAdapter();
            this.tableAdapterManager = new Tienda.TiendaDataSetTableAdapters.TableAdapterManager();
            this.cajaRegistradoraDataGridView = new System.Windows.Forms.DataGridView();
            this.noArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajaRegistradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Tienda.TiendaDataSetTableAdapters.ProductosTableAdapter();
            this.productosComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metodoDePagoComboBox = new System.Windows.Forms.ComboBox();
            this.efectivoRecibido_lbl = new System.Windows.Forms.Label();
            this.efectivoRecibido_tbx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaRegistradoraToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cajaRegistradoraToolStripMenuItem
            // 
            this.cajaRegistradoraToolStripMenuItem.Name = "cajaRegistradoraToolStripMenuItem";
            this.cajaRegistradoraToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cajaRegistradoraToolStripMenuItem.Text = "Caja Registradora";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosButtonClick);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.InventarioButtonClick);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaButtonClick);
            // 
            // tiendaDataSet
            // 
            this.tiendaDataSet.DataSetName = "TiendaDataSet";
            this.tiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idProducto_lbl
            // 
            this.idProducto_lbl.AutoSize = true;
            this.idProducto_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_lbl.Location = new System.Drawing.Point(560, 52);
            this.idProducto_lbl.Name = "idProducto_lbl";
            this.idProducto_lbl.Size = new System.Drawing.Size(73, 20);
            this.idProducto_lbl.TabIndex = 3;
            this.idProducto_lbl.Text = "Producto";
            // 
            // agregar_btn
            // 
            this.agregar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.Location = new System.Drawing.Point(563, 114);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(368, 27);
            this.agregar_btn.TabIndex = 5;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.AddProductButtonClick);
            // 
            // finalizarCompra_btn
            // 
            this.finalizarCompra_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalizarCompra_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarCompra_btn.Location = new System.Drawing.Point(560, 363);
            this.finalizarCompra_btn.Name = "finalizarCompra_btn";
            this.finalizarCompra_btn.Size = new System.Drawing.Size(368, 27);
            this.finalizarCompra_btn.TabIndex = 6;
            this.finalizarCompra_btn.Text = "Finalizar Compra";
            this.finalizarCompra_btn.UseVisualStyleBackColor = true;
            this.finalizarCompra_btn.Click += new System.EventHandler(this.FinalizarCompraButtonClick);
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(3, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(119, 34);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "Total: $";
            // 
            // totalNum_lbl
            // 
            this.totalNum_lbl.AutoSize = true;
            this.totalNum_lbl.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNum_lbl.Location = new System.Drawing.Point(128, 0);
            this.totalNum_lbl.Name = "totalNum_lbl";
            this.totalNum_lbl.Size = new System.Drawing.Size(67, 34);
            this.totalNum_lbl.TabIndex = 8;
            this.totalNum_lbl.Text = "0.00";
            // 
            // cajaRegistradoraTableAdapter
            // 
            this.cajaRegistradoraTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaRegistradoraTableAdapter = this.cajaRegistradoraTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = this.inventarioTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tienda.TiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cajaRegistradoraDataGridView
            // 
            this.cajaRegistradoraDataGridView.AllowUserToAddRows = false;
            this.cajaRegistradoraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cajaRegistradoraDataGridView.AutoGenerateColumns = false;
            this.cajaRegistradoraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cajaRegistradoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cajaRegistradoraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noArticuloDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.cajaRegistradoraDataGridView.DataSource = this.cajaRegistradoraBindingSource;
            this.cajaRegistradoraDataGridView.Location = new System.Drawing.Point(10, 52);
            this.cajaRegistradoraDataGridView.Name = "cajaRegistradoraDataGridView";
            this.cajaRegistradoraDataGridView.ReadOnly = true;
            this.cajaRegistradoraDataGridView.RowHeadersWidth = 51;
            this.cajaRegistradoraDataGridView.Size = new System.Drawing.Size(544, 416);
            this.cajaRegistradoraDataGridView.TabIndex = 2;
            this.cajaRegistradoraDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteProductFromCaja);
            // 
            // noArticuloDataGridViewTextBoxColumn
            // 
            this.noArticuloDataGridViewTextBoxColumn.DataPropertyName = "NoArticulo";
            this.noArticuloDataGridViewTextBoxColumn.HeaderText = "NoArticulo";
            this.noArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noArticuloDataGridViewTextBoxColumn.Name = "noArticuloDataGridViewTextBoxColumn";
            this.noArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajaRegistradoraBindingSource
            // 
            this.cajaRegistradoraBindingSource.DataMember = "CajaRegistradora";
            this.cajaRegistradoraBindingSource.DataSource = this.tiendaDataSet;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.tiendaDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosComboBox
            // 
            this.productosComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productosComboBox.DataSource = this.productosBindingSource;
            this.productosComboBox.DisplayMember = "Nombre";
            this.productosComboBox.FormattingEnabled = true;
            this.productosComboBox.Location = new System.Drawing.Point(563, 80);
            this.productosComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productosComboBox.Name = "productosComboBox";
            this.productosComboBox.Size = new System.Drawing.Size(368, 21);
            this.productosComboBox.TabIndex = 9;
            this.productosComboBox.ValueMember = "IdProduto";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.total_lbl);
            this.flowLayoutPanel1.Controls.Add(this.totalNum_lbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(565, 159);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 37);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // metodoDePagoComboBox
            // 
            this.metodoDePagoComboBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoDePagoComboBox.FormattingEnabled = true;
            this.metodoDePagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Debito/Credito"});
            this.metodoDePagoComboBox.Location = new System.Drawing.Point(566, 249);
            this.metodoDePagoComboBox.Name = "metodoDePagoComboBox";
            this.metodoDePagoComboBox.Size = new System.Drawing.Size(131, 26);
            this.metodoDePagoComboBox.TabIndex = 12;
            this.metodoDePagoComboBox.Text = "Metodo de pago";
            // 
            // efectivoRecibido_lbl
            // 
            this.efectivoRecibido_lbl.AutoSize = true;
            this.efectivoRecibido_lbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoRecibido_lbl.Location = new System.Drawing.Point(703, 252);
            this.efectivoRecibido_lbl.Name = "efectivoRecibido_lbl";
            this.efectivoRecibido_lbl.Size = new System.Drawing.Size(126, 18);
            this.efectivoRecibido_lbl.TabIndex = 13;
            this.efectivoRecibido_lbl.Text = "Efectivo Recibido:";
            // 
            // efectivoRecibido_tbx
            // 
            this.efectivoRecibido_tbx.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoRecibido_tbx.Location = new System.Drawing.Point(833, 250);
            this.efectivoRecibido_tbx.Name = "efectivoRecibido_tbx";
            this.efectivoRecibido_tbx.Size = new System.Drawing.Size(100, 25);
            this.efectivoRecibido_tbx.TabIndex = 14;
            // 
            // CajaRegistradoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 479);
            this.Controls.Add(this.efectivoRecibido_tbx);
            this.Controls.Add(this.efectivoRecibido_lbl);
            this.Controls.Add(this.metodoDePagoComboBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.productosComboBox);
            this.Controls.Add(this.finalizarCompra_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.idProducto_lbl);
            this.Controls.Add(this.cajaRegistradoraDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CajaRegistradoraForm";
            this.Text = "Krustacio Kaskarudo";
            this.Load += new System.EventHandler(this.CajaRegistradoraForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cajaRegistradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private TiendaDataSet tiendaDataSet;
        private TiendaDataSetTableAdapters.CajaRegistradoraTableAdapter cajaRegistradoraTableAdapter;
        private TiendaDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private TiendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idProducto_lbl;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button finalizarCompra_btn;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label totalNum_lbl;
        private System.Windows.Forms.DataGridView cajaRegistradoraDataGridView;
        private System.Windows.Forms.BindingSource cajaRegistradoraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TiendaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ComboBox productosComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox metodoDePagoComboBox;
        private System.Windows.Forms.Label efectivoRecibido_lbl;
        private System.Windows.Forms.TextBox efectivoRecibido_tbx;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}

