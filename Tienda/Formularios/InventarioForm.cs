using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);

        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiendaDataSet.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);

        }
    }
}
