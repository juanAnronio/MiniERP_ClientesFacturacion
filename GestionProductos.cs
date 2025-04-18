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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            CargarProductos();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ReadOnly = true;
        }

        private void CargarProductos()
        {
            using (var db = new AppDbContext())
            {
                dgvProductos.DataSource = db.Productos.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Completá los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            using (var db = new AppDbContext())
            {
                var nuevo = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = precio
                };

                db.Productos.Add(nuevo);
                db.SaveChanges();
            }

            txtNombre.Clear();
            txtPrecio.Clear();
            CargarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            var producto = dgvProductos.CurrentRow.DataBoundItem as Producto;

            if (producto == null) return;

            var confirm = MessageBox.Show($"¿Eliminar '{producto.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (var db = new AppDbContext())
            {
                var prod = db.Productos.Find(producto.Id);
                if (prod != null)
                {
                    db.Productos.Remove(prod);
                    db.SaveChanges();
                }
            }

            CargarProductos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_Principal nuevaVentana = new Menu_Principal();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
