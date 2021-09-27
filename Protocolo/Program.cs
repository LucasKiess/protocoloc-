using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Protocolo
{
    
    static class Program
    {
        //VARIÁVEIS GLOBAIS
        public static string modo;
        
        public static string nomeUsuarioLogado;
        public static string nivelUsuarioLogado;
        public static string horaUsuarioLogado;

        public static string nome;
        public static string usuario;
        public static string senha;
        public static string nivel;
        public static string status;
        public static int id;
        public static string usuarioAntigo;
        public static string sigla;
        public static string descricao;
        public static int idade;
        public static string telefone;
        public static int crmAntigo;
        public static int especialidade;

        public static string localAntigo;
        public static string convenioAntigo;
        public static string data_cadastro;
        
        public static string tipoAntigo;

        public static int tipo;
        public static int numero;
        public static int paciente;
        public static int medico;
        public static int convenio;
        public static string data_entrada;
        public static int envio;
        public static int entrega;

        public static string idPaciente;
        public static string nomePaciente;
        public static string idadePaciente;
        public static string telefonePaciente;
        public static string tipoExame;
        public static string cbExame;
        public static string numExame;


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
