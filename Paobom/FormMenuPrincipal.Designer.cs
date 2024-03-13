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
            button1 = new Button();
            dGVVendas = new DataGridView();
            tBCódigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGVVendas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(229, 186);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 0;
            button1.Text = "Testar Banco";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dGVVendas
            // 
            dGVVendas.BackgroundColor = SystemColors.ButtonFace;
            dGVVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVVendas.Location = new Point(542, 12);
            dGVVendas.Name = "dGVVendas";
            dGVVendas.Size = new Size(886, 391);
            dGVVendas.TabIndex = 1;
            // 
            // tBCódigo
            // 
            tBCódigo.Location = new Point(339, 82);
            tBCódigo.Name = "tBCódigo";
            tBCódigo.Size = new Size(135, 26);
            tBCódigo.TabIndex = 2;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 563);
            Controls.Add(tBCódigo);
            Controls.Add(dGVVendas);
            Controls.Add(button1);
            Font = new Font("Arial", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
    }
}