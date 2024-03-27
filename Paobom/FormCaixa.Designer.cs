namespace Paobom
{
    partial class FormCaixa
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
            button2.Location = new Point(261, 62);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 5;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 29);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormCaixa
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 108);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Font = new Font("Arial", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
    }
}