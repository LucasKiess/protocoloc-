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
using Protocolo.View;

namespace Protocolo.View
{
    public partial class frmMedicosView : Form
    {
        public frmMedicosView()
        {
            InitializeComponent();
        }
        MedicosMod obj = new MedicosMod();
        ExamesMod objE = new ExamesMod();

        private void Listar()
        {
            try
            {
                /*List<MedicosMod> lista = new List<MedicosMod>();
                lista = new MedicosMod().Listar();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;*/
                DataTable dt = new MedicosMod().ListarMedico();
                grid.AutoGenerateColumns = false;
                grid.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar. " + ex.Message);
            }
        }

        private void frmMedicosView_Load(object sender, EventArgs e)
        {
            Listar();
            //Console.WriteLine(obj.NomeEspecialidade);
            
        }

        /*private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.modo = "Alteração";
            Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
            Program.crmAntigo = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
            Program.especialidade = Convert.ToInt32(grid.CurrentRow.Cells[3].Value.ToString());
            Program.data_cadastro = grid.CurrentRow.Cells[4].Value.ToString();
            Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

            frmMedicosCrud frm = new frmMedicosCrud();
            frm.Show();
        }*/

        private void frmMedicosView_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Program.modo = "Inserção";
            frmMedicosCrud frm = new frmMedicosCrud();
            frm.Show();
        }

        private void grid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(lblModo.Text == "Selecionar MÉDICO")
            {
                
                frmExamesCrud frmE = new frmExamesCrud();
                Program.nome = grid.CurrentRow.Cells[1].Value.ToString();
                Program.crmAntigo = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
                Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());
                frmE.txtNomeMedico.Text = Program.nome;
                frmE.txtCrm.Text = Program.crmAntigo.ToString();
                frmE.txtIdMedico.Text = Program.id.ToString();
                frmE.lblIdPaciente.Text = Program.idPaciente;
                frmE.txtNomePaciente.Text = Program.nomePaciente;
                frmE.txtIdadePaciente.Text = Program.idadePaciente;
                frmE.txtTelefonePaciente.Text = Program.telefonePaciente;
                frmE.txtTipo.Text = Program.tipoExame;
                frmE.cbTipo.SelectedItem = Program.cbExame;
                frmE.txtNumero.Text = Program.numExame;
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
                Program.crmAntigo = Convert.ToInt32(grid.CurrentRow.Cells[2].Value.ToString());
                Program.especialidade = Convert.ToInt32(grid.CurrentRow.Cells[3].Value.ToString());
                Program.data_cadastro = grid.CurrentRow.Cells[5].Value.ToString();
                Program.id = Convert.ToInt32(grid.CurrentRow.Cells[0].Value.ToString());

                frmMedicosCrud frm = new frmMedicosCrud();
                frm.Show();
            }
            
        }

        private void frmMedicosView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(lblModo.Text == "Selecionar MÉDICO")
            {
                this.Hide();
                Program.modo = "";
                lblModo.Visible = false;
                lblModo.Text = "...";
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
            }
            
        }
    }
}
