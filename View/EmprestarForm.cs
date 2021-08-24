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
    public partial class EmprestarForm : Form
    {
        public EmprestarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmprestarForm_Load(object sender, EventArgs e)
        {
            dataEmprestimoDateTimePicker.Value = DateTime.Now;
        }

        private void localizarAlunoButton_Click(object sender, EventArgs e)
        {
            LocalizarAlunoForm form = new LocalizarAlunoForm();
            form.ShowDialog();
        }

        private void localizarLivroButton_Click(object sender, EventArgs e)
        {
            LocalizarLivroForm form = new LocalizarLivroForm();
            form.ShowDialog();
        }
    }
}
