
namespace BibliotecaWS.View
{
    partial class CadLivrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLivrosForm));
            this.livroGroupBox = new System.Windows.Forms.GroupBox();
            this.livroLabel = new System.Windows.Forms.Label();
            this.observacaoLabel = new System.Windows.Forms.Label();
            this.novoButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.livroPictureBox = new System.Windows.Forms.PictureBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qtdTotalTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.disponíveisTextBox = new System.Windows.Forms.TextBox();
            this.capaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.capaPictureBox = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.livroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // livroGroupBox
            // 
            this.livroGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livroGroupBox.Controls.Add(this.label10);
            this.livroGroupBox.Controls.Add(this.label9);
            this.livroGroupBox.Controls.Add(this.maskedTextBox1);
            this.livroGroupBox.Controls.Add(this.capaLinkLabel);
            this.livroGroupBox.Controls.Add(this.capaPictureBox);
            this.livroGroupBox.Controls.Add(this.disponíveisTextBox);
            this.livroGroupBox.Controls.Add(this.editoraTextBox);
            this.livroGroupBox.Controls.Add(this.tituloTextBox);
            this.livroGroupBox.Controls.Add(this.autorTextBox);
            this.livroGroupBox.Controls.Add(this.isbnTextBox);
            this.livroGroupBox.Controls.Add(this.codigoTextBox);
            this.livroGroupBox.Controls.Add(this.qtdTotalTextBox);
            this.livroGroupBox.Controls.Add(this.label8);
            this.livroGroupBox.Controls.Add(this.label7);
            this.livroGroupBox.Controls.Add(this.label6);
            this.livroGroupBox.Controls.Add(this.label5);
            this.livroGroupBox.Controls.Add(this.label4);
            this.livroGroupBox.Controls.Add(this.label3);
            this.livroGroupBox.Controls.Add(this.label2);
            this.livroGroupBox.Controls.Add(this.label1);
            this.livroGroupBox.Location = new System.Drawing.Point(128, 49);
            this.livroGroupBox.Name = "livroGroupBox";
            this.livroGroupBox.Size = new System.Drawing.Size(393, 250);
            this.livroGroupBox.TabIndex = 1;
            this.livroGroupBox.TabStop = false;
            // 
            // livroLabel
            // 
            this.livroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.livroLabel.AutoSize = true;
            this.livroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livroLabel.Location = new System.Drawing.Point(321, 9);
            this.livroLabel.Name = "livroLabel";
            this.livroLabel.Size = new System.Drawing.Size(84, 33);
            this.livroLabel.TabIndex = 0;
            this.livroLabel.Text = "Livro";
            // 
            // observacaoLabel
            // 
            this.observacaoLabel.AutoSize = true;
            this.observacaoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.observacaoLabel.Location = new System.Drawing.Point(357, 302);
            this.observacaoLabel.Name = "observacaoLabel";
            this.observacaoLabel.Size = new System.Drawing.Size(164, 13);
            this.observacaoLabel.TabIndex = 2;
            this.observacaoLabel.Text = "*Dados Obrigatórios em vermelho";
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::BibliotecaWS.Properties.Resources.icons8_arquivo_16;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(528, 140);
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
            this.localizarButton.Location = new System.Drawing.Point(528, 66);
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
            this.excluirButton.Location = new System.Drawing.Point(528, 198);
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
            this.salvarButton.Location = new System.Drawing.Point(528, 169);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(90, 23);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            // 
            // livroPictureBox
            // 
            this.livroPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.livroPictureBox.Image = global::BibliotecaWS.Properties.Resources.biblioteca_sobre;
            this.livroPictureBox.Location = new System.Drawing.Point(0, 0);
            this.livroPictureBox.Name = "livroPictureBox";
            this.livroPictureBox.Size = new System.Drawing.Size(117, 321);
            this.livroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livroPictureBox.TabIndex = 9;
            this.livroPictureBox.TabStop = false;
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_imprimir_arquivo_48;
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imprimirButton.Location = new System.Drawing.Point(528, 227);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(90, 68);
            this.imprimirButton.TabIndex = 7;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor(es):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Título:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Editora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidade Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Disponíveis:";
            // 
            // qtdTotalTextBox
            // 
            this.qtdTotalTextBox.Location = new System.Drawing.Point(177, 214);
            this.qtdTotalTextBox.Name = "qtdTotalTextBox";
            this.qtdTotalTextBox.Size = new System.Drawing.Size(60, 20);
            this.qtdTotalTextBox.TabIndex = 14;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(69, 25);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(60, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(69, 51);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(134, 20);
            this.isbnTextBox.TabIndex = 3;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(69, 77);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(224, 20);
            this.autorTextBox.TabIndex = 5;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(69, 130);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(224, 20);
            this.tituloTextBox.TabIndex = 7;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.Location = new System.Drawing.Point(69, 156);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(318, 20);
            this.editoraTextBox.TabIndex = 9;
            // 
            // disponíveisTextBox
            // 
            this.disponíveisTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.disponíveisTextBox.Location = new System.Drawing.Point(327, 214);
            this.disponíveisTextBox.Name = "disponíveisTextBox";
            this.disponíveisTextBox.Size = new System.Drawing.Size(60, 20);
            this.disponíveisTextBox.TabIndex = 16;
            // 
            // capaLinkLabel
            // 
            this.capaLinkLabel.AutoSize = true;
            this.capaLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capaLinkLabel.Location = new System.Drawing.Point(258, 16);
            this.capaLinkLabel.Name = "capaLinkLabel";
            this.capaLinkLabel.Size = new System.Drawing.Size(35, 13);
            this.capaLinkLabel.TabIndex = 12;
            this.capaLinkLabel.TabStop = true;
            this.capaLinkLabel.Text = "Capa:";
            // 
            // capaPictureBox
            // 
            this.capaPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.capaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capaPictureBox.Location = new System.Drawing.Point(299, 17);
            this.capaPictureBox.Name = "capaPictureBox";
            this.capaPictureBox.Size = new System.Drawing.Size(88, 106);
            this.capaPictureBox.TabIndex = 18;
            this.capaPictureBox.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(69, 182);
            this.maskedTextBox1.Mask = "9000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(28, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cadastrar Autores no seguinte padrão:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(34, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "--->   SOBRENOME, Nome; SOBRENOME, Nome ...";
            // 
            // CadLivrosForm
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
            this.Controls.Add(this.livroGroupBox);
            this.Controls.Add(this.livroLabel);
            this.Controls.Add(this.livroPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "CadLivrosForm";
            this.Text = "Cadastro de Livros";
            this.livroGroupBox.ResumeLayout(false);
            this.livroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.GroupBox livroGroupBox;
        private System.Windows.Forms.Label livroLabel;
        private System.Windows.Forms.PictureBox livroPictureBox;
        private System.Windows.Forms.Label observacaoLabel;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.TextBox disponíveisTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox qtdTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel capaLinkLabel;
        private System.Windows.Forms.PictureBox capaPictureBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}