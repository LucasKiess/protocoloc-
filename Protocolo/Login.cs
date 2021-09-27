using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Protocolo.View;
using Protocolo.Model; 

namespace Protocolo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        UsuariosMod obj = new UsuariosMod();

        private void Logar()
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o usuário!");
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha a senha!");
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            obj.Usuario = txtUsuario.Text;
            obj.Senha = txtSenha.Text;
            obj.Status = "Ativo";
            obj = new UsuariosMod().Logar(obj);

            if (obj.Usuario == null && obj.Senha == null)
            {
                MessageBox.Show("Dados incorretos ou usuário inativo", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                return;
            }
            else
            {
                Program.nomeUsuarioLogado = obj.Nome;
                Program.nivelUsuarioLogado = obj.Nivel;
                DateTime dataEntrada = DateTime.Now;
                Program.horaUsuarioLogado = dataEntrada.ToString();
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.Show();
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Logar();
            /*frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();*/
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
