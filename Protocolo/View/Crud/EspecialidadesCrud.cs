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
    public partial class frmEspecialidadesCrud : Form
    {
        public frmEspecialidadesCrud()
        {
            InitializeComponent();
        }
        EspecialidadesMod obj = new EspecialidadesMod();

        private void frmEspecialidadesCrud_Load(object sender, EventArgs e)
        {
            lblModo.Text = Program.modo;
            if (lblModo.Text == "Inserção")
            {
                btnEditar.Visible = false;
                btnEditar.Enabled = false;
                btnDeletar.Visible = false;
                btnDeletar.Enabled = false;
            }
            else
            {
                btnSalvar.Visible = false;
                btnSalvar.Enabled = false;
                txtNome.Text = Program.nome;
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
        }

        private void CadastrarEspecialidade()
        {
            obj.NomeEsp = txtNome.Text;
            obj.Data_cadastro = DateTime.Now.ToString();

            int retorno = EspecialidadesMod.CadastrarEspecialidade(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Especialidade já cadastrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Especialidade inserida!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir especialidade!"+retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarEspecialidade()
        {
            obj.NomeEsp = txtNome.Text;

            int retorno = EspecialidadesMod.EditarEspecialidade(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Especialidade já cadastrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Especialidade alterada!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar especialidade!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarEspecialidade()
        {
            obj.Id = Program.id;
            int retorno = EspecialidadesMod.DeletarEspecialidade(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Especialidade deletada!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao deletar especialidade!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEspecialidadesCrud_FormClosed(object sender, FormClosedEventArgs e)
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
            CadastrarEspecialidade();
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
            EditarEspecialidade();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarEspecialidade();
            }
        }
    }
}
