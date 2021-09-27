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

namespace Protocolo.View
{
    public partial class frmConveniosView : Form
    {
        public frmConveniosView()
        {
            InitializeComponent();
        }
        ConveniosMod obj = new ConveniosMod();

        private void Listar()
        {
            try
            {
                /*List<ConveniosMod> lista = new List<ConveniosMod>();
                lista = new ConveniosMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new ConveniosMod().ListarPerso();
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmConveniosView_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.data_cadastro = grid.CurrentRow.Cells[2].Value.ToString();
            Program.convenioAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmConveniosCrud frm = new frmConveniosCrud();
            frm.Show();
        }

        private void frmConveniosView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmConveniosCrud frm = new frmConveniosCrud();
            frm.Show();
        }

        private void frmConveniosView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
