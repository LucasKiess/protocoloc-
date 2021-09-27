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
    public partial class frmPacientesCrud : Form
    {
        public frmPacientesCrud()
        {
            InitializeComponent();
        }
        PacientesMod obj = new PacientesMod();

        private void frmPacientesCrud_Load(object sender, EventArgs e)
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
                txtIdade.Text = Program.idade.ToString();
                txtTelefone.Text = Program.telefone;
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtTelefone.Text = "";
        }

        private void CadastrarPaciente()
        {
            obj.Nome = txtNome.Text;
            obj.Idade = Convert.ToInt32(txtIdade.Text);
            obj.Telefone = txtTelefone.Text;
            

            int retorno = PacientesMod.CadastrarPaciente(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Paciente inserido!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao inserir paciente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarPaciente()
        {
            obj.Nome = txtNome.Text;
            obj.Idade = Convert.ToInt32(txtIdade.Text);
            obj.Telefone = txtTelefone.Text;

            int retorno = PacientesMod.EditarPaciente(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Paciente alterado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao alterar paciente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletarPaciente()
        {
            obj.Id = Program.id;
            int retorno = PacientesMod.DeletarPaciente(obj);
            if (retorno > 0)
            {
                MessageBox.Show("Paciente deletado!", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao deletar paciente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPacientesCrud_FormClosed(object sender, FormClosedEventArgs e)
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
            if (txtIdade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo idade", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade.Text = "";
                txtIdade.Focus();
                return;
            }
            
            CadastrarPaciente();
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
            if (txtIdade.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo idade", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade.Text = "";
                txtIdade.Focus();
                return;
            }

            EditarPaciente();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeletarPaciente();
                LimparCampos();
                this.Hide();
            }
        }
    }
}
