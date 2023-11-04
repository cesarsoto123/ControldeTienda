using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tienda.Formularios;
using static Tienda.TiendaDataSet;

namespace Tienda
{
    public partial class CajaRegistradoraForm : Form
    {
 
        Guid uuid = Guid.NewGuid();
        public CajaRegistradoraForm()
        {
            InitializeComponent();
        }

        

        static IContainer CellStyle(IContainer c) => c.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);

        private void CajaRegistradoraForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.tiendaDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.CajaRegistradora' Puede moverla o quitarla según sea necesario.
            this.cajaRegistradoraTableAdapter.Fill(this.tiendaDataSet.CajaRegistradora);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.ticketTableAdapter.Fill(this.tiendaDataSet.Ticket);
            this.ventasTableAdapter.Fill(this.tiendaDataSet.Ventas);
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
            if(metodoDePagoComboBox.Text=="Metodo de pago")
            {
                MessageBox.Show("Antes de ingresar cualquier producto debe de especificar el metodo de pago");
                return;
            }
            int idProducto = Convert.ToInt32(productosComboBox.SelectedValue);

            var inventario = this.inventarioTableAdapter.GetData().FirstOrDefault(f => f.IdProducto == idProducto);

            if (inventario == null || inventario.Stock == 0)
            {
                MessageBox.Show("No hay existencias de este producto.");
                return;
            }

