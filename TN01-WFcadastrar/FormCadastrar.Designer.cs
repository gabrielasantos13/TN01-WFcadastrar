namespace TN01_WFcadastrar
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblEscolaridade = new Label();
            cbxEscolaridade = new ComboBox();
            gbxSexo = new GroupBox();
            rdbNaoInformar = new RadioButton();
            rdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            lblRendaMensal = new Label();
            nudRendaMensal = new NumericUpDown();
            chkPossuiFilhos = new CheckBox();
            btnCadastrar = new Button();
            gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.BackColor = Color.White;
            lblNomeCompleto.Location = new Point(63, 51);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(61, 69);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(343, 23);
            txtNomeCompleto.TabIndex = 1;
            txtNomeCompleto.Text = "                        ";
            txtNomeCompleto.TextChanged += txtNomeCompleto_TextChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.White;
            lblTelefone.Location = new Point(63, 121);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            lblTelefone.Click += label1_Click;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(63, 139);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 2;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.White;
            lblDataNascimento.Location = new Point(226, 121);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(226, 139);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(133, 23);
            dtpDataNascimento.TabIndex = 3;
            dtpDataNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.BackColor = Color.White;
            lblEscolaridade.Location = new Point(63, 202);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(73, 15);
            lblEscolaridade.TabIndex = 6;
            lblEscolaridade.Text = "Escolaridade";
            // 
            // cbxEscolaridade
            // 
            cbxEscolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEscolaridade.FormattingEnabled = true;
            cbxEscolaridade.Items.AddRange(new object[] { "Analfabeto", "Ensino Fundamental Incompleto", "Ensino Fundamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Técnico Inconpleto", "Ensino Técnico Completo", "Ensino Superior Incompleto", "Ensino Superior Completo ", "Pós-Graduação Incompleto", "Pós-Graduação Completo" });
            cbxEscolaridade.Location = new Point(63, 220);
            cbxEscolaridade.Name = "cbxEscolaridade";
            cbxEscolaridade.Size = new Size(343, 23);
            cbxEscolaridade.TabIndex = 4;
            // 
            // gbxSexo
            // 
            gbxSexo.BackColor = Color.White;
            gbxSexo.Controls.Add(rdbNaoInformar);
            gbxSexo.Controls.Add(rdbFeminino);
            gbxSexo.Controls.Add(rdbMasculino);
            gbxSexo.Location = new Point(63, 274);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Size = new Size(200, 100);
            gbxSexo.TabIndex = 5;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "Sexo";
            // 
            // rdbNaoInformar
            // 
            rdbNaoInformar.AutoSize = true;
            rdbNaoInformar.Location = new Point(6, 75);
            rdbNaoInformar.Name = "rdbNaoInformar";
            rdbNaoInformar.Size = new Size(134, 19);
            rdbNaoInformar.TabIndex = 2;
            rdbNaoInformar.TabStop = true;
            rdbNaoInformar.Text = "Prefiro Não Informar";
            rdbNaoInformar.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(6, 47);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(6, 22);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblRendaMensal
            // 
            lblRendaMensal.AutoSize = true;
            lblRendaMensal.BackColor = Color.White;
            lblRendaMensal.Location = new Point(301, 278);
            lblRendaMensal.Name = "lblRendaMensal";
            lblRendaMensal.Size = new Size(81, 15);
            lblRendaMensal.TabIndex = 9;
            lblRendaMensal.Text = "Renda Mensal";
            // 
            // nudRendaMensal
            // 
            nudRendaMensal.DecimalPlaces = 2;
            nudRendaMensal.Location = new Point(301, 296);
            nudRendaMensal.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudRendaMensal.Name = "nudRendaMensal";
            nudRendaMensal.Size = new Size(105, 23);
            nudRendaMensal.TabIndex = 6;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.BackColor = Color.White;
            chkPossuiFilhos.Checked = true;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
            chkPossuiFilhos.Location = new Point(301, 349);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(94, 19);
            chkPossuiFilhos.TabIndex = 7;
            chkPossuiFilhos.Text = "Possui Filhos";
            chkPossuiFilhos.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(63, 412);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 33);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Salvar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(476, 509);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(nudRendaMensal);
            Controls.Add(lblRendaMensal);
            Controls.Add(gbxSexo);
            Controls.Add(cbxEscolaridade);
            Controls.Add(lblEscolaridade);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastrar";
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblEscolaridade;
        private ComboBox cbxEscolaridade;
        private GroupBox gbxSexo;
        private RadioButton rdbNaoInformar;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private Label lblRendaMensal;
        private NumericUpDown nudRendaMensal;
        private CheckBox chkPossuiFilhos;
        private Button btnCadastrar;
    }
}