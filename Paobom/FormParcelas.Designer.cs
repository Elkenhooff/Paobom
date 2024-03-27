namespace Paobom
{
    partial class FormParcelas
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
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(260, 60);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 7;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 29);
            textBox1.TabIndex = 6;
            // 
            // FormParcelas
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 107);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Font = new Font("Arial", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormParcelas";
            Text = "Parcelas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
    }
}