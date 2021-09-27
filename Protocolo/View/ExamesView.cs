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
    public partial class frmExamesView : Form
    {
        public frmExamesView()
        {
            InitializeComponent();
        }
        ExamesMod obj = new ExamesMod();

        private void Listar()
        {
            try
            {
                /*List<LocaisMod> lista = new List<LocaisMod>();
                lista = new LocaisMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new ExamesMod().ListarPerso();
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
                DataTable dt = new ExamesMod().BuscarNome(nome);
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void BuscarPeriodo(string data_inicio, string data_fim)
        {
            try
            {
                /*List<LocaisMod> lista = new List<LocaisMod>();
                lista = new LocaisMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new ExamesMod().BuscarPeriodo(data_inicio, data_fim);
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmExamesView_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
        }

        private void frmExamesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }

        private void frmExamesView_Activated(object sender, EventArgs e)
        {
            txtBusca.Focus();
            grid.DataSource = null;
            txtBusca.Text = "";
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.idade = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
            Program.telefone = grid.CurrentRow.Cells[3].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmPacientesCrud frm = new frmPacientesCrud();
            frm.Show();*/
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Selecionar PACIENTE";
            frmPacientesView frm = new frmPacientesView();
            frm.lblModo.Text = Program.modo;
            frm.lblModo.Visible = true;
            frm.lblRodape.Text = "*Duplo clique para selecionar ou adicione um novo paciente";
            this.Hide();
            frm.Show();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarNome(txtBusca.Text);
            if (txtBusca.Text.Length == 0)
            {
                grid.DataSource = null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBuscaPeriodo_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            grid.DataSource = null;
            BuscarPeriodo(dtInicio.Text, dtFim.Text);
        }
    }
}
