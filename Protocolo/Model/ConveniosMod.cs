using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class ConveniosMod
    {
        private int id;
        private string nome;
        private string data_cadastro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }

        public static int CadastrarConvenio(ConveniosMod obj)
        {
            return new ConveniosCont().CadastrarConvenio(obj);
        }
        public static int EditarConvenio(ConveniosMod obj)
        {
            return new ConveniosCont().EditarConvenio(obj);
        }
        public static int DeletarConvenio(ConveniosMod obj)
        {
            return new ConveniosCont().DeletarConvenio(obj);
        }
        public List<ConveniosMod> Listar()
        {
            return new ConveniosCont().Listar();
        }
        public DataTable ListarPerso()
        {
            return new ConveniosCont().ListarPerso();
        }
        public DataTable CarregarComboBoxConvenio()
        {
            return new ConveniosCont().CarregarComboBox();
        }
    }
}
