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
            button1 = new Button();
            dGVVendas = new DataGridView();
            tBCódigo = new TextBox();
            btnRemover = new Button();
            lbTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dGVVendas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(425, 139);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 0;
            button1.Text = "Testar Banco";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dGVVendas
            // 
            dGVVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dGVVendas.BackgroundColor = SystemColors.Control;
            dGVVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVVendas.Location = new Point(597, 13);
            dGVVendas.Margin = new Padding(4);
            dGVVendas.Name = "dGVVendas";
            dGVVendas.Size = new Size(834, 478);
            dGVVendas.TabIndex = 1;
            // 
            // tBCódigo
            // 
            tBCódigo.Location = new Point(414, 100);
            tBCódigo.Margin = new Padding(4);
            tBCódigo.Name = "tBCódigo";
            tBCódigo.Size = new Size(164, 29);
            tBCódigo.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(425, 181);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(143, 33);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover Produto";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(749, 543);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(0, 22);
            lbTotal.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1444, 688);
            Controls.Add(lbTotal);
            Controls.Add(btnRemover);
            Controls.Add(tBCódigo);
            Controls.Add(dGVVendas);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)dGVVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dGVVendas;
        private TextBox tBCódigo;
        private Button btnRemover;
        private Label lbTotal;
        private System.Windows.Forms.Timer timer1;
    }
}