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
            txtBarra = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            rTBObservacao = new RichTextBox();
            label7 = new Label();
            cBCategoria = new ComboBox();
            label3 = new Label();
            cBoxMedida = new ComboBox();
            label6 = new Label();
            dTPValidade = new DateTimePicker();
            dTPFabricacao = new DateTimePicker();
            mTBoxValor = new MaskedTextBox();
            txtNome = new TextBox();
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
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(939, 252);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtBarra
            // 
            txtBarra.Location = new Point(7, 91);
            txtBarra.Margin = new Padding(3, 4, 3, 4);
            txtBarra.Name = "txtBarra";
            txtBarra.Size = new Size(353, 34);
            txtBarra.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(rTBObservacao);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cBCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cBoxMedida);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dTPValidade);
            groupBox1.Controls.Add(dTPFabricacao);
            groupBox1.Controls.Add(mTBoxValor);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBarra);
            groupBox1.Font = new Font("Arial", 14F);
            groupBox1.Location = new Point(14, 259);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 791);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // button1
            // 
            button1.Location = new Point(518, 246);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(301, 155);
            button1.TabIndex = 16;
            button1.Text = "Testar o banco de dados.";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rTBObservacao
            // 
            rTBObservacao.Font = new Font("Arial", 12F);
            rTBObservacao.Location = new Point(8, 569);
            rTBObservacao.Margin = new Padding(3, 4, 3, 4);
            rTBObservacao.Name = "rTBObservacao";
            rTBObservacao.Size = new Size(351, 127);
            rTBObservacao.TabIndex = 15;
            rTBObservacao.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(7, 541);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 14;
            label7.Text = "Observações";
            // 
            // cBCategoria
            // 
            cBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCategoria.FormattingEnabled = true;
            cBCategoria.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Produto de Limpeza" });
            cBCategoria.Location = new Point(7, 503);
            cBCategoria.Margin = new Padding(3, 4, 3, 4);
            cBCategoria.MaxLength = 1;
            cBCategoria.Name = "cBCategoria";
            cBCategoria.Size = new Size(353, 34);
            cBCategoria.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(7, 475);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 12;
            label3.Text = "Categoria";
            // 
            // cBoxMedida
            // 
            cBoxMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxMedida.FormattingEnabled = true;
            cBoxMedida.Items.AddRange(new object[] { "Unidade", "KG" });
            cBoxMedida.Location = new Point(7, 228);
            cBoxMedida.Margin = new Padding(3, 4, 3, 4);
            cBoxMedida.MaxLength = 1;
            cBoxMedida.Name = "cBoxMedida";
            cBoxMedida.Size = new Size(353, 34);
            cBoxMedida.TabIndex = 11;
            cBoxMedida.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(8, 200);
            label6.Name = "label6";
            label6.Size = new Size(180, 23);
            label6.TabIndex = 10;
            label6.Text = "Unidade de Medida";
            // 
            // dTPValidade
            // 
            dTPValidade.CalendarFont = new Font("Arial", 12F);
            dTPValidade.Font = new Font("Arial", 12F);
            dTPValidade.Format = DateTimePickerFormat.Short;
            dTPValidade.Location = new Point(7, 436);
            dTPValidade.Margin = new Padding(3, 4, 3, 4);
            dTPValidade.Name = "dTPValidade";
            dTPValidade.Size = new Size(353, 30);
            dTPValidade.TabIndex = 9;
            // 
            // dTPFabricacao
            // 
            dTPFabricacao.CalendarFont = new Font("Arial", 12F);
            dTPFabricacao.Font = new Font("Arial", 12F);
            dTPFabricacao.Format = DateTimePickerFormat.Short;
            dTPFabricacao.Location = new Point(7, 369);
            dTPFabricacao.Margin = new Padding(3, 4, 3, 4);
            dTPFabricacao.Name = "dTPFabricacao";
            dTPFabricacao.Size = new Size(353, 30);
            dTPFabricacao.TabIndex = 8;
            // 
            // mTBoxValor
            // 
            mTBoxValor.Font = new Font("Arial", 12F);
            mTBoxValor.Location = new Point(7, 299);
            mTBoxValor.Margin = new Padding(3, 4, 3, 4);
            mTBoxValor.Mask = "$ 000.00";
            mTBoxValor.Name = "mTBoxValor";
            mTBoxValor.Size = new Size(353, 30);
            mTBoxValor.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(7, 161);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(353, 34);
            txtNome.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(7, 408);
            label5.Name = "label5";
            label5.Size = new Size(161, 23);
            label5.TabIndex = 5;
            label5.Text = "Data de Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(7, 341);
            label4.Name = "label4";
            label4.Size = new Size(184, 23);
            label4.TabIndex = 4;
            label4.Text = "Data de Fabricação";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Arial", 12F);
            lblValor.Location = new Point(7, 271);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(55, 23);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(7, 133);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 2;
            label2.Text = "Nome do Produto\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(7, 63);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 1;
            label1.Text = "Código de Barra";
            // 
            // FormCadastraProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 1020);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastraProdutos";
            StartPosition = FormStartPosition.Manual;
            Text = "FormCadastraProdutos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtBarra;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label5;
        private Label label4;
        private Label lblValor;
        private Label label2;
        private Label label1;
        private MaskedTextBox mTBoxValor;
        private DateTimePicker dTPFabricacao;
        private DateTimePicker dTPValidade;
        private ComboBox cBoxMedida;
        private Label label6;
        private ComboBox cBCategoria;
        private Label label3;
        private RichTextBox rTBObservacao;
        private Label label7;
        private Button button1;
    }
}