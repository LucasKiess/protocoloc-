using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Controller;

namespace Protocolo.Model
{
    public class TiposMod
    {
        private int id;
        private string sigla;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        //MÉTODOS PARA TIPOS GENÉRICOS
        public static int CadastrarTipoGenerico(TiposMod obj)
        {
            return new TipoGenericosCont().CadastrarTipoGenerico(obj);
        }
        public static int EditarTipoGenerico(TiposMod obj)
        {
            return new TipoGenericosCont().EditarTipoGenerico(obj);
        }
        public static int DeletarTipoGenerico(TiposMod obj)
        {
            return new TipoGenericosCont().DeletarTipoGenerico(obj);
        }
        public List<TiposMod> ListarTipoGenerico()
        {
            return new TipoGenericosCont().ListarTipoGenerico();
        }

        //MÉTODOS PARA TIPOS EXAMES
        public static int CadastrarTipoExame(TiposMod obj)
        {
            return new TipoExamesCont().CadastrarTipoExame(obj);
        }
        public static int EditarTipoExame(TiposMod obj)
        {
            return new TipoExamesCont().EditarTipoExame(obj);
        }
        public static int DeletarTipoExame(TiposMod obj)
        {
            return new TipoExamesCont().DeletarTipoExame(obj);
        }
        public List<TiposMod> ListarTipoExame()
        {
            return new TipoExamesCont().ListarTipoExame();
        }
        public DataTable CarregarComboBoxTipoExame()
        {
            return new TipoExamesCont().CarregarComboBox();
        }
        public DataTable CarregarComboBoxTipoExameSigla(string sigla)
        {
            return new TipoExamesCont().CarregarComboBoxSigla(sigla);
        }
    }
}
