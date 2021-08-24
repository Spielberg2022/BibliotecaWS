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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            PrincipalMDIParent principalForm = new PrincipalMDIParent();
            principalForm.Show();
            this.Hide();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
