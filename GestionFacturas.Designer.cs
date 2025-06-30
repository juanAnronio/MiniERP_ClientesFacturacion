namespace MiniERP_ClientesFacturacion
{
    partial class GestionFacturas
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
            label1 = new Label();
            lblCliente = new Label();
            button1 = new Button();
            cbClientes = new ComboBox();
            txtTotal = new TextBox();
            TituloPrincipal = new Label();
            dgvFacturas = new DataGridView();
            btnPDF = new Button();
            btonEliminar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(104, 156);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(91, 111);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // button1
            // 
            button1.Location = new Point(54, 224);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 2;
            button1.Text = "Crear Factura";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(161, 110);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(144, 23);
            cbClientes.TabIndex = 3;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(161, 155);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(144, 23);
            txtTotal.TabIndex = 4;
            // 
            // TituloPrincipal
            // 
            TituloPrincipal.AutoSize = true;
            TituloPrincipal.Font = new Font("Segoe UI", 30F);
            TituloPrincipal.Location = new Point(224, 9);
            TituloPrincipal.Name = "TituloPrincipal";
            TituloPrincipal.Size = new Size(353, 54);
            TituloPrincipal.TabIndex = 5;
            TituloPrincipal.Text = "Gestion de Factura";
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(392, 110);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.Size = new Size(371, 328);
            dgvFacturas.TabIndex = 6;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(161, 224);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(98, 23);
            btnPDF.TabIndex = 7;
            btnPDF.Text = "Generar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += button2_Click;
            // 
            // btonEliminar
            // 
            btonEliminar.Location = new Point(276, 224);
            btonEliminar.Name = "btonEliminar";
            btonEliminar.Size = new Size(98, 23);
            btonEliminar.TabIndex = 8;
            btonEliminar.Text = "Eliminar";
            btonEliminar.UseVisualStyleBackColor = true;
            btonEliminar.Click += btonEliminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 9);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 9;
            button2.Text = "<-- Menu Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // GestionFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btonEliminar);
            Controls.Add(btnPDF);
            Controls.Add(dgvFacturas);
            Controls.Add(TituloPrincipal);
            Controls.Add(txtTotal);
            Controls.Add(cbClientes);
            Controls.Add(button1);
            Controls.Add(lblCliente);
            Controls.Add(label1);
            Name = "GestionFacturas";
            Text = "GestionFacturas";
            Load += GestionFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCliente;
        private Button button1;
        private ComboBox cbClientes;
        private TextBox txtTotal;
        private Label TituloPrincipal;
        private DataGridView dgvFacturas;
        private Button btnPDF;
        private Button btonEliminar;
        private Button button2;
    }
}