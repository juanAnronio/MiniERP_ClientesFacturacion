using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
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
    public partial class GestionFacturas : Form
    {
        public GestionFacturas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GestionFacturas_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            using (var db = new AppDbContext())
            {
                var clientes = db.Clientes.ToList();
                cbClientes.DataSource = clientes;
                cbClientes.DisplayMember = "Nombre";
                cbClientes.ValueMember = "Id";
            }

            CargarFacturas();

            if (cbClientes.SelectedValue != null)
            {
                int clienteId = (int)cbClientes.SelectedValue;
                CargarFacturasPorCliente(clienteId);
            }
        }

        private void CargarFacturas()
        {
            using (var db = new AppDbContext())
            {
                var lista = db.Facturas.Include(f => f.Cliente).ToList();
                db.Facturas.Include(f => f.Cliente).ToList();
                dgvFacturas.DataSource = lista;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedItem == null || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Seleccioná un cliente e ingresá un total.");
                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show("Total inválido.");
                return;
            }

            var clienteId = (int)cbClientes.SelectedValue;

            using (var db = new AppDbContext())
            {
                var factura = new Factura
                {
                    ClienteId = clienteId,
                    Fecha = DateTime.Now,
                    Total = total
                };

                db.Facturas.Add(factura);
                db.SaveChanges();
            }

            MessageBox.Show("Factura guardada correctamente.");

            txtTotal.Clear();
            CargarFacturas();
        }
        //Se mostraran en la lista solo las facturas generadas por el cliente que este seleccionado en el ComboBox
        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedValue == null || cbClientes.SelectedItem == null)
                return;

            var clienteSeleccionado = cbClientes.SelectedItem as Cliente;
            if (clienteSeleccionado == null) return;

            int clienteId = clienteSeleccionado.Id;
            CargarFacturasPorCliente(clienteId);
        }

        
        private void CargarFacturasPorCliente(int clienteId)
        {
            using (var db = new AppDbContext())
            {
                var lista = db.Facturas
                              .Where(f => f.ClienteId == clienteId)
                              .Include(f => f.Cliente)
                              .ToList();

                dgvFacturas.DataSource = lista;
            }
        }
        //

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una factura de la tabla.", "Atención");
                return;
            }

            var facturaSeleccionada = dgvFacturas.CurrentRow.DataBoundItem as Factura;
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la factura.");
                return;
            }

            // Crear el documento
            Document doc = new Document(PageSize.A5, 40, 40, 60, 40); // Tamaño A5 tipo recibo
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exportaciones", "Facturas");
            Directory.CreateDirectory(carpeta);

            string nombreArchivo = Path.Combine(carpeta, $"Factura_{facturaSeleccionada.Id}.pdf");

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();

                // Título
                var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph titulo = new Paragraph("Factura", fuenteTitulo)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20f
                };
                doc.Add(titulo);

                // Info factura
                var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 11);

                doc.Add(new Paragraph($"ID: {facturaSeleccionada.Id}", fuenteNormal));
                doc.Add(new Paragraph($"Cliente: {facturaSeleccionada.Cliente.Nombre}", fuenteNormal));
                doc.Add(new Paragraph($"Fecha: {facturaSeleccionada.Fecha.ToString("dd/MM/yyyy HH:mm")}", fuenteNormal));
                doc.Add(new Paragraph($"Total: {facturaSeleccionada.Total:C}", fuenteNormal));

                doc.Close();

                MessageBox.Show($"Factura exportada como '{nombreArchivo}'", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message);
            }
        }

        private void btonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una factura para eliminar.", "Atención");
                return;
            }

            var facturaSeleccionada = dgvFacturas.CurrentRow.DataBoundItem as Factura;

            if (facturaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la factura seleccionada.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés eliminar la factura #{facturaSeleccionada.Id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
                return;

            using (var db = new AppDbContext())
            {
                var factura = db.Facturas.Find(facturaSeleccionada.Id);

                if (factura != null)
                {
                    db.Facturas.Remove(factura);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Factura eliminada correctamente.");

            // Recargar la lista según el cliente actual
            var clienteActual = cbClientes.SelectedItem as Cliente;
            if (clienteActual != null)
                CargarFacturasPorCliente(clienteActual.Id);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu_Principal nuevaVentana = new Menu_Principal();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
