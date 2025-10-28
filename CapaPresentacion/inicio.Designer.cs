namespace CapaPresentacion
{
    partial class inicio
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
            menu = new MenuStrip();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            manuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            menuProveedor = new FontAwesome.Sharp.IconMenuItem();
            menuInventario = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuInicio = new MenuStrip();
            label1 = new Label();
            contenedor = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuClientes, manuVentas, menuCompras, menuProveedor, menuInventario, menuReportes });
            menu.Location = new Point(0, 78);
            menu.Name = "menu";
            menu.Size = new Size(1084, 78);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 74);
            menuClientes.Text = " Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // manuVentas
            // 
            manuVentas.AutoSize = false;
            manuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            manuVentas.IconColor = Color.Black;
            manuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            manuVentas.IconSize = 50;
            manuVentas.ImageScaling = ToolStripItemImageScaling.None;
            manuVentas.Name = "manuVentas";
            manuVentas.Size = new Size(80, 74);
            manuVentas.Text = "Ventas";
            manuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 74);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuProveedor
            // 
            menuProveedor.AutoSize = false;
            menuProveedor.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuProveedor.IconColor = Color.Black;
            menuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedor.IconSize = 50;
            menuProveedor.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedor.Name = "menuProveedor";
            menuProveedor.Size = new Size(88, 74);
            menuProveedor.Text = "Proveedores";
            menuProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuInventario
            // 
            menuInventario.AutoSize = false;
            menuInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            menuInventario.IconColor = Color.Black;
            menuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuInventario.IconSize = 50;
            menuInventario.ImageScaling = ToolStripItemImageScaling.None;
            menuInventario.Name = "menuInventario";
            menuInventario.Size = new Size(80, 74);
            menuInventario.Text = "Inventario";
            menuInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(80, 74);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuInicio
            // 
            menuInicio.AutoSize = false;
            menuInicio.BackColor = Color.SteelBlue;
            menuInicio.ImageScalingSize = new Size(20, 20);
            menuInicio.Location = new Point(0, 0);
            menuInicio.Name = "menuInicio";
            menuInicio.RightToLeft = RightToLeft.Yes;
            menuInicio.Size = new Size(1084, 78);
            menuInicio.TabIndex = 1;
            menuInicio.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 2;
            label1.Text = "Sistema Control de Inventario";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 156);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1084, 372);
            contenedor.TabIndex = 3;
            contenedor.Paint += panel1_Paint;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 528);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menuInicio);
            MainMenuStrip = menu;
            Name = "inicio";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuInicio;
        private FontAwesome.Sharp.IconMenuItem menuProveedor;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem manuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuInventario;
        private Panel contenedor;
    }
}
