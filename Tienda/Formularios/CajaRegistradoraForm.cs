using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Formularios;

namespace Tienda
{
    public partial class Form1 : Form
    {
        private string TiendaConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["TiendaConnectionString"].ConnectionString;

        private readonly OleDbConnection conexion;

        public Form1()
        {
            InitializeComponent();
            conexion = new OleDbConnection
            {
                ConnectionString = TiendaConnectionString
            };
        }

        private void cajaRegistradoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cajaRegistradoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tiendaDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.CajaRegistradora' Puede moverla o quitarla según sea necesario.
            this.cajaRegistradoraTableAdapter.Fill(this.tiendaDataSet.CajaRegistradora);

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioForm Inventario = new InventarioForm();
            Inventario.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm Ayuda = new AyudaForm();
            Ayuda.Show();
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (idProducto_tbx.TextLength == 0)
            {
                MessageBox.Show("Complete el campo requerido");
                return;
            }

            DataSet ds = new DataSet();
            string insert = $"INSERT INTO CajaRegistradora (IdProducto, Cantidad) VALUES ({idProducto_tbx.Text}, 1)";
            string select = $"SELECT * FROM Productos";

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(insert, conexion);

            try
            {
                conexion.Open();

                adaptador.InsertCommand = command;
                var reader = command.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            adaptador.Fill(ds);

            adaptador.Update(ds, "Table");

            DataTable tabla = ds.Tables[0];

            cajaRegistradoraDataGridView.DataSource = tabla;
            cajaRegistradoraDataGridView.Refresh();

            conexion.Close();
        }
    }
}
