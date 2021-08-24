
namespace BibliotecaWS.View
{
    partial class LocalizarLivroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarLivroForm));
            this.cancelarButton = new System.Windows.Forms.Button();
            this.livroTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.isbnTabPage = new System.Windows.Forms.TabPage();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.isbnDataGridView = new System.Windows.Forms.DataGridView();
            this.autorTabPage = new System.Windows.Forms.TabPage();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.tituloTabPage = new System.Windows.Forms.TabPage();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.tituloDataGridView = new System.Windows.Forms.DataGridView();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.livroTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
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
            this.cancelarButton.Location = new System.Drawing.Point(436, 152);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(92, 28);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // livroTabControl
            // 
            this.livroTabControl.Controls.Add(this.codigoTabPage);
            this.livroTabControl.Controls.Add(this.isbnTabPage);
            this.livroTabControl.Controls.Add(this.autorTabPage);
            this.livroTabControl.Controls.Add(this.tituloTabPage);
            this.livroTabControl.Location = new System.Drawing.Point(12, 12);
            this.livroTabControl.Name = "livroTabControl";
            this.livroTabControl.SelectedIndex = 0;
            this.livroTabControl.Size = new System.Drawing.Size(418, 172);
            this.livroTabControl.TabIndex = 4;
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
            // isbnTabPage
            // 
            this.isbnTabPage.Controls.Add(this.isbnTextBox);
            this.isbnTabPage.Controls.Add(this.isbnDataGridView);
            this.isbnTabPage.Location = new System.Drawing.Point(4, 22);
            this.isbnTabPage.Name = "isbnTabPage";
            this.isbnTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.isbnTabPage.Size = new System.Drawing.Size(410, 146);
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
            this.isbnDataGridView.Location = new System.Drawing.Point(6, 32);
            this.isbnDataGridView.Name = "isbnDataGridView";
            this.isbnDataGridView.Size = new System.Drawing.Size(398, 108);
            this.isbnDataGridView.TabIndex = 2;
            // 
            // autorTabPage
            // 
            this.autorTabPage.Controls.Add(this.autorTextBox);
            this.autorTabPage.Controls.Add(this.autorDataGridView);
            this.autorTabPage.Location = new System.Drawing.Point(4, 22);
            this.autorTabPage.Name = "autorTabPage";
            this.autorTabPage.Size = new System.Drawing.Size(410, 146);
            this.autorTabPage.TabIndex = 2;
            this.autorTabPage.Text = "Autor";
            this.autorTabPage.UseVisualStyleBackColor = true;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(6, 8);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(398, 20);
            this.autorTextBox.TabIndex = 4;
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorDataGridView.Location = new System.Drawing.Point(6, 32);
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.Size = new System.Drawing.Size(398, 108);
            this.autorDataGridView.TabIndex = 3;
            // 
            // tituloTabPage
            // 
            this.tituloTabPage.Controls.Add(this.tituloTextBox);
            this.tituloTabPage.Controls.Add(this.tituloDataGridView);
            this.tituloTabPage.Location = new System.Drawing.Point(4, 22);
            this.tituloTabPage.Name = "tituloTabPage";
            this.tituloTabPage.Size = new System.Drawing.Size(410, 146);
            this.tituloTabPage.TabIndex = 3;
            this.tituloTabPage.Text = "Título";
            this.tituloTabPage.UseVisualStyleBackColor = true;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(6, 8);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(398, 20);
            this.tituloTextBox.TabIndex = 5;
            // 
            // tituloDataGridView
            // 
            this.tituloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tituloDataGridView.Location = new System.Drawing.Point(6, 32);
            this.tituloDataGridView.Name = "tituloDataGridView";
            this.tituloDataGridView.Size = new System.Drawing.Size(398, 108);
            this.tituloDataGridView.TabIndex = 3;
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(436, 68);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(92, 28);
            this.exibirButton.TabIndex = 6;
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
            this.localizarButton.TabIndex = 5;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // LocalizarLivroForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.livroTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizarLivroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Livro";
            this.livroTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage isbnTabPage;
        private System.Windows.Forms.DataGridView isbnDataGridView;
        private System.Windows.Forms.TabPage autorTabPage;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.TabPage tituloTabPage;
        private System.Windows.Forms.DataGridView tituloDataGridView;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
    }
}