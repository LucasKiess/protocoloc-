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
    public partial class frmTipoExamesView : Form
    {
        public frmTipoExamesView()
        {
            InitializeComponent();
        }
        TiposMod obj = new TiposMod();

        private void Listar()
        {
            try
            {
                List<TiposMod> lista = new List<TiposMod>();
                lista = new TiposMod().ListarTipoExame();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmTipoExamesView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaprotocoloDataSet.tipo_exames'. Você pode movê-la ou removê-la conforme necessário.
            //this.tipo_examesTableAdapter.Fill(this.sistemaprotocoloDataSet.tipo_exames);
            Listar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.sigla = grid.CurrentRow.Cells[1].Value.ToString();
            Program.descricao = grid.CurrentRow.Cells[2].Value.ToString();
            Program.tipoAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmTipoExamesCrud frm = new frmTipoExamesCrud();
            frm.Show();
        }

        private void frmTipoExamesView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmTipoExamesCrud frm = new frmTipoExamesCrud();
            frm.Show();
        }

        private void frmTipoExamesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
