namespace MiniERP_ClientesFacturacion
{
    partial class Menu_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_GestClient = new Button();
            btn_CrearFactura = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(536, 101);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_GestClient
            // 
            btn_GestClient.Font = new Font("Segoe UI", 20F);
            btn_GestClient.Location = new Point(12, 133);
            btn_GestClient.Name = "btn_GestClient";
            btn_GestClient.Size = new Size(776, 68);
            btn_GestClient.TabIndex = 1;
            btn_GestClient.Text = "Gestionar Clientes";
            btn_GestClient.UseVisualStyleBackColor = true;
            btn_GestClient.Click += btn_GestClient_Click;
            // 
            // btn_CrearFactura
            // 
            btn_CrearFactura.Font = new Font("Segoe UI", 20F);
            btn_CrearFactura.Location = new Point(12, 207);
            btn_CrearFactura.Name = "btn_CrearFactura";
            btn_CrearFactura.Size = new Size(776, 68);
            btn_CrearFactura.TabIndex = 2;
            btn_CrearFactura.Text = "Crear Factura";
            btn_CrearFactura.UseVisualStyleBackColor = true;
            btn_CrearFactura.Click += btn_CrearFactura_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 281);
            button1.Name = "button1";
            button1.Size = new Size(776, 68);
            button1.TabIndex = 3;
            button1.Text = "Crear Factura con Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(12, 355);
            button2.Name = "button2";
            button2.Size = new Size(776, 68);
            button2.TabIndex = 4;
            button2.Text = "Gestion de Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_CrearFactura);
            Controls.Add(btn_GestClient);
            Controls.Add(label1);
            Name = "Menu_Principal";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_GestClient;
        private Button btn_CrearFactura;
        private Button button1;
        private Button button2;
    }
}
