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
    public partial class frmLocaisView : Form
    {
        public frmLocaisView()
        {
            InitializeComponent();
        }
        LocaisMod obj = new LocaisMod();

        private void Listar()
        {
            try
            {
                /*List<LocaisMod> lista = new List<LocaisMod>();
                lista = new LocaisMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new LocaisMod().ListarPerso();
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmLocaisView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaprotocoloDataSet.locais'. Você pode movê-la ou removê-la conforme necessário.
            //this.locaisTableAdapter.Fill(this.sistemaprotocoloDataSet.locais);
            Listar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.data_cadastro = grid.CurrentRow.Cells[2].Value.ToString();
            Program.localAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmLocaisCrud frm = new frmLocaisCrud();
            frm.Show();
        }

        private void frmLocaisView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmLocaisCrud frm = new frmLocaisCrud();
            frm.Show();
        }

        private void frmLocaisView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
