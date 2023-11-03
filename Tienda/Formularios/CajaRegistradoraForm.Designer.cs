
namespace Tienda
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cajaRegistradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaRegistradoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cajaRegistradoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tiendaDataSet = new Tienda.TiendaDataSet();
            this.idProducto_lbl = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.finalizarCompra_btn = new System.Windows.Forms.Button();
            this.total_lbl = new System.Windows.Forms.Label();
            this.totalNum_lbl = new System.Windows.Forms.Label();
            this.cajaRegistradoraTableAdapter = new Tienda.TiendaDataSetTableAdapters.CajaRegistradoraTableAdapter();
            this.tableAdapterManager = new Tienda.TiendaDataSetTableAdapters.TableAdapterManager();
            this.cajaRegistradoraDataGridView = new System.Windows.Forms.DataGridView();
            this.cajaRegistradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Tienda.TiendaDataSetTableAdapters.ClientesTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Tienda.TiendaDataSetTableAdapters.ProductosTableAdapter();
            this.productosComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingNavigator)).BeginInit();
            this.cajaRegistradoraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaRegistradoraToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cajaRegistradoraToolStripMenuItem
            // 
            this.cajaRegistradoraToolStripMenuItem.Name = "cajaRegistradoraToolStripMenuItem";
            this.cajaRegistradoraToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cajaRegistradoraToolStripMenuItem.Text = "Caja Registradora";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // cajaRegistradoraBindingNavigator
            // 
            this.cajaRegistradoraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cajaRegistradoraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cajaRegistradoraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cajaRegistradoraBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cajaRegistradoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cajaRegistradoraBindingNavigatorSaveItem});
            this.cajaRegistradoraBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.cajaRegistradoraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cajaRegistradoraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cajaRegistradoraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cajaRegistradoraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cajaRegistradoraBindingNavigator.Name = "cajaRegistradoraBindingNavigator";
            this.cajaRegistradoraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cajaRegistradoraBindingNavigator.Size = new System.Drawing.Size(836, 27);
            this.cajaRegistradoraBindingNavigator.TabIndex = 1;
            this.cajaRegistradoraBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cajaRegistradoraBindingNavigatorSaveItem
            // 
            this.cajaRegistradoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cajaRegistradoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cajaRegistradoraBindingNavigatorSaveItem.Image")));
            this.cajaRegistradoraBindingNavigatorSaveItem.Name = "cajaRegistradoraBindingNavigatorSaveItem";
            this.cajaRegistradoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cajaRegistradoraBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cajaRegistradoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.cajaRegistradoraBindingNavigatorSaveItem_Click);
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
            this.agregar_btn.Size = new System.Drawing.Size(260, 27);
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
            this.finalizarCompra_btn.Location = new System.Drawing.Point(563, 172);
            this.finalizarCompra_btn.Name = "finalizarCompra_btn";
            this.finalizarCompra_btn.Size = new System.Drawing.Size(260, 27);
            this.finalizarCompra_btn.TabIndex = 6;
            this.finalizarCompra_btn.Text = "Finalizar Compra";
            this.finalizarCompra_btn.UseVisualStyleBackColor = true;
            this.finalizarCompra_btn.Click += new System.EventHandler(this.finalizarCompra_btn_Click);
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(3, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(125, 37);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "Total: $";
            // 
            // totalNum_lbl
            // 
            this.totalNum_lbl.AutoSize = true;
            this.totalNum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNum_lbl.Location = new System.Drawing.Point(134, 0);
            this.totalNum_lbl.Name = "totalNum_lbl";
            this.totalNum_lbl.Size = new System.Drawing.Size(80, 37);
            this.totalNum_lbl.TabIndex = 8;
            this.totalNum_lbl.Text = "0.00";
            // 
            // cajaRegistradoraTableAdapter
            // 
            this.cajaRegistradoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CajaRegistradoraTableAdapter = this.cajaRegistradoraTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MembresiaTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.SurtidoTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tienda.TiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // cajaRegistradoraDataGridView
            // 
            this.cajaRegistradoraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cajaRegistradoraDataGridView.AutoGenerateColumns = false;
            this.cajaRegistradoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cajaRegistradoraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noArticuloDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.cajaRegistradoraDataGridView.DataSource = this.cajaRegistradoraBindingSource;
            this.cajaRegistradoraDataGridView.Location = new System.Drawing.Point(10, 52);
            this.cajaRegistradoraDataGridView.Name = "cajaRegistradoraDataGridView";
            this.cajaRegistradoraDataGridView.RowHeadersWidth = 51;
            this.cajaRegistradoraDataGridView.Size = new System.Drawing.Size(544, 324);
            this.cajaRegistradoraDataGridView.TabIndex = 2;
            // 
            // cajaRegistradoraBindingSource
            // 
            this.cajaRegistradoraBindingSource.DataMember = "CajaRegistradora";
            this.cajaRegistradoraBindingSource.DataSource = this.tiendaDataSet;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.tiendaDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
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
            this.productosComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productosComboBox.Name = "productosComboBox";
            this.productosComboBox.Size = new System.Drawing.Size(260, 21);
            this.productosComboBox.TabIndex = 9;
            this.productosComboBox.ValueMember = "IdProduto";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.total_lbl);
            this.flowLayoutPanel1.Controls.Add(this.totalNum_lbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(563, 232);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 37);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // noArticuloDataGridViewTextBoxColumn
            // 
            this.noArticuloDataGridViewTextBoxColumn.DataPropertyName = "NoArticulo";
            this.noArticuloDataGridViewTextBoxColumn.HeaderText = "NoArticulo";
            this.noArticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noArticuloDataGridViewTextBoxColumn.Name = "noArticuloDataGridViewTextBoxColumn";
            this.noArticuloDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 387);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.productosComboBox);
            this.Controls.Add(this.finalizarCompra_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.idProducto_lbl);
            this.Controls.Add(this.cajaRegistradoraDataGridView);
            this.Controls.Add(this.cajaRegistradoraBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Krustacio Kaskarudo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingNavigator)).EndInit();
            this.cajaRegistradoraBindingNavigator.ResumeLayout(false);
            this.cajaRegistradoraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaRegistradoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
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
        private TiendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cajaRegistradoraBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cajaRegistradoraBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idProducto_lbl;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button finalizarCompra_btn;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label totalNum_lbl;
        private System.Windows.Forms.DataGridView cajaRegistradoraDataGridView;
        private System.Windows.Forms.BindingSource cajaRegistradoraBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private TiendaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TiendaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ComboBox productosComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}

