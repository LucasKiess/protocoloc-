using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;
using System.Data;

namespace Protocolo.Model
{
    public class PacientesMod
    {
        private int id;
        private string nome;
        private int idade;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public static int CadastrarPaciente(PacientesMod obj)
        {
            return new PacientesCont().CadastrarPaciente(obj);
        }
        public static int EditarPaciente(PacientesMod obj)
        {
            return new PacientesCont().EditarPaciente(obj);
        }
        public static int DeletarPaciente(PacientesMod obj)
        {
            return new PacientesCont().DeletarPaciente(obj);
        }
        public List<PacientesMod> Listar()
        {
            return new PacientesCont().Listar();
        }
        public DataTable ListarPerso()
        {
            return new PacientesCont().ListarPerso();
        }
        public DataTable BuscarNome(string nome)
        {
            return new PacientesCont().BuscarNome(nome);
        }
    }
}
