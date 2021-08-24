using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWS.View
{
    public partial class ReceberForm : Form
    {
        public ReceberForm()
        {
            InitializeComponent();
        }

        private void ReceberForm_Load(object sender, EventArgs e)
        {
            dataDevolucaoDateTimePicker.Value = DateTime.Now;
        }

        private void multaButton_Click(object sender, EventArgs e)
        {
            receberButton.Enabled = true;
        }

        private void localizarAlunoButton_Click(object sender, EventArgs e)
        {
            LocalizarEmprestimoForm form = new LocalizarEmprestimoForm();
            form.ShowDialog();
        }
    }
}
