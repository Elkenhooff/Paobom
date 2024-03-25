namespace Paobom
{
    partial class FormPaoBom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaoBom));
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            listaFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            listaProdutoToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, menuPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendasToolStripMenuItem, funcionárioToolStripMenuItem, produtoToolStripMenuItem });
            sistemaToolStripMenuItem.Font = new Font("Arial", 14F);
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(91, 26);
            sistemaToolStripMenuItem.Text = "Sistema";
            sistemaToolStripMenuItem.Visible = false;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(178, 26);
            vendasToolStripMenuItem.Text = "Vendas";
            vendasToolStripMenuItem.Click += vendasToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeFuncionáriosToolStripMenuItem, listaFuncionáriosToolStripMenuItem });
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(178, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            cadastroDeFuncionáriosToolStripMenuItem.Size = new Size(297, 26);
            cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            cadastroDeFuncionáriosToolStripMenuItem.Click += cadastroDeFuncionáriosToolStripMenuItem_Click;
            // 
            // listaFuncionáriosToolStripMenuItem
            // 
            listaFuncionáriosToolStripMenuItem.Name = "listaFuncionáriosToolStripMenuItem";
            listaFuncionáriosToolStripMenuItem.Size = new Size(297, 26);
            listaFuncionáriosToolStripMenuItem.Text = "Lista Funcionários";
            listaFuncionáriosToolStripMenuItem.Click += listaFuncionáriosToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProdutosToolStripMenuItem, listaProdutoToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(178, 26);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.Size = new Size(266, 26);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            cadastroDeProdutosToolStripMenuItem.Click += cadastroDeProdutosToolStripMenuItem_Click;
            // 
            // listaProdutoToolStripMenuItem
            // 
            listaProdutoToolStripMenuItem.Name = "listaProdutoToolStripMenuItem";
            listaProdutoToolStripMenuItem.Size = new Size(266, 26);
            listaProdutoToolStripMenuItem.Text = "Lista Produtos";
            listaProdutoToolStripMenuItem.Click += listaProdutoToolStripMenuItem_Click;
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.Font = new Font("Arial", 14F);
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(145, 26);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click_1;
            // 
            // FormPaoBom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPaoBom";
            Text = "Paobom";
            WindowState = FormWindowState.Maximized;
            KeyDown += FormPaoBom_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem listaFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem listaProdutoToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
    }
}
