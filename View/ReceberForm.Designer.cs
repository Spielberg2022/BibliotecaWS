
namespace BibliotecaWS.View
{
    partial class ReceberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceberForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.livrosADevolverDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.confirmarLivroButton = new System.Windows.Forms.Button();
            this.localizarAlunoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.receberButton = new System.Windows.Forms.Button();
            this.multaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosADevolverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(10, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.livrosADevolverDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.matriculaMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.confirmarLivroButton);
            this.splitContainer1.Panel1.Controls.Add(this.localizarAlunoButton);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.livrosDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(509, 297);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(5, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione os livros que você vai \r\ndevolver e clique no botão \r\nCONFIRMAR, depois" +
    " clique em \r\nRECEBER...\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matrícula:";
            // 
            // livrosADevolverDataGridView
            // 
            this.livrosADevolverDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livrosADevolverDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.livrosADevolverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosADevolverDataGridView.Location = new System.Drawing.Point(6, 117);
            this.livrosADevolverDataGridView.Name = "livrosADevolverDataGridView";
            this.livrosADevolverDataGridView.Size = new System.Drawing.Size(242, 98);
            this.livrosADevolverDataGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Livros à devolver:";
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(69, 52);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(113, 20);
            this.matriculaMaskedTextBox.TabIndex = 2;
            // 
            // confirmarLivroButton
            // 
            this.confirmarLivroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmarLivroButton.Image = global::BibliotecaWS.Properties.Resources.icons8_seta_para_a_frente_302;
            this.confirmarLivroButton.Location = new System.Drawing.Point(174, 221);
            this.confirmarLivroButton.Name = "confirmarLivroButton";
            this.confirmarLivroButton.Size = new System.Drawing.Size(74, 70);
            this.confirmarLivroButton.TabIndex = 3;
            this.confirmarLivroButton.Text = "&Confirmar";
            this.confirmarLivroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.confirmarLivroButton.UseVisualStyleBackColor = true;
            // 
            // localizarAlunoButton
            // 
            this.localizarAlunoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarAlunoButton.Image = global::BibliotecaWS.Properties.Resources.icons8_localizar_e_substituir_48;
            this.localizarAlunoButton.Location = new System.Drawing.Point(190, 3);
            this.localizarAlunoButton.Name = "localizarAlunoButton";
            this.localizarAlunoButton.Size = new System.Drawing.Size(58, 70);
            this.localizarAlunoButton.TabIndex = 3;
            this.localizarAlunoButton.Text = "Loc&alizar";
            this.localizarAlunoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.localizarAlunoButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.livrosDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Location = new System.Drawing.Point(5, 52);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.Size = new System.Drawing.Size(242, 163);
            this.livrosDataGridView.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(19, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data da devolução:";
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDevolucaoDateTimePicker.Enabled = false;
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(21, 257);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.dataDevolucaoDateTimePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Livro(s):";
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(525, 89);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(90, 23);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // receberButton
            // 
            this.receberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receberButton.Enabled = false;
            this.receberButton.Image = global::BibliotecaWS.Properties.Resources.icons8_seta_responder_301;
            this.receberButton.Location = new System.Drawing.Point(525, 17);
            this.receberButton.Name = "receberButton";
            this.receberButton.Size = new System.Drawing.Size(90, 69);
            this.receberButton.TabIndex = 4;
            this.receberButton.Text = "&Receber";
            this.receberButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.receberButton.UseVisualStyleBackColor = true;
            // 
            // multaButton
            // 
            this.multaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.multaButton.Image = global::BibliotecaWS.Properties.Resources.icons8_iniciar_transferência_de_dinheiro_60;
            this.multaButton.Location = new System.Drawing.Point(525, 225);
            this.multaButton.Name = "multaButton";
            this.multaButton.Size = new System.Drawing.Size(90, 84);
            this.multaButton.TabIndex = 6;
            this.multaButton.Text = "Receber &Multa";
            this.multaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multaButton.UseVisualStyleBackColor = true;
            this.multaButton.Visible = false;
            this.multaButton.Click += new System.EventHandler(this.multaButton_Click);
            // 
            // ReceberForm
            // 
            this.AcceptButton = this.receberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.multaButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.receberButton);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "ReceberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber";
            this.Load += new System.EventHandler(this.ReceberForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livrosADevolverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button receberButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView livrosADevolverDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.Button localizarAlunoButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.Button confirmarLivroButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button multaButton;
    }
}