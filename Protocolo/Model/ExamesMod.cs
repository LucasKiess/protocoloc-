using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;
namespace Protocolo.Model
{
    public class ExamesMod
    {
        private int id;
        private int tipo;
        private int numero;
        private int paciente;
        private int medico;
        private int convenio;
        private string data_entrada;
        private int envio;
        private int entrega;

        //RECUPERAR INFORMAÇÕES DO FORMULÁRIO
        private string idPaciente;
        private string nomePaciente;
        private string idadePaciente;
        private string telefonePaciente;
        private string tipoExame;
        private string cbExame;
        private string numExame;


        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Paciente { get => paciente; set => paciente = value; }
        public int Medico { get => medico; set => medico = value; }
        public int Convenio { get => convenio; set => convenio = value; }
        public string Data_entrada { get => data_entrada; set => data_entrada = value; }
        public int Envio { get => envio; set => envio = value; }
        public int Entrega { get => entrega; set => entrega = value; }
        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NomePaciente { get => nomePaciente; set => nomePaciente = value; }
        public string IdadePaciente { get => idadePaciente; set => idadePaciente = value; }
        public string TelefonePaciente { get => telefonePaciente; set => telefonePaciente = value; }
        public string TipoExame { get => tipoExame; set => tipoExame = value; }
        public string CbExame { get => cbExame; set => cbExame = value; }
        public string NumExame { get => numExame; set => numExame = value; }

        public static int CadastrarExame(ExamesMod obj)
        {
            return new ExamesCont().CadastrarExame(obj);
        }
        public static int EditarExame(ExamesMod obj)
        {
            return new ExamesCont().EditarExame(obj);
        }
        public static int DeletarExame(ExamesMod obj)
        {
            return new ExamesCont().DeletarExame(obj);
        }
        public List<ExamesMod> Listar()
        {
            return new ExamesCont().Listar();
        }
        public DataTable ListarPerso()
        {
            return new ExamesCont().ListarExame();
        }
        public DataTable BuscarNome(string nome)
        {
            return new ExamesCont().BuscarNome(nome);
        }
        public DataTable BuscarPeriodo(string data_inicio, string data_fim)
        {
            return new ExamesCont().BuscarPeriodo(data_inicio, data_fim);
        }
    }
}
