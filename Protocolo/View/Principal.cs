using Protocolo.View.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protocolo.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuariosView frm = new frmUsuariosView();
            this.Hide();
            frm.Show();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocaisView frm = new frmLocaisView();
            this.Hide();
            frm.Show();
        }

        private void convêniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConveniosView frm = new frmConveniosView();
            this.Hide();
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.nomeUsuarioLogado;
            lblNivel.Text = Program.nivelUsuarioLogado;
            lblHora.Text = Program.horaUsuarioLogado;
            timer2.Start();
            if(Program.nivelUsuarioLogado != "Admin")
            {
                usuáriosToolStripMenuItem.Enabled = false;
            }
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecialidadesView frm = new frmEspecialidadesView();
            this.Hide();
            frm.Show();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoExamesView frm = new frmTipoExamesView();
            this.Hide();
            frm.Show();
        }

        private void genéricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoGenericosView frm = new frmTipoGenericosView();
            this.Hide();
            frm.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicosView frm = new frmMedicosView();
            this.Hide();
            frm.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientesView frm = new frmPacientesView();
            this.Hide();
            frm.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void examesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmExamesView frm = new frmExamesView();
            this.Hide();
            frm.Show();
        }
    }
}
