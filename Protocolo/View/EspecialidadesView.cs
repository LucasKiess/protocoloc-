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
    public partial class frmEspecialidadesView : Form
    {
        public frmEspecialidadesView()
        {
            InitializeComponent();
        }
        EspecialidadesMod obj = new EspecialidadesMod();

        private void Listar()
        {
            try
            {
                /*List<EspecialidadesMod> lista = new List<EspecialidadesMod>();
                lista = new EspecialidadesMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new EspecialidadesMod().ListarPerso();
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmEspecialidadesView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetProtocolo.especialidades'. Você pode movê-la ou removê-la conforme necessário.
            //this.especialidadesTableAdapter1.Fill(this.dataSetProtocolo.especialidades);
            // TODO: esta linha de código carrega dados na tabela 'sistemaprotocoloDataSet.especialidades'. Você pode movê-la ou removê-la conforme necessário.
            Listar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.data_cadastro = grid.CurrentRow.Cells[2].Value.ToString();
            Program.convenioAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmEspecialidadesCrud frm = new frmEspecialidadesCrud();
            frm.Show();
        }

        private void frmEspecialidadesView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmEspecialidadesCrud frm = new frmEspecialidadesCrud();
            frm.Show();
        }

        private void frmEspecialidadesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
