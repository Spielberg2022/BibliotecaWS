
namespace BibliotecaWS.View
{
    partial class LocalizarEmprestimoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarEmprestimoForm));
            this.cancelarButton = new System.Windows.Forms.Button();
            this.livroTabControl = new System.Windows.Forms.TabControl();
            this.codigoAlunoTabPage = new System.Windows.Forms.TabPage();
            this.codigoAlunoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoAlunoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTabPage = new System.Windows.Forms.TabPage();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.matriculaDataGridView = new System.Windows.Forms.DataGridView();
            this.cpfTabPage = new System.Windows.Forms.TabPage();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeAlunotabPage = new System.Windows.Forms.TabPage();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoLivroTabPage = new System.Windows.Forms.TabPage();
            this.codigoLivroDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoLivroTextBox = new System.Windows.Forms.TextBox();
            this.isbnTabPage = new System.Windows.Forms.TabPage();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.isbnDataGridView = new System.Windows.Forms.DataGridView();
            this.autorTabPage = new System.Windows.Forms.TabPage();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.tituloTabPage = new System.Windows.Forms.TabPage();
            this.f = new System.Windows.Forms.TextBox();
            this.tituloDataGridView = new System.Windows.Forms.DataGridView();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.livroTabControl.SuspendLayout();
            this.codigoAlunoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoAlunoDataGridView)).BeginInit();
            this.matriculaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataGridView)).BeginInit();
            this.cpfTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpfDataGridView)).BeginInit();
            this.nomeAlunotabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.codigoLivroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoLivroDataGridView)).BeginInit();
            this.isbnTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isbnDataGridView)).BeginInit();
            this.autorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).BeginInit();
            this.tituloTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.Location = new System.Drawing.Point(503, 152);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(92, 28);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // livroTabControl
            // 
            this.livroTabControl.Controls.Add(this.codigoAlunoTabPage);
            this.livroTabControl.Controls.Add(this.matriculaTabPage);
            this.livroTabControl.Controls.Add(this.cpfTabPage);
            this.livroTabControl.Controls.Add(this.nomeAlunotabPage);
            this.livroTabControl.Controls.Add(this.codigoLivroTabPage);
            this.livroTabControl.Controls.Add(this.isbnTabPage);
            this.livroTabControl.Controls.Add(this.autorTabPage);
            this.livroTabControl.Controls.Add(this.tituloTabPage);
            this.livroTabControl.Location = new System.Drawing.Point(12, 12);
            this.livroTabControl.Name = "livroTabControl";
            this.livroTabControl.SelectedIndex = 0;
            this.livroTabControl.Size = new System.Drawing.Size(485, 172);
            this.livroTabControl.TabIndex = 8;
            // 
            // codigoAlunoTabPage
            // 
            this.codigoAlunoTabPage.Controls.Add(this.codigoAlunoDataGridView);
            this.codigoAlunoTabPage.Controls.Add(this.codigoAlunoTextBox);
            this.codigoAlunoTabPage.Location = new System.Drawing.Point(4, 22);
            this.codigoAlunoTabPage.Name = "codigoAlunoTabPage";
            this.codigoAlunoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.codigoAlunoTabPage.Size = new System.Drawing.Size(477, 146);
            this.codigoAlunoTabPage.TabIndex = 0;
            this.codigoAlunoTabPage.Text = "Código do aluno";
            this.codigoAlunoTabPage.UseVisualStyleBackColor = true;
            // 
            // codigoAlunoDataGridView
            // 
            this.codigoAlunoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoAlunoDataGridView.Location = new System.Drawing.Point(6, 32);
            this.codigoAlunoDataGridView.Name = "codigoAlunoDataGridView";
            this.codigoAlunoDataGridView.Size = new System.Drawing.Size(465, 108);
            this.codigoAlunoDataGridView.TabIndex = 1;
            // 
            // codigoAlunoTextBox
            // 
            this.codigoAlunoTextBox.Location = new System.Drawing.Point(6, 8);
            this.codigoAlunoTextBox.Name = "codigoAlunoTextBox";
            this.codigoAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoAlunoTextBox.TabIndex = 0;
            // 
            // matriculaTabPage
            // 
            this.matriculaTabPage.Controls.Add(this.matriculaMaskedTextBox);
            this.matriculaTabPage.Controls.Add(this.matriculaDataGridView);
            this.matriculaTabPage.Location = new System.Drawing.Point(4, 22);
            this.matriculaTabPage.Name = "matriculaTabPage";
            this.matriculaTabPage.Size = new System.Drawing.Size(477, 146);
            this.matriculaTabPage.TabIndex = 5;
            this.matriculaTabPage.Text = "Matrícula";
            this.matriculaTabPage.UseVisualStyleBackColor = true;
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(3, 8);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaMaskedTextBox.TabIndex = 2;
            // 
            // matriculaDataGridView
            // 
            this.matriculaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriculaDataGridView.Location = new System.Drawing.Point(3, 32);
            this.matriculaDataGridView.Name = "matriculaDataGridView";
            this.matriculaDataGridView.Size = new System.Drawing.Size(471, 108);
            this.matriculaDataGridView.TabIndex = 3;
            // 
            // cpfTabPage
            // 
            this.cpfTabPage.Controls.Add(this.cpfMaskedTextBox);
            this.cpfTabPage.Controls.Add(this.cpfDataGridView);
            this.cpfTabPage.Location = new System.Drawing.Point(4, 22);
            this.cpfTabPage.Name = "cpfTabPage";
            this.cpfTabPage.Size = new System.Drawing.Size(477, 146);
            this.cpfTabPage.TabIndex = 6;
            this.cpfTabPage.Text = "CPF";
            this.cpfTabPage.UseVisualStyleBackColor = true;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(3, 11);
            this.cpfMaskedTextBox.Mask = "999,999,999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(93, 20);
            this.cpfMaskedTextBox.TabIndex = 2;
            // 
            // cpfDataGridView
            // 
            this.cpfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpfDataGridView.Location = new System.Drawing.Point(3, 35);
            this.cpfDataGridView.Name = "cpfDataGridView";
            this.cpfDataGridView.Size = new System.Drawing.Size(471, 108);
            this.cpfDataGridView.TabIndex = 3;
            // 
            // nomeAlunotabPage
            // 
            this.nomeAlunotabPage.Controls.Add(this.nomeTextBox);
            this.nomeAlunotabPage.Controls.Add(this.nomeDataGridView);
            this.nomeAlunotabPage.Location = new System.Drawing.Point(4, 22);
            this.nomeAlunotabPage.Name = "nomeAlunotabPage";
            this.nomeAlunotabPage.Size = new System.Drawing.Size(477, 146);
            this.nomeAlunotabPage.TabIndex = 7;
            this.nomeAlunotabPage.Text = "Nome do Aluno";
            this.nomeAlunotabPage.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(3, 11);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(471, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Location = new System.Drawing.Point(3, 35);
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.Size = new System.Drawing.Size(471, 108);
            this.nomeDataGridView.TabIndex = 3;
            // 
            // codigoLivroTabPage
            // 
            this.codigoLivroTabPage.Controls.Add(this.codigoLivroDataGridView);
            this.codigoLivroTabPage.Controls.Add(this.codigoLivroTextBox);
            this.codigoLivroTabPage.Location = new System.Drawing.Point(4, 22);
            this.codigoLivroTabPage.Name = "codigoLivroTabPage";
            this.codigoLivroTabPage.Size = new System.Drawing.Size(477, 146);
            this.codigoLivroTabPage.TabIndex = 4;
            this.codigoLivroTabPage.Text = "Código do livro";
            this.codigoLivroTabPage.UseVisualStyleBackColor = true;
            // 
            // codigoLivroDataGridView
            // 
            this.codigoLivroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoLivroDataGridView.Location = new System.Drawing.Point(3, 33);
            this.codigoLivroDataGridView.Name = "codigoLivroDataGridView";
            this.codigoLivroDataGridView.Size = new System.Drawing.Size(471, 108);
            this.codigoLivroDataGridView.TabIndex = 3;
            // 
            // codigoLivroTextBox
            // 
            this.codigoLivroTextBox.Location = new System.Drawing.Point(3, 9);
            this.codigoLivroTextBox.Name = "codigoLivroTextBox";
            this.codigoLivroTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoLivroTextBox.TabIndex = 2;
            // 
            // isbnTabPage
            // 
            this.isbnTabPage.Controls.Add(this.isbnTextBox);
            this.isbnTabPage.Controls.Add(this.isbnDataGridView);
            this.isbnTabPage.Location = new System.Drawing.Point(4, 22);
            this.isbnTabPage.Name = "isbnTabPage";
            this.isbnTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.isbnTabPage.Size = new System.Drawing.Size(477, 146);
            this.isbnTabPage.TabIndex = 1;
            this.isbnTabPage.Text = "ISBN";
            this.isbnTabPage.UseVisualStyleBackColor = true;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(6, 8);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(135, 20);
            this.isbnTextBox.TabIndex = 3;
            // 
            // isbnDataGridView
            // 
            this.isbnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isbnDataGridView.Location = new System.Drawing.Point(3, 34);
            this.isbnDataGridView.Name = "isbnDataGridView";
            this.isbnDataGridView.Size = new System.Drawing.Size(471, 108);
            this.isbnDataGridView.TabIndex = 2;
            // 
            // autorTabPage
            // 
            this.autorTabPage.Controls.Add(this.autorTextBox);
            this.autorTabPage.Controls.Add(this.autorDataGridView);
            this.autorTabPage.Location = new System.Drawing.Point(4, 22);
            this.autorTabPage.Name = "autorTabPage";
            this.autorTabPage.Size = new System.Drawing.Size(477, 146);
            this.autorTabPage.TabIndex = 2;
            this.autorTabPage.Text = "Autor";
            this.autorTabPage.UseVisualStyleBackColor = true;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(6, 8);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(468, 20);
            this.autorTextBox.TabIndex = 4;
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorDataGridView.Location = new System.Drawing.Point(6, 32);
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.Size = new System.Drawing.Size(468, 108);
            this.autorDataGridView.TabIndex = 3;
            // 
            // tituloTabPage
            // 
            this.tituloTabPage.Controls.Add(this.f);
            this.tituloTabPage.Controls.Add(this.tituloDataGridView);
            this.tituloTabPage.Location = new System.Drawing.Point(4, 22);
            this.tituloTabPage.Name = "tituloTabPage";
            this.tituloTabPage.Size = new System.Drawing.Size(477, 146);
            this.tituloTabPage.TabIndex = 3;
            this.tituloTabPage.Text = "Título";
            this.tituloTabPage.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(6, 8);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(468, 20);
            this.f.TabIndex = 5;
            // 
            // tituloDataGridView
            // 
            this.tituloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tituloDataGridView.Location = new System.Drawing.Point(6, 32);
            this.tituloDataGridView.Name = "tituloDataGridView";
            this.tituloDataGridView.Size = new System.Drawing.Size(468, 108);
            this.tituloDataGridView.TabIndex = 3;
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(503, 68);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(92, 28);
            this.exibirButton.TabIndex = 10;
            this.exibirButton.Text = "&Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Image = global::BibliotecaWS.Properties.Resources.icons8_localizar_e_substituir_16;
            this.localizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizarButton.Location = new System.Drawing.Point(503, 34);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(92, 28);
            this.localizarButton.TabIndex = 9;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // LocalizarEmprestimoForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(603, 186);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.livroTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizarEmprestimoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Empréstimo";
            this.livroTabControl.ResumeLayout(false);
            this.codigoAlunoTabPage.ResumeLayout(false);
            this.codigoAlunoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoAlunoDataGridView)).EndInit();
            this.matriculaTabPage.ResumeLayout(false);
            this.matriculaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataGridView)).EndInit();
            this.cpfTabPage.ResumeLayout(false);
            this.cpfTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpfDataGridView)).EndInit();
            this.nomeAlunotabPage.ResumeLayout(false);
            this.nomeAlunotabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.codigoLivroTabPage.ResumeLayout(false);
            this.codigoLivroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoLivroDataGridView)).EndInit();
            this.isbnTabPage.ResumeLayout(false);
            this.isbnTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isbnDataGridView)).EndInit();
            this.autorTabPage.ResumeLayout(false);
            this.autorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).EndInit();
            this.tituloTabPage.ResumeLayout(false);
            this.tituloTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.TabControl livroTabControl;
        private System.Windows.Forms.TabPage codigoAlunoTabPage;
        private System.Windows.Forms.DataGridView codigoAlunoDataGridView;
        private System.Windows.Forms.TextBox codigoAlunoTextBox;
        private System.Windows.Forms.TabPage isbnTabPage;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.DataGridView isbnDataGridView;
        private System.Windows.Forms.TabPage autorTabPage;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.TabPage tituloTabPage;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.DataGridView tituloDataGridView;
        private System.Windows.Forms.TabPage matriculaTabPage;
        private System.Windows.Forms.TabPage cpfTabPage;
        private System.Windows.Forms.TabPage nomeAlunotabPage;
        private System.Windows.Forms.TabPage codigoLivroTabPage;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.DataGridView matriculaDataGridView;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.DataGridView cpfDataGridView;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.DataGridView codigoLivroDataGridView;
        private System.Windows.Forms.TextBox codigoLivroTextBox;
    }
}