
namespace BibliotecaWS.View
{
    partial class LocalizarAlunoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarAlunoForm));
            this.alunoTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTabPage = new System.Windows.Forms.TabPage();
            this.matriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.matriculaDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeTabPage = new System.Windows.Forms.TabPage();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.cpfTabPage = new System.Windows.Forms.TabPage();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.alunoTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            this.matriculaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataGridView)).BeginInit();
            this.nomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.cpfTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoTabControl
            // 
            this.alunoTabControl.Controls.Add(this.codigoTabPage);
            this.alunoTabControl.Controls.Add(this.matriculaTabPage);
            this.alunoTabControl.Controls.Add(this.nomeTabPage);
            this.alunoTabControl.Controls.Add(this.cpfTabPage);
            this.alunoTabControl.Location = new System.Drawing.Point(12, 12);
            this.alunoTabControl.Name = "alunoTabControl";
            this.alunoTabControl.SelectedIndex = 0;
            this.alunoTabControl.Size = new System.Drawing.Size(418, 172);
            this.alunoTabControl.TabIndex = 0;
            // 
            // codigoTabPage
            // 
            this.codigoTabPage.Controls.Add(this.codigoDataGridView);
            this.codigoTabPage.Controls.Add(this.codigoTextBox);
            this.codigoTabPage.Location = new System.Drawing.Point(4, 22);
            this.codigoTabPage.Name = "codigoTabPage";
            this.codigoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.codigoTabPage.Size = new System.Drawing.Size(410, 146);
            this.codigoTabPage.TabIndex = 0;
            this.codigoTabPage.Text = "Código";
            this.codigoTabPage.UseVisualStyleBackColor = true;
            // 
            // codigoDataGridView
            // 
            this.codigoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codigoDataGridView.Location = new System.Drawing.Point(6, 32);
            this.codigoDataGridView.Name = "codigoDataGridView";
            this.codigoDataGridView.Size = new System.Drawing.Size(398, 108);
            this.codigoDataGridView.TabIndex = 1;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(6, 8);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // matriculaTabPage
            // 
            this.matriculaTabPage.Controls.Add(this.matriculaMaskedTextBox);
            this.matriculaTabPage.Controls.Add(this.matriculaDataGridView);
            this.matriculaTabPage.Location = new System.Drawing.Point(4, 22);
            this.matriculaTabPage.Name = "matriculaTabPage";
            this.matriculaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.matriculaTabPage.Size = new System.Drawing.Size(410, 146);
            this.matriculaTabPage.TabIndex = 1;
            this.matriculaTabPage.Text = "Matrícula";
            this.matriculaTabPage.UseVisualStyleBackColor = true;
            // 
            // matriculaMaskedTextBox
            // 
            this.matriculaMaskedTextBox.Location = new System.Drawing.Point(6, 8);
            this.matriculaMaskedTextBox.Mask = "99-99999";
            this.matriculaMaskedTextBox.Name = "matriculaMaskedTextBox";
            this.matriculaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaMaskedTextBox.TabIndex = 0;
            // 
            // matriculaDataGridView
            // 
            this.matriculaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriculaDataGridView.Location = new System.Drawing.Point(6, 32);
            this.matriculaDataGridView.Name = "matriculaDataGridView";
            this.matriculaDataGridView.Size = new System.Drawing.Size(398, 108);
            this.matriculaDataGridView.TabIndex = 1;
            // 
            // nomeTabPage
            // 
            this.nomeTabPage.Controls.Add(this.nomeTextBox);
            this.nomeTabPage.Controls.Add(this.nomeDataGridView);
            this.nomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.nomeTabPage.Name = "nomeTabPage";
            this.nomeTabPage.Size = new System.Drawing.Size(410, 146);
            this.nomeTabPage.TabIndex = 2;
            this.nomeTabPage.Text = "Nome";
            this.nomeTabPage.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 8);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(398, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Location = new System.Drawing.Point(6, 32);
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.Size = new System.Drawing.Size(398, 108);
            this.nomeDataGridView.TabIndex = 1;
            // 
            // cpfTabPage
            // 
            this.cpfTabPage.Controls.Add(this.cpfMaskedTextBox);
            this.cpfTabPage.Controls.Add(this.cpfDataGridView);
            this.cpfTabPage.Location = new System.Drawing.Point(4, 22);
            this.cpfTabPage.Name = "cpfTabPage";
            this.cpfTabPage.Size = new System.Drawing.Size(410, 146);
            this.cpfTabPage.TabIndex = 3;
            this.cpfTabPage.Text = "CPF";
            this.cpfTabPage.UseVisualStyleBackColor = true;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(6, 8);
            this.cpfMaskedTextBox.Mask = "999,999,999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.cpfMaskedTextBox.TabIndex = 0;
            // 
            // cpfDataGridView
            // 
            this.cpfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpfDataGridView.Location = new System.Drawing.Point(6, 32);
            this.cpfDataGridView.Name = "cpfDataGridView";
            this.cpfDataGridView.Size = new System.Drawing.Size(398, 108);
            this.cpfDataGridView.TabIndex = 1;
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.Location = new System.Drawing.Point(436, 152);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(92, 28);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(436, 68);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(92, 28);
            this.exibirButton.TabIndex = 2;
            this.exibirButton.Text = "&Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            // 
            // localizarButton
            // 
            this.localizarButton.Image = global::BibliotecaWS.Properties.Resources.icons8_localizar_e_substituir_16;
            this.localizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localizarButton.Location = new System.Drawing.Point(436, 34);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(92, 28);
            this.localizarButton.TabIndex = 1;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // LocalizarAlunoForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.alunoTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizarAlunoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Aluno";
            this.alunoTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            this.matriculaTabPage.ResumeLayout(false);
            this.matriculaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaDataGridView)).EndInit();
            this.nomeTabPage.ResumeLayout(false);
            this.nomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.cpfTabPage.ResumeLayout(false);
            this.cpfTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpfDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl alunoTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.TabPage nomeTabPage;
        private System.Windows.Forms.TabPage cpfTabPage;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage matriculaTabPage;
        private System.Windows.Forms.DataGridView matriculaDataGridView;
        private System.Windows.Forms.MaskedTextBox matriculaMaskedTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.DataGridView cpfDataGridView;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
    }
}