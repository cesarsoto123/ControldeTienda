using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Formularios
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);

        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiendaDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.tiendaDataSet.Ticket);

        }
    }
}
