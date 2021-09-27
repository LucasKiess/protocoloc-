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
    public partial class frmLocaisCrud : Form
    {
        public frmLocaisCrud()
        {
            InitializeComponent();
        }
        LocaisMod obj = new LocaisMod();

        private void frmLocaisCrud_Load(object sender, EventArgs e)
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

        private void CadastrarLocal()
        {
            obj.Nome = txtNome.Text;
            obj.Data_cadastro = DateTime.Now.ToString();

            int retorno = LocaisMod.CadastrarLocal(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Local já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Local inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir local!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarLocal()
        {
            obj.Nome = txtNome.Text;

            int retorno = LocaisMod.EditarLocal(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Local já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Local alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar local!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarLocal()
        {
            obj.Id = Program.id;
            int retorno = LocaisMod.DeletarLocal(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Local deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao deletar local!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLocaisCrud_FormClosed(object sender, FormClosedEventArgs e)
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
            CadastrarLocal();
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
            EditarLocal();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarLocal();
                
            }
        }
    }
}
