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
    public partial class frmConveniosCrud : Form
    {
        public frmConveniosCrud()
        {
            InitializeComponent();
        }
        ConveniosMod obj = new ConveniosMod();

        private void frmConveniosCrud_Load(object sender, EventArgs e)
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

        private void CadastrarConvenio()
        {
            obj.Nome = txtNome.Text;
            obj.Data_cadastro = DateTime.Now.ToString();

            int retorno = ConveniosMod.CadastrarConvenio(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Convênio já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Convênio inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir convênio!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarConvenio()
        {
            obj.Nome = txtNome.Text;

            int retorno = ConveniosMod.EditarConvenio(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Convênio já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Convênio alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar convênio!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarConvenio()
        {
            obj.Id = Program.id;
            int retorno = ConveniosMod.DeletarConvenio(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Convênio deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao deletar convênio!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConveniosCrud_FormClosed(object sender, FormClosedEventArgs e)
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
            CadastrarConvenio();
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
            EditarConvenio();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarConvenio();

            }
        }
    }
}
