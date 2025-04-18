using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP_ClientesFacturacion
{
    public partial class CrearFacturaConProductos : Form
    {

        private List<FacturaDetalle> carrito = new List<FacturaDetalle>();
        private decimal total = 0m;
        public CrearFacturaConProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearFacturaConProductos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            using (var db = new AppDbContext())
            {
                // Clientes
                cbClientes.DataSource = db.Clientes.ToList();
                cbClientes.DisplayMember = "Nombre";
                cbClientes.ValueMember = "Id";

                // Productos
                cbProductos.DataSource = db.Productos.ToList();
                cbProductos.DisplayMember = "Nombre";
                cbProductos.ValueMember = "Id";
            }

            nudCantidad.Value = 1;
            dgvCarrito.AutoGenerateColumns = false;

            // Configurar columnas del DataGridView
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = cbProductos.SelectedItem as Producto;
            int cantidad = (int)nudCantidad.Value;

            if (producto == null || cantidad <= 0)
            {
                MessageBox.Show("Seleccioná un producto y cantidad válida.");
                return;
            }

            // Crear línea de detalle
            var detalle = new FacturaDetalle
            {
                ProductoId = producto.Id,
                Producto = producto,
                Cantidad = cantidad
            };

            carrito.Add(detalle);
            total += detalle.Subtotal;

            // Refrescar tabla
            dgvCarrito.Rows.Add(producto.Nombre, producto.Precio.ToString("C"), cantidad, detalle.Subtotal.ToString("C"));
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exportaciones", "FacturasConProductos");
                Directory.CreateDirectory(carpeta);

                string nombreArchivo = Path.Combine(carpeta, $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();

                var cliente = cbClientes.SelectedItem as Cliente;

                var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                // Título
                Paragraph titulo = new Paragraph("Factura con Productos", fuenteTitulo)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20f
                };
                doc.Add(titulo);

                // Info cliente
                doc.Add(new Paragraph($"Cliente: {cliente.Nombre}", fuenteNormal));
                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fuenteNormal));
                doc.Add(new Paragraph(" ", fuenteNormal));

                // Tabla
                PdfPTable tabla = new PdfPTable(4);
                tabla.WidthPercentage = 100;
                tabla.AddCell("Producto");
                tabla.AddCell("Precio");
                tabla.AddCell("Cantidad");
                tabla.AddCell("Subtotal");

                foreach (var d in carrito)
                {
                    tabla.AddCell(d.Producto.Nombre);
                    tabla.AddCell($"{d.Producto.Precio:C}");
                    tabla.AddCell(d.Cantidad.ToString());
                    tabla.AddCell($"{d.Subtotal:C}");
                }

                doc.Add(tabla);
                doc.Add(new Paragraph(" ", fuenteNormal));
                doc.Add(new Paragraph($"TOTAL: {total:C}", fuenteTitulo));
                doc.Close();

                MessageBox.Show($"Factura generada correctamente en:\n{nombreArchivo}", "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Principal nuevaVentana = new Menu_Principal();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
