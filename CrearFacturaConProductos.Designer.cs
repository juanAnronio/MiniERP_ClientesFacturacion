namespace MiniERP_ClientesFacturacion
{
    partial class CrearFacturaConProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCliente = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            cbClientes = new ComboBox();
            cbProductos = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnGuardar = new Button();
            dgvCarrito = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(93, 112);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(93, 154);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(93, 197);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(93, 240);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: 0.00";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(199, 109);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(121, 23);
            cbClientes.TabIndex = 4;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(199, 151);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(121, 23);
            cbProductos.TabIndex = 5;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(200, 195);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 307);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(200, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(156, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Generar Factura en PDF";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(415, 109);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(340, 329);
            dgvCarrito.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(520, 54);
            label1.TabIndex = 10;
            label1.Text = "Crear Factura con Productos";
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 11;
            button1.Text = "<-- Menu Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CrearFacturaConProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvCarrito);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(cbProductos);
            Controls.Add(cbClientes);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            Name = "CrearFacturaConProductos";
            Text = "CrearFacturaConProductos";
            Load += CrearFacturaConProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblTotal;
        private ComboBox cbClientes;
        private ComboBox cbProductos;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnGuardar;
        private DataGridView dgvCarrito;
        private Label label1;
        private Button button1;
    }
}