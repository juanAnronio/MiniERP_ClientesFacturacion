namespace MiniERP_ClientesFacturacion
{
    partial class GestionClientes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvClientes = new DataGridView();
            Busqueda = new Label();
            textBuscar = new TextBox();
            btnPdf = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(217, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 54);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 176);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 139);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(102, 23);
            txtEmail.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(55, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(280, 240);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(439, 102);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(320, 217);
            dgvClientes.TabIndex = 10;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Busqueda
            // 
            Busqueda.AutoSize = true;
            Busqueda.Font = new Font("Segoe UI", 9F);
            Busqueda.Location = new Point(439, 75);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(45, 15);
            Busqueda.TabIndex = 11;
            Busqueda.Text = "Buscar:";
            Busqueda.Click += Busqueda_Click;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(490, 72);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(219, 23);
            textBuscar.TabIndex = 12;
            textBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(147, 315);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(122, 23);
            btnPdf.TabIndex = 13;
            btnPdf.Text = "Exportar a PDF";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 9);
            button4.Name = "button4";
            button4.Size = new Size(118, 22);
            button4.TabIndex = 14;
            button4.Text = "<-- Menu Principal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(button4);
            Controls.Add(btnPdf);
            Controls.Add(textBuscar);
            Controls.Add(Busqueda);
            Controls.Add(dgvClientes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionClientes";
            Text = "GestionClientes";
            Load += GestionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvClientes;
        private Label Busqueda;
        private TextBox textBuscar;
        private Button btnPdf;
        private Button button4;
    }
}