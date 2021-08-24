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
    public partial class CadUsuariosForm : Form
    {
        public CadUsuariosForm()
        {
            InitializeComponent();
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            LocalizarUsuarioForm form = new LocalizarUsuarioForm();
            form.ShowDialog();
        }
    }
}
