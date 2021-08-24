﻿using System;
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
    public partial class PrincipalMDIParent : Form
    {
        private int childFormNumber = 0;

        public PrincipalMDIParent()
        {
            InitializeComponent();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PrincipalMDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox sobre = new AboutBox();
            sobre.ShowDialog();
        }

        private void fazerLogoffDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAlunosForm childForm = new CadAlunosForm();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLivrosForm childForm = new CadLivrosForm();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsuariosForm childForm = new CadUsuariosForm();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }

        private void emprestarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmprestarForm childForm = new EmprestarForm();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }
    }
}