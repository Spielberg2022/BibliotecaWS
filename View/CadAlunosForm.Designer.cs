
namespace BibliotecaWS.View
{
    partial class CadAlunosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAlunosForm));
            this.alunoLabel = new System.Windows.Forms.Label();
            this.alunoGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.observacaoLabel = new System.Windows.Forms.Label();
            this.fotoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.alunoPictureBox = new System.Windows.Forms.PictureBox();
            this.alunoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoLabel
            // 
            this.alunoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alunoLabel.AutoSize = true;
            this.alunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoLabel.Location = new System.Drawing.Point(316, 9);
            this.alunoLabel.Name = "alunoLabel";
            this.alunoLabel.Size = new System.Drawing.Size(94, 33);
            this.alunoLabel.TabIndex = 0;
            this.alunoLabel.Text = "Aluno";
            // 
            // alunoGroupBox
            // 
            this.alunoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alunoGroupBox.Controls.Add(this.celularMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.label10);
            this.alunoGroupBox.Controls.Add(this.fotoLinkLabel);
            this.alunoGroupBox.Controls.Add(this.label11);
            this.alunoGroupBox.Controls.Add(this.fotoPictureBox);
            this.alunoGroupBox.Controls.Add(this.matriculaMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.cpfMaskedTextBox);
            this.alunoGroupBox.Controls.Add(this.nomeTextBox);
            this.alunoGroupBox.Controls.Add(this.codigoTextBox);
            this.alunoGroupBox.Controls.Add(this.groupBox1);
            this.alunoGroupBox.Controls.Add(this.label4);
            this.alunoGroupBox.Controls.Add(this.label3);
            this.alunoGroupBox.Controls.Add(this.label2);
            this.alunoGroupBox.Controls.Add(this.label1);
            this.alunoGroupBox.Location = new System.Drawing.Point(123, 49);
            this.alunoGroupBox.Name = "alunoGroupBox";
            this.alunoGroupBox.Size = new System.Drawing.Size(393, 250);
            this.alunoGroupBox.TabIndex = 1;
            this.alunoGroupBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 10;
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(82, 49);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaMaskedTextBox.TabIndex = 3;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(82, 101);
            this.cpfMaskedTextBox.Mask = "999,999,999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.cpfMaskedTextBox.TabIndex = 7;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(82, 75);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(211, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(82, 23);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(52, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(this.logradouroTextBox);
            this.groupBox1.Controls.Add(this.ufComboBox);
            this.groupBox1.Controls.Add(this.cepMaskedTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 113);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(249, 53);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(126, 20);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(76, 53);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(124, 20);
            this.bairroTextBox.TabIndex = 5;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Location = new System.Drawing.Point(76, 79);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(299, 20);
            this.logradouroTextBox.TabIndex = 9;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC"});
            this.ufComboBox.Location = new System.Drawing.Point(249, 26);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(56, 21);
            this.ufComboBox.TabIndex = 3;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.Location = new System.Drawing.Point(76, 27);
            this.cepMaskedTextBox.Mask = "99,999-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(124, 20);
            this.cepMaskedTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(46, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(38, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // observacaoLabel
            // 
            this.observacaoLabel.AutoSize = true;
            this.observacaoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.observacaoLabel.Location = new System.Drawing.Point(352, 302);
            this.observacaoLabel.Name = "observacaoLabel";
            this.observacaoLabel.Size = new System.Drawing.Size(164, 13);
            this.observacaoLabel.TabIndex = 2;
            this.observacaoLabel.Text = "*Dados Obrigatórios em vermelho";
            // 
            // fotoLinkLabel
            // 
            this.fotoLinkLabel.AutoSize = true;
            this.fotoLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoLinkLabel.Location = new System.Drawing.Point(262, 21);
            this.fotoLinkLabel.Name = "fotoLinkLabel";
            this.fotoLinkLabel.Size = new System.Drawing.Size(31, 13);
            this.fotoLinkLabel.TabIndex = 11;
            this.fotoLinkLabel.TabStop = true;
            this.fotoLinkLabel.Text = "Foto:";
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Location = new System.Drawing.Point(207, 100);
            this.celularMaskedTextBox.Mask = "(99)9-9999,9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.celularMaskedTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(176, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cel:";
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_imprimir_arquivo_48;
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imprimirButton.Location = new System.Drawing.Point(525, 227);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(90, 68);
            this.imprimirButton.TabIndex = 7;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::BibliotecaWS.Properties.Resources.icons8_arquivo_16;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(525, 140);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(90, 23);
            this.novoButton.TabIndex = 4;
            this.novoButton.Text = "&Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarButton.Image = global::BibliotecaWS.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarButton.Location = new System.Drawing.Point(525, 66);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(90, 68);
            this.localizarButton.TabIndex = 3;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_lixeira_vazia_16;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(525, 198);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(90, 23);
            this.excluirButton.TabIndex = 6;
            this.excluirButton.Text = "&Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Image = global::BibliotecaWS.Properties.Resources.icons8_salvar_16;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(525, 169);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(90, 23);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Location = new System.Drawing.Point(299, 21);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(88, 106);
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // alunoPictureBox
            // 
            this.alunoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.alunoPictureBox.Image = global::BibliotecaWS.Properties.Resources.AlunosCadastro;
            this.alunoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.alunoPictureBox.Name = "alunoPictureBox";
            this.alunoPictureBox.Size = new System.Drawing.Size(117, 321);
            this.alunoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alunoPictureBox.TabIndex = 0;
            this.alunoPictureBox.TabStop = false;
            // 
            // CadAlunosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.observacaoLabel);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.alunoGroupBox);
            this.Controls.Add(this.alunoLabel);
            this.Controls.Add(this.alunoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "CadAlunosForm";
            this.Text = "Cadastro de Alunos";
            this.alunoGroupBox.ResumeLayout(false);
            this.alunoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alunoPictureBox;
        private System.Windows.Forms.Label alunoLabel;
        private System.Windows.Forms.GroupBox alunoGroupBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.Label observacaoLabel;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.LinkLabel fotoLinkLabel;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.Label label10;
    }
}