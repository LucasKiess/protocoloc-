using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class MedicosMod
    {
        private int id;
        private string nome;
        private int crm;
        private int especialidade;
        private string nomeEspecialidade;
        private string data_cadastro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Crm { get => crm; set => crm = value; }
        public int Especialidade { get => especialidade; set => especialidade = value; }
        public string NomeEspecialidade { get => nomeEspecialidade; set => nomeEspecialidade = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }
        
        public static int CadastrarMedico(MedicosMod obj)
        {
            return new MedicosCont().CadastrarMedico(obj);
        }
        public static int EditarMedico(MedicosMod obj)
        {
            return new MedicosCont().EditarMedico(obj);
        }
        public static int DeletarMedico(MedicosMod obj)
        {
            return new MedicosCont().DeletarMedico(obj);    
        }
        public List<MedicosMod> Listar()
        {
            return new MedicosCont().Listar();
        }
        public DataTable ListarMedico()
        {
            return new MedicosCont().ListarMedico();
        }
        public DataTable BuscarMedicoCrm(int crm)
        {
            return new MedicosCont().BuscarMedicoCrm(crm);
        }
    }
}
