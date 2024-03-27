namespace Paobom
{
    partial class FormDesconto
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
            lblDesconto = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.ForeColor = Color.Black;
            lblDesconto.Location = new Point(12, 9);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(152, 22);
            lblDesconto.TabIndex = 12;
            lblDesconto.Text = "Desconto (Valor)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 29);
            textBox1.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 26);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Porcentual";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 101);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 26);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Reais";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(294, 101);
            button1.Name = "button1";
            button1.Size = new Size(92, 38);
            button1.TabIndex = 16;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormDesconto
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 151);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(lblDesconto);
            Font = new Font("Arial", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormDesconto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desconto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesconto;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}