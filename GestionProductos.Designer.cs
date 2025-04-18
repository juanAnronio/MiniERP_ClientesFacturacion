namespace MiniERP_ClientesFacturacion
{
    partial class GestionProductos
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            dgvProductos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 106);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 165);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(194, 162);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(141, 23);
            txtPrecio.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(451, 94);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(337, 344);
            dgvProductos.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(63, 296);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 5;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 296);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 6;
            button2.Text = "Eliminar seleccionado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(214, 9);
            label3.Name = "label3";
            label3.Size = new Size(347, 54);
            label3.TabIndex = 7;
            label3.Text = "Gestion Productos";
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 8;
            button3.Text = "<-- Menu Principal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvProductos);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionProductos";
            Text = "GestionProductos";
            Load += GestionProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private DataGridView dgvProductos;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
    }
}