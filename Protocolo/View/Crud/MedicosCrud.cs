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
    public partial class frmMedicosCrud : Form
    {
        public frmMedicosCrud()
        {
            InitializeComponent();
        }
        MedicosMod obj = new MedicosMod();
        private void CarregarComboBox()
        {
            DataTable dt = new EspecialidadesMod().CarregarComboBox();
            cbEspecialidade.DataSource = dt;
            cbEspecialidade.ValueMember = "id";
            cbEspecialidade.DisplayMember = "nomeEsp";
        }

        private void frmMedicosCrud_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            lblModo.Text = Program.modo;
            if (lblModo.Text == "Inserção")
            {
                cbEspecialidade.SelectedIndex = 0;
                btnEditar.Visible = false;
                btnEditar.Enabled = false;
                btnDeletar.Visible = false;
                btnDeletar.Enabled = false;
            }
            else
            {
                btnSalvar.Visible = false;
                btnSalvar.Enabled = false;
                txtCrm.Enabled = false;
                txtNome.Text = Program.nome;
                txtCrm.Text = Convert.ToInt32(Program.crmAntigo).ToString();
                cbEspecialidade.SelectedValue = Program.especialidade;
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCrm.Text = "";
            cbEspecialidade.SelectedIndex = 0;
        }
        private void CadastrarMedico()
        {
            obj.Nome = txtNome.Text;
            obj.Crm = Convert.ToInt32(txtCrm.Text);
            obj.Especialidade = Convert.ToInt32(cbEspecialidade.SelectedValue);
            obj.Data_cadastro = DateTime.Now.ToString();
            

            int retorno = MedicosMod.CadastrarMedico(obj);
            if (retorno == 0)
            {
                MessageBox.Show("CRM já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCrm.Text = "";
                txtCrm.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Médico inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir médico!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarMedico()
        {
            obj.Nome = txtNome.Text;
            obj.Crm = Convert.ToInt32(txtCrm.Text);
            obj.Especialidade = Convert.ToInt32(cbEspecialidade.SelectedValue);

            int retorno = MedicosMod.EditarMedico(obj);
            if (retorno == 0)
            {
                MessageBox.Show("CRM já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCrm.Text = "";
                txtCrm.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Médico alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar médico!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarMedico()
        {
            obj.Id = Program.id;
            int retorno = MedicosMod.DeletarMedico(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Médico deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao deletar médico!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmMedicosCrud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.modo = "";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCrm.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo CRM", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCrm.Text = "";
                txtCrm.Focus();
                return;
            }
            
            CadastrarMedico();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCrm.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo CRM", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCrm.Text = "";
                txtCrm.Focus();
                return;
            }

            EditarMedico();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarMedico();
                LimparCampos();
                this.Hide();
            }
        }
    }
}
