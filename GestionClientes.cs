using iTextSharp.text.pdf;
using iTextSharp.text;
using MiniERP_ClientesFacturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MiniERP_ClientesFacturacion
{
    public partial class GestionClientes : Form
    {

        private bool menuExpandido = false;
        private int anchoMenu = 150;
        public GestionClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarClientes();
        }
        //btn Guardar Clientes
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EmailValido(txtEmail.Text))
            {
                MessageBox.Show("El email ingresado no tiene un formato válido.", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefono.Text.Length != 9 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe tener exactamente 9 números.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text
                };

                db.Clientes.Add(cliente);
                db.SaveChanges();
                CargarClientes();

                MessageBox.Show("Cliente guardado correctamente.");

                txtNombre.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();
            }
        }
        private bool EmailValido(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CargarClientes()
        {
            using (var db = new AppDbContext())
            {
                var lista = db.Clientes.ToList();
                dgvClientes.DataSource = lista;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Estás seguro de que querés eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
                return;

            var clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            using (var db = new AppDbContext())
            {
                db.Clientes.Remove(clienteSeleccionado);
                db.SaveChanges();
            }

            MessageBox.Show("Cliente eliminado correctamente.");
            CargarClientes();
        }

        private int clienteIdSeleccionado = -1;
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                txtNombre.Text = clienteSeleccionado.Nombre;
                txtEmail.Text = clienteSeleccionado.Email;
                txtTelefono.Text = clienteSeleccionado.Telefono;

                // Guardamos el ID en una variable para saber a quién estamos modificando
                clienteIdSeleccionado = clienteSeleccionado.Id;
            }
        }
        //Boton modificar
        private void button2_Click(object sender, EventArgs e)
        {
            if (clienteIdSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un cliente de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (!EmailValido(txtEmail.Text))
            {
                MessageBox.Show("El email no es válido.");
                return;
            }

            if (txtTelefono.Text.Length != 9 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe tener exactamente 9 números.");
                return;
            }

            using (var db = new AppDbContext())
            {
                var clienteExistente = db.Clientes.Find(clienteIdSeleccionado);

                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = txtNombre.Text;
                    clienteExistente.Email = txtEmail.Text;
                    clienteExistente.Telefono = txtTelefono.Text;

                    db.Clientes.Update(clienteExistente);
                    db.SaveChanges();

                    MessageBox.Show("Cliente modificado correctamente.");

                    // Limpiar
                    txtNombre.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    clienteIdSeleccionado = -1;

                    CargarClientes();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                string filtro = textBuscar.Text.ToLower();
                var resultados = db.Clientes
                    .Where(c => c.Nombre.ToLower().Contains(filtro) || c.Email.ToLower().Contains(filtro))
                    .ToList();
                dgvClientes.DataSource = resultados;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay clientes para exportar.");
                return;
            }

            // Crear el documento PDF
            Document doc = new Document(PageSize.A4);
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exportaciones", "Clientes");
            Directory.CreateDirectory(carpeta);

            string path = Path.Combine(carpeta, "ClientesExportados.pdf");

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                // Título
                Paragraph titulo = new Paragraph("Listado de Clientes")
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(titulo);
                doc.Add(new Paragraph(" "));

                PdfPTable tabla = new PdfPTable(dgvClientes.Columns.Count);
                tabla.WidthPercentage = 100;


                foreach (DataGridViewColumn col in dgvClientes.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(col.HeaderText));
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    tabla.AddCell(celda);
                }


                foreach (DataGridViewRow fila in dgvClientes.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            tabla.AddCell(celda.Value?.ToString() ?? "");
                        }
                    }
                }

                doc.Add(tabla);
                //Se guarda en bin\Debug\net8.0-windows\Exportaciones
                MessageBox.Show("PDF exportado correctamente en la carpeta del programa.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Principal nuevaVentana = new Menu_Principal();
            nuevaVentana.Show();
            this.Hide();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
