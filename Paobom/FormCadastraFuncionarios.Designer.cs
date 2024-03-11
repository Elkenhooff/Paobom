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
            dTPAdmissao = new DateTimePicker();
            cBStatus = new ComboBox();
            cbSupervisor = new ComboBox();
            cBCargo = new ComboBox();
            gBBeneficios = new GroupBox();
            cBAuxilio = new CheckBox();
            cBVale = new CheckBox();
            cBPlano = new CheckBox();
            cBHorario = new ComboBox();
            tBSetor = new TextBox();
            mTBSalario = new MaskedTextBox();
            tbCodigo = new TextBox();
            mTBTelefoneEmerg = new MaskedTextBox();
            mTBTelefone = new MaskedTextBox();
            rTBEndereco = new RichTextBox();
            dTPNasc = new DateTimePicker();
            tBNome = new TextBox();
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
            gBBeneficios.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1728, 189);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(dTPAdmissao);
            groupBox1.Controls.Add(cBStatus);
            groupBox1.Controls.Add(cbSupervisor);
            groupBox1.Controls.Add(cBCargo);
            groupBox1.Controls.Add(gBBeneficios);
            groupBox1.Controls.Add(cBHorario);
            groupBox1.Controls.Add(tBSetor);
            groupBox1.Controls.Add(mTBSalario);
            groupBox1.Controls.Add(tbCodigo);
            groupBox1.Controls.Add(mTBTelefoneEmerg);
            groupBox1.Controls.Add(mTBTelefone);
            groupBox1.Controls.Add(rTBEndereco);
            groupBox1.Controls.Add(dTPNasc);
            groupBox1.Controls.Add(tBNome);
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
            groupBox1.Location = new Point(12, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1416, 607);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(441, 373);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(345, 78);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Testar banco de dados";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dTPAdmissao
            // 
            dTPAdmissao.Format = DateTimePickerFormat.Short;
            dTPAdmissao.Location = new Point(842, 77);
            dTPAdmissao.Name = "dTPAdmissao";
            dTPAdmissao.Size = new Size(200, 29);
            dTPAdmissao.TabIndex = 29;
            // 
            // cBStatus
            // 
            cBStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStatus.FormattingEnabled = true;
            cBStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Licença", "Suspenso", "Férias" });
            cBStatus.Location = new Point(842, 306);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(200, 30);
            cBStatus.TabIndex = 28;
            // 
            // cbSupervisor
            // 
            cbSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupervisor.FormattingEnabled = true;
            cbSupervisor.Location = new Point(842, 248);
            cbSupervisor.Name = "cbSupervisor";
            cbSupervisor.Size = new Size(200, 30);
            cbSupervisor.TabIndex = 27;
            // 
            // cBCargo
            // 
            cBCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCargo.FormattingEnabled = true;
            cBCargo.Items.AddRange(new object[] { "Gerente", "Padeiro", "Confeiteiro", "Atendente de Balcão", "Caixa", "Auxiliar de Produção", "Entregador", "Auxiliar de Limpeza" });
            cBCargo.Location = new Point(457, 134);
            cBCargo.Name = "cBCargo";
            cBCargo.Size = new Size(279, 30);
            cBCargo.TabIndex = 26;
            // 
            // gBBeneficios
            // 
            gBBeneficios.Controls.Add(cBAuxilio);
            gBBeneficios.Controls.Add(cBVale);
            gBBeneficios.Controls.Add(cBPlano);
            gBBeneficios.Location = new Point(842, 109);
            gBBeneficios.Name = "gBBeneficios";
            gBBeneficios.Size = new Size(200, 111);
            gBBeneficios.TabIndex = 24;
            gBBeneficios.TabStop = false;
            gBBeneficios.Text = "Beneficios";
            // 
            // cBAuxilio
            // 
            cBAuxilio.AutoSize = true;
            cBAuxilio.Location = new Point(6, 82);
            cBAuxilio.Name = "cBAuxilio";
            cBAuxilio.Size = new Size(183, 26);
            cBAuxilio.TabIndex = 2;
            cBAuxilio.Text = "Auxílio-Transporte";
            cBAuxilio.UseVisualStyleBackColor = true;
            // 
            // cBVale
            // 
            cBVale.AutoSize = true;
            cBVale.Location = new Point(6, 53);
            cBVale.Name = "cBVale";
            cBVale.Size = new Size(176, 26);
            cBVale.TabIndex = 1;
            cBVale.Text = "Vale-Alimentação";
            cBVale.UseVisualStyleBackColor = true;
            // 
            // cBPlano
            // 
            cBPlano.AutoSize = true;
            cBPlano.Location = new Point(6, 25);
            cBPlano.Name = "cBPlano";
            cBPlano.Size = new Size(164, 26);
            cBPlano.TabIndex = 0;
            cBPlano.Text = "Plano de Saúde";
            cBPlano.UseVisualStyleBackColor = true;
            // 
            // cBHorario
            // 
            cBHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cBHorario.FormattingEnabled = true;
            cBHorario.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Madrugada" });
            cBHorario.Location = new Point(457, 303);
            cBHorario.Name = "cBHorario";
            cBHorario.Size = new Size(279, 30);
            cBHorario.TabIndex = 23;
            // 
            // tBSetor
            // 
            tBSetor.Location = new Point(457, 246);
            tBSetor.Name = "tBSetor";
            tBSetor.Size = new Size(279, 29);
            tBSetor.TabIndex = 22;
            // 
            // mTBSalario
            // 
            mTBSalario.Location = new Point(457, 191);
            mTBSalario.Mask = "$ 00000.00";
            mTBSalario.Name = "mTBSalario";
            mTBSalario.Size = new Size(279, 29);
            mTBSalario.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(457, 77);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(279, 29);
            tbCodigo.TabIndex = 19;
            // 
            // mTBTelefoneEmerg
            // 
            mTBTelefoneEmerg.Location = new Point(6, 328);
            mTBTelefoneEmerg.Mask = "+55 (00) 00000-0000";
            mTBTelefoneEmerg.Name = "mTBTelefoneEmerg";
            mTBTelefoneEmerg.Size = new Size(218, 29);
            mTBTelefoneEmerg.TabIndex = 18;
            // 
            // mTBTelefone
            // 
            mTBTelefone.Location = new Point(6, 271);
            mTBTelefone.Mask = "+55 (00) 00000-0000";
            mTBTelefone.Name = "mTBTelefone";
            mTBTelefone.Size = new Size(218, 29);
            mTBTelefone.TabIndex = 17;
            // 
            // rTBEndereco
            // 
            rTBEndereco.Location = new Point(6, 191);
            rTBEndereco.Name = "rTBEndereco";
            rTBEndereco.Size = new Size(357, 52);
            rTBEndereco.TabIndex = 16;
            rTBEndereco.Text = "";
            // 
            // dTPNasc
            // 
            dTPNasc.Format = DateTimePickerFormat.Short;
            dTPNasc.Location = new Point(6, 134);
            dTPNasc.Name = "dTPNasc";
            dTPNasc.Size = new Size(181, 29);
            dTPNasc.TabIndex = 15;
            // 
            // tBNome
            // 
            tBNome.Location = new Point(6, 77);
            tBNome.Name = "tBNome";
            tBNome.Size = new Size(357, 29);
            tBNome.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 303);
            label14.Name = "label14";
            label14.Size = new Size(218, 22);
            label14.TabIndex = 13;
            label14.Text = "Telefone de Emergência";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(842, 281);
            label13.Name = "label13";
            label13.Size = new Size(174, 22);
            label13.TabIndex = 12;
            label13.Text = "Status de Emprego";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(842, 223);
            label12.Name = "label12";
            label12.Size = new Size(101, 22);
            label12.TabIndex = 11;
            label12.Text = "Supervisor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(457, 278);
            label10.Name = "label10";
            label10.Size = new Size(176, 22);
            label10.TabIndex = 9;
            label10.Text = "Horário de Trabalho";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 52);
            label9.Name = "label9";
            label9.Size = new Size(217, 22);
            label9.TabIndex = 8;
            label9.Text = "Numero de Identificação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 109);
            label8.Name = "label8";
            label8.Size = new Size(181, 22);
            label8.TabIndex = 7;
            label8.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 246);
            label7.Name = "label7";
            label7.Size = new Size(84, 22);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 166);
            label6.Name = "label6";
            label6.Size = new Size(93, 22);
            label6.TabIndex = 5;
            label6.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(842, 52);
            label5.Name = "label5";
            label5.Size = new Size(165, 22);
            label5.TabIndex = 4;
            label5.Text = "Data de Admissão";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 223);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 3;
            label4.Text = "Setor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 166);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 1;
            label2.Text = "Salário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // FormCadastraFuncionarios
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 877);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
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
            gBBeneficios.ResumeLayout(false);
            gBBeneficios.PerformLayout();
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
        private RichTextBox rTBEndereco;
        private DateTimePicker dTPNasc;
        private TextBox tBNome;
        private MaskedTextBox mTBTelefone;
        private MaskedTextBox mTBTelefoneEmerg;
        private GroupBox gBBeneficios;
        private CheckBox cBAuxilio;
        private CheckBox cBVale;
        private CheckBox cBPlano;
        private ComboBox cBHorario;
        private TextBox tBSetor;
        private MaskedTextBox mTBSalario;
        private TextBox tbCodigo;
        private ComboBox cbSupervisor;
        private ComboBox cBCargo;
        private DateTimePicker dTPAdmissao;
        private ComboBox cBStatus;
        private Button btnInserir;
    }
}