            try
            {
                this.cajaRegistradoraTableAdapter.Insert(idProducto, 1);
                this.ventasTableAdapter.Insertar(uuid.ToString(), idProducto, metodoDePagoComboBox.Text, 1);
                var product = this.inventarioTableAdapter.GetData().FirstOrDefault(p => p.IdProducto == idProducto);
                product.Stock -= 1;
                this.inventarioTableAdapter.UpdateStock(product.Stock, product.IdProducto);
                this.ventasTableAdapter.Update(this.tiendaDataSet.Ventas);
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
           
            var data = this.cajaRegistradoraTableAdapter.GetData();

            var headerStyle = TextStyle.Default.SemiBold();
            if (!this.cajaRegistradoraTableAdapter.GetData().Any())
            {
                MessageBox.Show("Para generar un ticket primeramente de sebe de agregar un producto a la caja registradora");
            }
            else
            {
                if (metodoDePagoComboBox.Text == "Metodo de pago")
                {
                    MessageBox.Show("favor de llenar todos los espacios correspondientes");
                    return;
                }

                if (metodoDePagoComboBox.Text == "Efectivo")
                {
                    float dineroRecibido = Convert.ToSingle(efectivoRecibido_tbx.Text);
                    if (dineroRecibido < Convert.ToSingle(totalNum_lbl.Text))
                    {
                        MessageBox.Show("La transaccion no puede ser completada faltan: $" + Convert.ToString(Convert.ToSingle(totalNum_lbl.Text) - dineroRecibido));
                        return;
                    }
                }
                decimal total = Convert.ToDecimal(totalNum_lbl.Text);

                this.ticketTableAdapter.Insertar(uuid.ToString(), DateTime.Now, total);
                this.ticketTableAdapter.Update(this.tiendaDataSet.Ticket);

                var pdf = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);

                        page.Header()
                            .Container()
                            .Row(row =>
                            {
                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().Text("Ticket").Style(new TextStyle().ExtraBold());

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Fecha: ").SemiBold();
                                        text.Span($"{DateTime.Now:d}");
                                    });
                                });

                                row.ConstantItem(100).Height(50).Placeholder();
                            });

                        page.Content()
                            .Container()
                            .PaddingVertical(40)
                            .Column(column =>
                            {
                                column.Spacing(20);

                                column.Item()
                                    .Container()
                                    .Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.ConstantColumn(25);
                                            columns.RelativeColumn(2);
                                            columns.RelativeColumn(4);
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                        });

                                        table.Header(header =>
                                        {
                                            header.Cell().Text("#");
                                            header.Cell().Text("Producto").Style(headerStyle);
                                            header.Cell().AlignRight().Text("Precio unitario").Style(headerStyle);
                                            header.Cell().AlignRight().Text("Cantidad").Style(headerStyle);
                                            header.Cell().AlignRight().Text("Total").Style(headerStyle);

                                            header.Cell().ColumnSpan(5).PaddingTop(5).BorderBottom(1).BorderColor(Colors.Black);
                                        });

                                        for (int i = 0; i < data.Count; i++)
                                        {
                                            ProductosRow producto = this.productosTableAdapter.GetData().FindByIdProduto(data[i].IdProducto);

                                            table.Cell().Element(CellStyle).Text($"{i}");
                                            table.Cell().Element(CellStyle).Text(producto.Nombre);
                                            table.Cell().Element(CellStyle).AlignRight().Text($"{producto.Precio:C}");
                                            table.Cell().Element(CellStyle).AlignRight().Text($"{data[i].Cantidad}");
                                            table.Cell().Element(CellStyle).AlignRight().Text($"{producto.Precio * data[i].Cantidad:C}");

                                            
                                        }
                                    });

                                column.Item().PaddingRight(5).AlignRight().Text($"Metodo de pago: {metodoDePagoComboBox.Text:C}").SemiBold();

                                if (metodoDePagoComboBox.Text == "Efectivo")
                                    column.Item().PaddingRight(5).AlignRight().Text($"Efectivo recibido: {Convert.ToDecimal(efectivoRecibido_tbx.Text):C}").SemiBold();
                                else
                                    column.Item().PaddingRight(5).AlignRight().Text($"Dinero recibido: {total:C}").SemiBold();

                                column.Item().PaddingRight(5).AlignRight().Text($"Total: {total:C}").SemiBold();
                                if (metodoDePagoComboBox.Text == "Efectivo")
                                {
                                    float cambio = Convert.ToSingle(efectivoRecibido_tbx.Text) - Convert.ToSingle(totalNum_lbl.Text);
                                    column.Item().PaddingRight(5).AlignRight().Text($"Cambio: {cambio:C}").SemiBold();
                                }
                                else
                                {
                                    decimal cambio = total - Convert.ToDecimal(totalNum_lbl.Text);
                                    column.Item().PaddingRight(5).AlignRight().Text($"Cambio: {cambio:C}").SemiBold();
                                }
                                column.Item().PaddingRight(5).AlignLeft().Text($"Folio: {uuid.ToString():C}").SemiBold();

                            });
                    });
                }).GeneratePdf();

                var file = File.OpenWrite("ticket.pdf");
                var writer = new BinaryWriter(file);
                writer.Write(pdf);
                file.Close();

                System.Diagnostics.Process.Start("ticket.pdf");

                MessageBox.Show("Compra exitosa y ticket generado.");
                
                this.cajaRegistradoraTableAdapter.DeleteAll();

                cajaRegistradoraDataGridView.DataSource = this.cajaRegistradoraTableAdapter.GetData();
                cajaRegistradoraDataGridView.Refresh();

                totalNum_lbl.Text = "0.00";
                efectivoRecibido_tbx.Text = "0.00";
                metodoDePagoComboBox.Text = "Metdodo de pago";

               
            }
        }

        public static void generar_Ticket()
        {

        }

        private void ProductosButtonClick(object sender, EventArgs e)
        {
            ProductosForm productos = new ProductosForm();
            
            productos.Show();
        }

        private void DeleteProductFromCaja(object sender, DataGridViewRowCancelEventArgs e)
        {
            var noArticulo = e.Row.Cells[0].Value.ToString();
            var idProducto = e.Row.Cells[1].Value.ToString();
            var id = Convert.ToInt32(noArticulo);
            var idProduct = Convert.ToInt32(idProducto);
            this.cajaRegistradoraTableAdapter.DeleteItem(id);
            this.ventasTableAdapter.DelateItem(idProduct);
            var productoInventario = this.inventarioTableAdapter.GetData().FirstOrDefault(p => p.IdProducto == idProduct);
            var producto = this.productosTableAdapter.GetData().FirstOrDefault(p => p.IdProduto == idProduct);
            productoInventario.Stock += 1;
            this.inventarioTableAdapter.UpdateStock(productoInventario.Stock, productoInventario.IdProducto);

            var total = Convert.ToDecimal(totalNum_lbl.Text) - producto.Precio;
            totalNum_lbl.Text = total.ToString();
        }

        private void metodoDePagoComboBox_TextChanged(object sender, EventArgs e)
        {
            if (metodoDePagoComboBox.Text == "Efectivo")
            {
                efectivoRecibido_lbl.Enabled=true;
                efectivoRecibido_tbx.Enabled = true;
            }
            else
            {
                efectivoRecibido_lbl.Enabled = false;
                efectivoRecibido_tbx.Enabled = false;
            }
        }

        private void TicketButtonClick(object sender, EventArgs e)
        {
            TicketsForm tickets = new TicketsForm();
            tickets.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasForm ventas = new VentasForm();
            ventas.Show();
        }
    }
}
