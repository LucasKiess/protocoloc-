using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Protocolo.View.Crud;
using Protocolo.Model;

namespace Protocolo.View
{
    public partial class frmTipoGenericosView : Form
    {
        public frmTipoGenericosView()
        {
            InitializeComponent();
        }
        TiposMod obj = new TiposMod();

        private void Listar()
        {
            try
            {
                List<TiposMod> lista = new List<TiposMod>();
                lista = new TiposMod().ListarTipoGenerico();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmTipoGenericosView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaprotocoloDataSet.tipo_genericos'. Você pode movê-la ou removê-la conforme necessário.
            //this.tipo_genericosTableAdapter.Fill(this.sistemaprotocoloDataSet.tipo_genericos);
            Listar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.sigla = grid.CurrentRow.Cells[1].Value.ToString();
            Program.descricao = grid.CurrentRow.Cells[2].Value.ToString();
            Program.tipoAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmTipoGenericosCrud frm = new frmTipoGenericosCrud();
            frm.Show();
        }

        private void frmTipoGenericosView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmTipoGenericosCrud frm = new frmTipoGenericosCrud();
            frm.Show();
        }

        private void frmTipoGenericosView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
