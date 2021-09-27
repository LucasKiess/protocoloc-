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
    public partial class frmUsuariosView : Form
    {
        public frmUsuariosView()
        {
            InitializeComponent();
        }
        UsuariosMod obj = new UsuariosMod();

        private void Listar()
        {
            try
            {
                List<UsuariosMod> lista = new List<UsuariosMod>();
                lista = new UsuariosMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmUsuariosView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaprotocoloDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.usuariosTableAdapter.Fill(this.sistemaprotocoloDataSet.usuarios);
            Listar();

        }


        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.usuario = grid.CurrentRow.Cells[2].Value.ToString();
            Program.senha = grid.CurrentRow.Cells[3].Value.ToString();
            Program.nivel = grid.CurrentRow.Cells[4].Value.ToString();
            Program.status = grid.CurrentRow.Cells[5].Value.ToString();
            Program.usuarioAntigo = grid.CurrentRow.Cells[2].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
            
            frmUsuariosCrud frm = new frmUsuariosCrud();
            frm.Show();
        }

        private void frmUsuariosView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmUsuariosCrud frm = new frmUsuariosCrud();
            frm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmUsuariosCrud frm = new frmUsuariosCrud();
            frm.Show();
        }

        private void frmUsuariosView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }
    }
}
