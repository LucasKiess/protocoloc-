using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class EspecialidadesMod
    {
        private int id;
        private string nomeEsp;
        private string data_cadastro;

        public int Id { get => id; set => id = value; }
        public string NomeEsp { get => nomeEsp; set => nomeEsp = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }

        public static int CadastrarEspecialidade(EspecialidadesMod obj)
        {
            return new EspecialidadesCont().CadastrarEspecialidade(obj);
        }
        public static int EditarEspecialidade(EspecialidadesMod obj)
        {
            return new EspecialidadesCont().EditarEspecialidade(obj);
        }
        public static int DeletarEspecialidade(EspecialidadesMod obj)
        {
            return new EspecialidadesCont().DeletarEspecialidade(obj);
        }
        public List<EspecialidadesMod> Listar()
        {
            return new EspecialidadesCont().Listar();
        }
        public DataTable CarregarComboBox()
        {
            return new EspecialidadesCont().CarregarComboBox();
        }
        public DataTable ListarPerso()
        {
            return new EspecialidadesCont().ListarPerso();
        }
    }
}
