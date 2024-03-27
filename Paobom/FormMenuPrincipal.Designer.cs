namespace Paobom
{
    partial class FormMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            dGVVendas = new DataGridView();
            tBCódigo = new TextBox();
            lbTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTotal = new Label();
            lblData = new Label();
            lblHora = new Label();
            lblCaixa = new Label();
            lblNumCaixa = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVVendas).BeginInit();
            SuspendLayout();
            // 
            // dGVVendas
            // 
            dGVVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dGVVendas.BackgroundColor = SystemColors.Control;
            dGVVendas.BorderStyle = BorderStyle.Fixed3D;
            dGVVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVVendas.GridColor = Color.White;
            dGVVendas.Location = new Point(656, 218);
            dGVVendas.Margin = new Padding(4);
            dGVVendas.Name = "dGVVendas";
            dGVVendas.Size = new Size(728, 499);
            dGVVendas.TabIndex = 1;
            dGVVendas.KeyDown += pressionarTecla;
            // 
            // tBCódigo
            // 
            tBCódigo.BackColor = Color.Black;
            tBCódigo.BorderStyle = BorderStyle.None;
            tBCódigo.ForeColor = Color.White;
            tBCódigo.Location = new Point(13, 846);
            tBCódigo.Margin = new Padding(4);
            tBCódigo.Name = "tBCódigo";
            tBCódigo.Size = new Size(170, 22);
            tBCódigo.TabIndex = 2;
            tBCódigo.KeyDown += pressionarTecla;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.Transparent;
            lbTotal.Font = new Font("Arial", 46F);
            lbTotal.ForeColor = Color.Olive;
            lbTotal.Location = new Point(1057, 765);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(327, 69);
            lbTotal.TabIndex = 4;
            lbTotal.Text = "R$ 1111,11";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Arial", 46F);
            lblTotal.ForeColor = Color.Olive;
            lblTotal.Location = new Point(656, 765);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(315, 69);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Valor Total";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Arial", 46F);
            lblData.ForeColor = SystemColors.ControlLight;
            lblData.Location = new Point(656, 78);
            lblData.Name = "lblData";
            lblData.Size = new Size(183, 69);
            lblData.TabIndex = 11;
            lblData.Text = "21/03";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Arial", 46F);
            lblHora.ForeColor = SystemColors.ControlLight;
            lblHora.Location = new Point(1206, 78);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(178, 69);
            lblHora.TabIndex = 10;
            lblHora.Text = "15:11";
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.BackColor = Color.Transparent;
            lblCaixa.Font = new Font("Arial", 46F);
            lblCaixa.ForeColor = SystemColors.ControlLight;
            lblCaixa.Location = new Point(39, 78);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(187, 69);
            lblCaixa.TabIndex = 12;
            lblCaixa.Text = "Caixa";
            lblCaixa.Click += lblCaixa_Click;
            // 
            // lblNumCaixa
            // 
            lblNumCaixa.AutoSize = true;
            lblNumCaixa.BackColor = Color.Transparent;
            lblNumCaixa.Font = new Font("Arial", 46F);
            lblNumCaixa.ForeColor = SystemColors.ControlLight;
            lblNumCaixa.Location = new Point(232, 78);
            lblNumCaixa.Name = "lblNumCaixa";
            lblNumCaixa.Size = new Size(0, 69);
            lblNumCaixa.TabIndex = 13;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1440, 881);
            Controls.Add(lblNumCaixa);
            Controls.Add(lblCaixa);
            Controls.Add(lblHora);
            Controls.Add(lblData);
            Controls.Add(lblTotal);
            Controls.Add(lbTotal);
            Controls.Add(tBCódigo);
            Controls.Add(dGVVendas);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "FormMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPrincipal_FormClosing;
            KeyDown += pressionarTecla;
            ((System.ComponentModel.ISupportInitialize)dGVVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dGVVendas;
        private TextBox tBCódigo;
        private Label lbTotal;
        private System.Windows.Forms.Timer timer1;
        private Label lblTotal;
        private Label lblData;
        private Label lblHora;
        private Label lblCaixa;
        private Label lblNumCaixa;
    }
}