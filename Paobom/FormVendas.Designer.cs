namespace Paobom
{
    partial class FormVendas
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
            dataGridView1 = new DataGridView();
            gBvendas = new GroupBox();
            maskedTextBox6 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gBvendas.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1396, 678);
            dataGridView1.TabIndex = 0;
            // 
            // gBvendas
            // 
            gBvendas.Controls.Add(comboBox1);
            gBvendas.Controls.Add(label7);
            gBvendas.Controls.Add(button1);
            gBvendas.Controls.Add(maskedTextBox6);
            gBvendas.Controls.Add(label6);
            gBvendas.Controls.Add(maskedTextBox5);
            gBvendas.Controls.Add(label5);
            gBvendas.Controls.Add(maskedTextBox4);
            gBvendas.Controls.Add(label4);
            gBvendas.Controls.Add(maskedTextBox3);
            gBvendas.Controls.Add(label3);
            gBvendas.Controls.Add(maskedTextBox2);
            gBvendas.Controls.Add(label2);
            gBvendas.Controls.Add(maskedTextBox1);
            gBvendas.Controls.Add(label1);
            gBvendas.Location = new Point(12, 12);
            gBvendas.Name = "gBvendas";
            gBvendas.Size = new Size(507, 149);
            gBvendas.TabIndex = 1;
            gBvendas.TabStop = false;
            gBvendas.Text = "Filtro";
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(274, 107);
            maskedTextBox6.Mask = "00";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(106, 29);
            maskedTextBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 82);
            label6.Name = "label6";
            label6.Size = new Size(57, 22);
            label6.TabIndex = 11;
            label6.Text = "Caixa";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(274, 50);
            maskedTextBox5.Mask = "00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(106, 29);
            maskedTextBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 25);
            label5.Name = "label5";
            label5.Size = new Size(84, 22);
            label5.TabIndex = 9;
            label5.Text = "Parcelas";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(140, 107);
            maskedTextBox4.Mask = "$ 000.00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(106, 29);
            maskedTextBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 82);
            label4.Name = "label4";
            label4.Size = new Size(155, 22);
            label4.TabIndex = 7;
            label4.Text = "Valor (Abaixo de)";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(140, 50);
            maskedTextBox3.Mask = "$ 000.00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(106, 29);
            maskedTextBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 25);
            label3.Name = "label3";
            label3.Size = new Size(150, 22);
            label3.TabIndex = 6;
            label3.Text = "Valor (Acima de)";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 107);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(106, 29);
            maskedTextBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 4;
            label2.Text = "Horário";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 50);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(106, 29);
            maskedTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 0;
            label1.Text = "Data";
            // 
            // button1
            // 
            button1.Location = new Point(395, 107);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 25);
            label7.Name = "label7";
            label7.Size = new Size(107, 22);
            label7.TabIndex = 10;
            label7.Text = "Pagamento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Crédito", "Débito", "Dinheiro", "Ticket-Alimentação", "Sodexo", "VR", "Alelo" });
            comboBox1.Location = new Point(395, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 30);
            comboBox1.TabIndex = 13;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 857);
            Controls.Add(gBvendas);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendas";
            Text = "Vendas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gBvendas.ResumeLayout(false);
            gBvendas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gBvendas;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private MaskedTextBox maskedTextBox6;
        private Label label6;
        private MaskedTextBox maskedTextBox5;
        private Label label5;
        private MaskedTextBox maskedTextBox4;
        private Label label4;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
    }
}