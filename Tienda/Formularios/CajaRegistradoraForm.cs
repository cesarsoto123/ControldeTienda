using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void cajaRegistradoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cajaRegistradoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            }
            else
            {
                string ubicacion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD\\Tienda.mdb";
                string consulta = "Select * FROM Productos WHERE idProducto =" + idProducto_tbx.Text;
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = ubicacion;
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                conexion.Open();
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable Tabla = ds.Tables[0];
                if (Tabla.Rows.Count > 0)
                {
                    
                }
            }
        }
    }
}
