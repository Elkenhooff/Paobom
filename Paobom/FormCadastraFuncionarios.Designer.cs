namespace Paobom
{
    partial class FormCadastraFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraFuncionarios));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnInserir = new Button();
            dateTimePicker2 = new DateTimePicker();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            textBox2 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-7, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1455, 252);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 14F);
            groupBox1.Location = new Point(12, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1416, 607);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(481, 435);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(345, 78);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Testando banco";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(842, 77);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 34);
            dateTimePicker2.TabIndex = 29;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Ativo", "Inativo", "Licença", "Suspenso", "Férias" });
            comboBox4.Location = new Point(842, 306);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(200, 34);
            comboBox4.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Madrugada" });
            comboBox2.Location = new Point(842, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 34);
            comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Gerente", "Padeiro", "Confeiteiro", "Atendente de Balcão", "Caixa", "Auxiliar de Produção", "Entregador", "Auxiliar de Limpeza" });
            comboBox3.Location = new Point(457, 134);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 34);
            comboBox3.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(842, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 111);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Beneficios";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 82);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(227, 31);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Auxílio-Transporte";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 53);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(218, 31);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Vale-Alimentação";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(207, 31);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Plano de Saúde";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Madrugada" });
            comboBox1.Location = new Point(457, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 34);
            comboBox1.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(457, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 34);
            textBox4.TabIndex = 22;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(457, 191);
            maskedTextBox3.Mask = "$ 00000.00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(279, 34);
            maskedTextBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 34);
            textBox2.TabIndex = 19;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 328);
            maskedTextBox2.Mask = "+55 (00) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(218, 34);
            maskedTextBox2.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 271);
            maskedTextBox1.Mask = "+55 (00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(218, 34);
            maskedTextBox1.TabIndex = 17;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 191);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 52);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 34);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 34);
            textBox1.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 303);
            label14.Name = "label14";
            label14.Size = new Size(271, 27);
            label14.TabIndex = 13;
            label14.Text = "Telefone de Emergência";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(842, 281);
            label13.Name = "label13";
            label13.Size = new Size(220, 27);
            label13.TabIndex = 12;
            label13.Text = "Status de Emprego";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(842, 223);
            label12.Name = "label12";
            label12.Size = new Size(126, 27);
            label12.TabIndex = 11;
            label12.Text = "Supervisor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(457, 278);
            label10.Name = "label10";
            label10.Size = new Size(224, 27);
            label10.TabIndex = 9;
            label10.Text = "Horário de Trabalho";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 52);
            label9.Name = "label9";
            label9.Size = new Size(272, 27);
            label9.TabIndex = 8;
            label9.Text = "Numero de Identificação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 109);
            label8.Name = "label8";
            label8.Size = new Size(229, 27);
            label8.TabIndex = 7;
            label8.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 246);
            label7.Name = "label7";
            label7.Size = new Size(102, 27);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 166);
            label6.Name = "label6";
            label6.Size = new Size(115, 27);
            label6.TabIndex = 5;
            label6.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(842, 52);
            label5.Name = "label5";
            label5.Size = new Size(206, 27);
            label5.TabIndex = 4;
            label5.Text = "Data de Admissão";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 223);
            label4.Name = "label4";
            label4.Size = new Size(69, 27);
            label4.TabIndex = 3;
            label4.Text = "Setor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 109);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 166);
            label2.Name = "label2";
            label2.Size = new Size(86, 27);
            label2.TabIndex = 1;
            label2.Text = "Salário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(75, 27);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // FormCadastraFuncionarios
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 877);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastraFuncionarios";
            Text = "FormCadastraFuncionarios";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox4;
        private Button btnInserir;
    }
}