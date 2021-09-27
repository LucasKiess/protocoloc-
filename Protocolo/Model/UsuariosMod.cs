using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class UsuariosMod
    {
        private int id;
        private string nome;
        private string usuario;
        private string senha;
        private string nivel;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Status { get => status; set => status = value; }

        public static int CadastrarUsuario(UsuariosMod obj)
        {
            return new UsuariosCont().CadastrarUsuario(obj);
        }
        public static int EditarUsuario(UsuariosMod obj)
        {
            return new UsuariosCont().EditarUsuario(obj);
        }
        public static int DeletarUsuario(UsuariosMod obj)
        {
            return new UsuariosCont().DeletarUsuario(obj);
        }
        public UsuariosMod Logar(UsuariosMod obj)
        {
            return new UsuariosCont().Logar(obj);
        }
        public List<UsuariosMod> Listar()
        {
            return new UsuariosCont().Listar();
        }

    }
}
