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
    public partial class frmTipoExamesCrud : Form
    {
        public frmTipoExamesCrud()
        {
            InitializeComponent();
        }
        TiposMod obj = new TiposMod();

        private void frmTipoExamesCrud_Load(object sender, EventArgs e)
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
                txtSigla.Text = Program.sigla;
                txtDescricao.Text = Program.descricao;
            }
        }
        private void LimparCampos()
        {
            txtSigla.Text = "";
            txtDescricao.Text = "";
        }
        private void CadastrarTipoExame()
        {
            obj.Sigla = txtSigla.Text;
            obj.Descricao = txtDescricao.Text;

            int retorno = TiposMod.CadastrarTipoExame(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Sigla já está sendo utilizada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSigla.Text = "";
                txtSigla.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Tipo de exame inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir tipo de exame!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarTipoExame()
        {
            obj.Sigla = txtSigla.Text;
            obj.Descricao = txtDescricao.Text;

            int retorno = TiposMod.EditarTipoExame(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Sigla já está sendo utilizada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSigla.Text = "";
                txtSigla.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Tipo de exame alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar tipo de exame!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarTipoExame()
        {
            obj.Id = Program.id;
            int retorno = TiposMod.DeletarTipoExame(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Tipo de exame deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao deletar tipo de exame!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTipoExamesCrud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.modo = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo sigla", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSigla.Text = "";
                txtSigla.Focus();
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo descrição", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }
            CadastrarTipoExame();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo sigla", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSigla.Text = "";
                txtSigla.Focus();
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo descrição", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }
            EditarTipoExame();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarTipoExame();

            }
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            if(txtSigla.Text.Length == 1)
            {
                txtDescricao.Focus();
            }
        }
    }
}
