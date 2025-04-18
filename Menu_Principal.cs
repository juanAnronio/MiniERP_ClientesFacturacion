namespace MiniERP_ClientesFacturacion
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_GestClient_Click(object sender, EventArgs e)
        {
            GestionClientes nuevaVentana = new GestionClientes();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btn_CrearFactura_Click(object sender, EventArgs e)
        {
            GestionFacturas nuevaVentana = new GestionFacturas();
            nuevaVentana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearFacturaConProductos nuevaVentana = new CrearFacturaConProductos();
            nuevaVentana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionProductos nuevaVentana = new GestionProductos();
            nuevaVentana.Show();    
            this.Hide();
        }
    }
}
