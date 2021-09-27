using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class LocaisMod
    {
        private int id;
        private string nome;
        private string data_cadastro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }

        public static int CadastrarLocal(LocaisMod obj)
        {
            return new LocaisCont().CadastrarLocal(obj);
        }
        public static int EditarLocal(LocaisMod obj)
        {
            return new LocaisCont().EditarLocal(obj);
        }
        public static int DeletarLocal(LocaisMod obj)
        {
            return new LocaisCont().DeletarLocal(obj);
        }
        public List<LocaisMod> Listar()
        {
            return new LocaisCont().Listar();
        }
        public DataTable ListarPerso()
        {
            return new LocaisCont().ListarPerso();
        }
    }
}
