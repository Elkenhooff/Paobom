namespace Paobom
{
    partial class FormListaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaProdutos));
            dGVProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGVProdutos).BeginInit();
            SuspendLayout();
            // 
            // dGVProdutos
            // 
            dGVProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGVProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVProdutos.Location = new Point(14, 13);
            dGVProdutos.Margin = new Padding(5, 4, 5, 4);
            dGVProdutos.Name = "dGVProdutos";
            dGVProdutos.Size = new Size(1219, 625);
            dGVProdutos.TabIndex = 0;
            // 
            // FormListaProdutos
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1256, 660);
            Controls.Add(dGVProdutos);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListaProdutos";
            Text = "FormListaProdutos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dGVProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGVProdutos;
    }
}