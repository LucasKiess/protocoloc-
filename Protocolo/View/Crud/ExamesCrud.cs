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

namespace Protocolo.View.Crud
{
    public partial class frmExamesCrud : Form
    {
        public frmExamesCrud()
        {
            InitializeComponent();
        }
        ExamesMod obj = new ExamesMod();
        private void CarregarComboBoxTipoExames()
        {
            DataTable dt = new TiposMod().CarregarComboBoxTipoExame();
            cbTipo.DataSource = dt;
            cbTipo.ValueMember = "id";
            cbTipo.DisplayMember = "descricao";
        }
        private void CarregarComboBoxTipoExamesSigla(string sigla)
        {
            DataTable dt = new TiposMod().CarregarComboBoxTipoExameSigla(sigla);
            cbTipo.DataSource = dt;
            cbTipo.ValueMember = "id";
            cbTipo.DisplayMember = "descricao";
        }
        private void CarregarComboBoxConvenio()
        {
            DataTable dt = new ConveniosMod().CarregarComboBoxConvenio();
            cbConvenio.DataSource = dt;
            cbConvenio.ValueMember = "id";
            cbConvenio.DisplayMember = "nome";
        }
        private void BuscarMedicoCrm(int crm)
        {
            DataTable dt = new MedicosMod().BuscarMedicoCrm(crm);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("MÉDICO NÃO ENCONTRADO", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCrm.Text = "";
                txtCrm.Focus();
                txtIdMedico.Text = "";
                txtNomeMedico.Text = "";
                return;
            }
            else
            {
                txtIdMedico.Text = dt.Rows[0]["id"].ToString();
                txtNomeMedico.Text = dt.Rows[0]["nome"].ToString();
            }
            
        }

        private void frmExamesCrud_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTipoExames();
            CarregarComboBoxConvenio();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if(txtTipo.Text.Length == 1)
            {
                txtNumero.Focus();
            }
            cbTipo.DataSource = null;
            CarregarComboBoxTipoExamesSigla(txtTipo.Text);
            if(txtTipo.Text == "")
            {
                CarregarComboBoxTipoExames();
            }
            if(cbTipo.Items.Count == 0 && txtTipo.Text != "")
            {
                MessageBox.Show("TIPO DE EXAME INVÁLIDO", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipo.Text = "";
                txtTipo.Focus();
            }
        }

       

        private void cbTipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCrm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BuscarMedicoCrm(Convert.ToInt32(txtCrm.Text));
            }
        }

        private void btnProcuraMedico_Click(object sender, EventArgs e)
        {
            Program.idPaciente = lblIdPaciente.Text;
            Program.nomePaciente = txtNomePaciente.Text;
            Program.idadePaciente = txtIdadePaciente.Text;
            Program.telefonePaciente = txtTelefonePaciente.Text;
            Program.tipoExame = txtTipo.Text;
            Program.cbExame = cbTipo.Text;
            Program.numExame = txtNumero.Text;
            frmMedicosView frm = new frmMedicosView();
            this.Hide();
            frm.Show();
            Program.modo = "Selecionar MÉDICO";
            frm.lblModo.Text = Program.modo;
            frm.lblModo.Visible = true;
        }

        private void frmExamesCrud_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmExamesView frm = new frmExamesView();
            frm.Show();
        }
    }
}
