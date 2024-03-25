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
            button1 = new Button();
            dGVVendas = new DataGridView();
            tBCódigo = new TextBox();
            lbTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTotal = new Label();
            lblData = new Label();
            lblHora = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVVendas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(408, 137);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(170, 35);
            button1.TabIndex = 0;
            button1.Text = "Testar Banco";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyDown += pressionarTecla;
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
            tBCódigo.Location = new Point(408, 100);
            tBCódigo.Margin = new Padding(4);
            tBCódigo.Name = "tBCódigo";
            tBCódigo.Size = new Size(170, 29);
            tBCódigo.TabIndex = 2;
            tBCódigo.KeyDown += pressionarTecla;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.Transparent;
            lbTotal.Font = new Font("Arial", 46F);
            lbTotal.ForeColor = Color.Olive;
            lbTotal.Location = new Point(1028, 765);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(356, 69);
            lbTotal.TabIndex = 4;
            lbTotal.Text = "R$ 11111,11";
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
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1440, 881);
            Controls.Add(lblHora);
            Controls.Add(lblData);
            Controls.Add(lblTotal);
            Controls.Add(lbTotal);
            Controls.Add(tBCódigo);
            Controls.Add(dGVVendas);
            Controls.Add(button1);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private Button button1;
        private DataGridView dGVVendas;
        private TextBox tBCódigo;
        private Label lbTotal;
        private System.Windows.Forms.Timer timer1;
        private Label lblTotal;
        private Label lblData;
        private Label lblHora;
    }
}