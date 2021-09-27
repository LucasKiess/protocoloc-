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
    public partial class frmUsuariosCrud : Form
    {
        public frmUsuariosCrud()
        {
            InitializeComponent();
        }
        UsuariosMod obj = new UsuariosMod();

        private void frmUsuariosCrud_Load(object sender, EventArgs e)
        {
            lblModo.Text = Program.modo;
            if(lblModo.Text == "Inserção")
            {
                cbNivel.SelectedIndex = 1;
                cbStatus.SelectedIndex = 0;
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
                txtUsuario.Text = Program.usuario;
                txtSenha.Text = Program.senha;
                cbNivel.SelectedItem = Program.nivel;
                cbStatus.SelectedItem = Program.status;
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void CadastrarUsuario()
        {
            obj.Nome = txtNome.Text;
            obj.Usuario = txtUsuario.Text;
            obj.Senha = txtSenha.Text;
            obj.Nivel = cbNivel.SelectedItem.ToString();
            obj.Status = cbStatus.SelectedItem.ToString();
            string sinal;

            int retorno = UsuariosMod.CadastrarUsuario(obj);
            if(retorno == 0)
            {
                MessageBox.Show("Usuário já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Usuário inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir usuário!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarUsuario()
        {
            obj.Nome = txtNome.Text;
            obj.Usuario = txtUsuario.Text;
            obj.Senha = txtSenha.Text;
            obj.Nivel = cbNivel.SelectedItem.ToString();
            obj.Status = cbStatus.SelectedItem.ToString();
            
            int retorno = UsuariosMod.EditarUsuario(obj);
            if (retorno == 0)
            {
                MessageBox.Show("Usuário já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (retorno > 0)
            {
                MessageBox.Show("Usuário alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar usuário!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarUsuario()
        {
            obj.Id = Program.id;
            int retorno = UsuariosMod.DeletarUsuario(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Usuário deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao deletar usuário!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuariosCrud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.modo = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo usuário", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo senha", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            CadastrarUsuario();
            
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
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo usuário", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo senha", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            EditarUsuario();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarUsuario();
                LimparCampos();
                this.Hide();
            }
        }
    }
}
