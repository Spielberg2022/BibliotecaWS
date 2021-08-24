
namespace BibliotecaWS.View
{
    partial class LocalizarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarUsuarioForm));
            this.cancelarButton = new System.Windows.Forms.Button();
            this.usuarioTabControl = new System.Windows.Forms.TabControl();
            this.codigoTabPage = new System.Windows.Forms.TabPage();
            this.codigoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTabPage = new System.Windows.Forms.TabPage();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeDataGridView = new System.Windows.Forms.DataGridView();
            this.IdentificadorTabPage = new System.Windows.Forms.TabPage();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.identificadorDataGridView = new System.Windows.Forms.DataGridView();
            this.emailTabPage = new System.Windows.Forms.TabPage();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailDataGridView = new System.Windows.Forms.DataGridView();
            this.exibirButton = new System.Windows.Forms.Button();
            this.localizarButton = new System.Windows.Forms.Button();
            this.usuarioTabControl.SuspendLayout();
            this.codigoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).BeginInit();
            this.nomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).BeginInit();
            this.IdentificadorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorDataGridView)).BeginInit();
            this.emailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.Location = new System.Drawing.Point(436, 152);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(92, 28);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // usuarioTabControl
            // 
            this.usuarioTabControl.Controls.Add(this.codigoTabPage);
            this.usuarioTabControl.Controls.Add(this.nomeTabPage);
            this.usuarioTabControl.Controls.Add(this.IdentificadorTabPage);
            this.usuarioTabControl.Controls.Add(this.emailTabPage);
            this.usuarioTabControl.Location = new System.Drawing.Point(12, 12);
            this.usuarioTabControl.Name = "usuarioTabControl";
            this.usuarioTabControl.SelectedIndex = 0;
            this.usuarioTabControl.Size = new System.Drawing.Size(418, 172);
            this.usuarioTabControl.TabIndex = 8;
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
            // nomeTabPage
            // 
            this.nomeTabPage.Controls.Add(this.nomeTextBox);
            this.nomeTabPage.Controls.Add(this.nomeDataGridView);
            this.nomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.nomeTabPage.Name = "nomeTabPage";
            this.nomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nomeTabPage.Size = new System.Drawing.Size(410, 146);
            this.nomeTabPage.TabIndex = 1;
            this.nomeTabPage.Text = "Nome";
            this.nomeTabPage.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 8);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(398, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nomeDataGridView
            // 
            this.nomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomeDataGridView.Location = new System.Drawing.Point(6, 32);
            this.nomeDataGridView.Name = "nomeDataGridView";
            this.nomeDataGridView.Size = new System.Drawing.Size(398, 108);
            this.nomeDataGridView.TabIndex = 2;
            // 
            // IdentificadorTabPage
            // 
            this.IdentificadorTabPage.Controls.Add(this.identificadorTextBox);
            this.IdentificadorTabPage.Controls.Add(this.identificadorDataGridView);
            this.IdentificadorTabPage.Location = new System.Drawing.Point(4, 22);
            this.IdentificadorTabPage.Name = "IdentificadorTabPage";
            this.IdentificadorTabPage.Size = new System.Drawing.Size(410, 146);
            this.IdentificadorTabPage.TabIndex = 2;
            this.IdentificadorTabPage.Text = "Identificador";
            this.IdentificadorTabPage.UseVisualStyleBackColor = true;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.Location = new System.Drawing.Point(6, 8);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(216, 20);
            this.identificadorTextBox.TabIndex = 4;
            // 
            // identificadorDataGridView
            // 
            this.identificadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.identificadorDataGridView.Location = new System.Drawing.Point(6, 32);
            this.identificadorDataGridView.Name = "identificadorDataGridView";
            this.identificadorDataGridView.Size = new System.Drawing.Size(398, 108);
            this.identificadorDataGridView.TabIndex = 3;
            // 
            // emailTabPage
            // 
            this.emailTabPage.Controls.Add(this.emailTextBox);
            this.emailTabPage.Controls.Add(this.emailDataGridView);
            this.emailTabPage.Location = new System.Drawing.Point(4, 22);
            this.emailTabPage.Name = "emailTabPage";
            this.emailTabPage.Size = new System.Drawing.Size(410, 146);
            this.emailTabPage.TabIndex = 3;
            this.emailTabPage.Text = "E-mail";
            this.emailTabPage.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(6, 8);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(398, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailDataGridView
            // 
            this.emailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDataGridView.Location = new System.Drawing.Point(6, 32);
            this.emailDataGridView.Name = "emailDataGridView";
            this.emailDataGridView.Size = new System.Drawing.Size(398, 108);
            this.emailDataGridView.TabIndex = 3;
            // 
            // exibirButton
            // 
            this.exibirButton.Image = global::BibliotecaWS.Properties.Resources.icons8_play_dentro_de_um_círculo_16;
            this.exibirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exibirButton.Location = new System.Drawing.Point(436, 68);
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
            this.localizarButton.Location = new System.Drawing.Point(436, 34);
            this.localizarButton.Name = "localizarButton";
            this.localizarButton.Size = new System.Drawing.Size(92, 28);
            this.localizarButton.TabIndex = 9;
            this.localizarButton.Text = "&Localizar";
            this.localizarButton.UseVisualStyleBackColor = true;
            // 
            // LocalizarUsuarioForm
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.localizarButton);
            this.Controls.Add(this.usuarioTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocalizarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Usuário";
            this.usuarioTabControl.ResumeLayout(false);
            this.codigoTabPage.ResumeLayout(false);
            this.codigoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoDataGridView)).EndInit();
            this.nomeTabPage.ResumeLayout(false);
            this.nomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeDataGridView)).EndInit();
            this.IdentificadorTabPage.ResumeLayout(false);
            this.IdentificadorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identificadorDataGridView)).EndInit();
            this.emailTabPage.ResumeLayout(false);
            this.emailTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button localizarButton;
        private System.Windows.Forms.TabControl usuarioTabControl;
        private System.Windows.Forms.TabPage codigoTabPage;
        private System.Windows.Forms.DataGridView codigoDataGridView;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TabPage nomeTabPage;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView nomeDataGridView;
        private System.Windows.Forms.TabPage IdentificadorTabPage;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.DataGridView identificadorDataGridView;
        private System.Windows.Forms.TabPage emailTabPage;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView emailDataGridView;
    }
}