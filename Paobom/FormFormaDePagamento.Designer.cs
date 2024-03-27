namespace Paobom
{
    partial class FormFormaDePagamento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 0;
            label1.Text = "1 - Débito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(155, 35);
            label2.TabIndex = 1;
            label2.Text = "2 - Crédito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 22F);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(170, 35);
            label3.TabIndex = 2;
            label3.Text = "3 - Dinheiro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22F);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(283, 35);
            label4.TabIndex = 3;
            label4.Text = "4 - Vale Alimentação";
            label4.Click += label4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormFormaDePagamento
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 157);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 14F);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFormaDePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forma de Pagamento";
            KeyDown += FormFormaDePagamento_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}