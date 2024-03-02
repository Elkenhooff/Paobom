namespace Paobom
{
    partial class FormCadastraProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraProdutos));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblValor = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 189);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 26);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Arial", 12F);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Unidade", "KG" });
            comboBox1.Location = new Point(6, 187);
            comboBox1.MaxLength = 1;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 26);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(7, 166);
            label6.Name = "label6";
            label6.Size = new Size(146, 18);
            label6.TabIndex = 10;
            label6.Text = "Unidade de Medida";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Arial", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(6, 343);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(221, 26);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 26);
            dateTimePicker1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Arial", 12F);
            maskedTextBox1.Location = new Point(6, 240);
            maskedTextBox1.Mask = "$ 000.00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(221, 26);
            maskedTextBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 26);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(6, 322);
            label5.Name = "label5";
            label5.Size = new Size(130, 18);
            label5.TabIndex = 5;
            label5.Text = "Data de Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(6, 272);
            label4.Name = "label4";
            label4.Size = new Size(148, 18);
            label4.TabIndex = 4;
            label4.Text = "Data de Fabricação";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Arial", 12F);
            lblValor.Location = new Point(6, 219);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(44, 18);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(6, 116);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 2;
            label2.Text = "Nome do Produto\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 1;
            label1.Text = "Código de Barra";
            // 
            // FormCadastraProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 622);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastraProdutos";
            Text = "FormCadastraProdutos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label lblValor;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Label label6;
    }
}