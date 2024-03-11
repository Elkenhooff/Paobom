namespace Paobom
{
    partial class FormListaFuncionarios
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
            dGVFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGVFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dGVFuncionarios
            // 
            dGVFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGVFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFuncionarios.Location = new Point(12, 12);
            dGVFuncionarios.Name = "dGVFuncionarios";
            dGVFuncionarios.Size = new Size(1233, 636);
            dGVFuncionarios.TabIndex = 0;
            // 
            // FormListaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 660);
            Controls.Add(dGVFuncionarios);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListaFuncionarios";
            Text = "Lista Funcionários";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dGVFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGVFuncionarios;
    }
}