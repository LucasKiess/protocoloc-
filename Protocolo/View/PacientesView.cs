using Protocolo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Protocolo.Model;
using Protocolo.View.Crud;

namespace Protocolo.View
{
    public partial class frmPacientesView : Form
    {
        public frmPacientesView()
        {
            InitializeComponent();
        }
        PacientesMod obj = new PacientesMod();
        private void Listar()
        {
            try
            {
                /*List<LocaisMod> lista = new List<LocaisMod>();
                lista = new LocaisMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new PacientesMod().ListarPerso();
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }
        private void BuscarNome(string nome)
        {
            try
            {
                /*List<LocaisMod> lista = new List<LocaisMod>();
                lista = new LocaisMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new PacientesMod().BuscarNome(nome);
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmPacientesView_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblModo.Text == "Selecionar PACIENTE")
            {
                frmExamesCrud frmE = new frmExamesCrud();
                Program.idPaciente = grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomePaciente = grid.CurrentRow.Cells[1].Value.ToString();
                Program.idadePaciente = grid.CurrentRow.Cells[2].Value.ToString();
                Program.telefonePaciente = grid.CurrentRow.Cells[3].Value.ToString();
                frmE.lblIdPaciente.Text = Program.idPaciente;
                frmE.txtNomePaciente.Text = Program.nomePaciente;
                frmE.txtIdadePaciente.Text = Program.idadePaciente;
                frmE.txtTelefonePaciente.Text = Program.telefonePaciente;
                this.Hide();
                frmE.Show();
                Program.modo = "";
                lblModo.Visible = false;
                lblModo.Text = "...";
            }
            else
            {
                Program.modo = "Alteração";
                Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
                Program.idade = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
                Program.telefone = grid.CurrentRow.Cells[3].Value.ToString();
                Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

                frmPacientesCrud frm = new frmPacientesCrud();
                frm.Show();
            }
            
        }

        private void frmPacientesView_Activated(object sender, EventArgs e)
        {
            txtBusca.Focus();
            grid.DataSource = null;
            txtBusca.Text = "";
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmPacientesCrud frm = new frmPacientesCrud();
            frm.Show();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarNome(txtBusca.Text);
            if(txtBusca.Text.Length == 0)
            {
                grid.DataSource = null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void frmPacientesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(lblModo.Text == "Selecionar PACIENTE")
            {
                Program.modo = "";
                lblModo.Text = "";
                lblModo.Visible = false;
                frmExamesView frm = new frmExamesView();
                frm.Show();
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
            }
            
        }
    }
}
