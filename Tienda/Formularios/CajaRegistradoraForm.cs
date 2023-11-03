using System;
using System.Windows.Forms;
using Tienda.Formularios;
using static Tienda.TiendaDataSet;

namespace Tienda
{
    public partial class CajaRegistradoraForm : Form
    {
        public CajaRegistradoraForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.tiendaDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tiendaDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.CajaRegistradora' Puede moverla o quitarla según sea necesario.
            this.cajaRegistradoraTableAdapter.Fill(this.tiendaDataSet.CajaRegistradora);
        }

        private void SaveItemClick(object sender, EventArgs e)
        {
            this.Validate();
            this.cajaRegistradoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);
        }


        private void InventarioButtonClick(object sender, EventArgs e)
        {
            InventarioForm Inventario = new InventarioForm();
            Inventario.Show();
        }

        private void AyudaButtonClick(object sender, EventArgs e)
        {
            AyudaForm Ayuda = new AyudaForm();
            Ayuda.Show();
        }

        private void AddProductButtonClick(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(productosComboBox.SelectedValue);

            try
            {
                this.cajaRegistradoraTableAdapter.Insert(idProducto, 1);
                this.cajaRegistradoraTableAdapter.Update(this.tiendaDataSet.CajaRegistradora);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            cajaRegistradoraDataGridView.DataSource = this.cajaRegistradoraTableAdapter.GetData();
            cajaRegistradoraDataGridView.Refresh();

            ProductosRow producto = this.productosTableAdapter.GetData().FindByIdProduto(idProducto);
            var total = Convert.ToDecimal(totalNum_lbl.Text) + producto.Precio;
            totalNum_lbl.Text = total.ToString();
        }

        private void FinalizarCompraButtonClick(object sender, EventArgs e)
        {
            foreach (var row in this.cajaRegistradoraTableAdapter.GetData())
            {
                ProductosRow producto = this.productosTableAdapter.GetData().FindByIdProduto(row.IdProducto);
                Console.WriteLine($"{producto.Nombre} : {producto.Precio}");
            }
        }
    }
}
