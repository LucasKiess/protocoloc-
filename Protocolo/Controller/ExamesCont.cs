using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Protocolo.Model;

namespace Protocolo.Controller
{
    public class ExamesCont
    {
        public int CadastrarExame(ExamesMod obj)
        {
            int retorno;
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "INSERT INTO exames ([tipo],[numero],[paciente],[medico],[convenio],[data_entrada]) VALUES (@tipo,@numero,@paciente,@medico,@convenio,@data_entrada)";
                    query.Parameters.Add("tipo", SqlDbType.Int).Value = obj.Tipo;
                    query.Parameters.Add("numero", SqlDbType.Int).Value = obj.Numero;
                    query.Parameters.Add("paciente", SqlDbType.Int).Value = obj.Paciente;
                    query.Parameters.Add("medico", SqlDbType.Int).Value = obj.Medico;
                    query.Parameters.Add("convenio", SqlDbType.Int).Value = obj.Convenio;
                    query.Parameters.Add("data_entrada", SqlDbType.VarChar).Value = obj.Data_entrada;
                    //VERIFICAR SE EXAME JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM exames WHERE tipo =@tipo AND numero =@numero";
                    queryVerifica.Parameters.Add("tipo", SqlDbType.Int).Value = obj.Tipo;
                    queryVerifica.Parameters.Add("numero", SqlDbType.Int).Value = obj.Numero;
                    queryVerifica.Connection = con;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = queryVerifica;
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        retorno = 0;
                        return retorno;
                    }
                    query.Connection = con;
                    retorno = query.ExecuteNonQuery();
                    con.Close();
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return retorno = -1;
            }
        }

        public int EditarExame(ExamesMod obj)
        {
            int retorno;
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "UPDATE exames SET tipo =@tipo, numero =@numero, paciente =@paciente, medico =@medico, convenio =@convenio WHERE id = @id";
                    query.Parameters.Add("tipo", SqlDbType.Int).Value = obj.Tipo;
                    query.Parameters.Add("numero", SqlDbType.Int).Value = obj.Numero;
                    query.Parameters.Add("paciente", SqlDbType.Int).Value = obj.Paciente;
                    query.Parameters.Add("medico", SqlDbType.Int).Value = obj.Medico;
                    query.Parameters.Add("convenio", SqlDbType.Int).Value = obj.Convenio;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    query.Connection = con;

                    retorno = query.ExecuteNonQuery();
                    con.Close();
                    return retorno;
                }
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }

        public int DeletarExame(ExamesMod obj)
        {
            int retorno;
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "DELETE FROM exames WHERE id = @id";
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    query.Connection = con;

                    retorno = query.ExecuteNonQuery();
                    con.Close();
                    return retorno;
                }
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }

        public List<ExamesMod> Listar()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "select * from exames";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<ExamesMod> lista = new List<ExamesMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ExamesMod dado = new ExamesMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Tipo = Convert.ToInt32(dataReader["tipo"]);
                            dado.Numero = Convert.ToInt32(dataReader["numero"]);
                            dado.Paciente = Convert.ToInt32(dataReader["paciente"]);
                            dado.Medico = Convert.ToInt32(dataReader["medico"]);
                            dado.Convenio = Convert.ToInt32(dataReader["convenio"]);
                            dado.Data_entrada = Convert.ToString(dataReader["data_entrada"]);
                            dado.Envio = Convert.ToInt32(dataReader["envio"]);
                            dado.Entrega = Convert.ToInt32(dataReader["entrega"]);
                            //Console.WriteLine(dado.NomeEspecialidade);
                            lista.Add(dado);
                        }
                    }
                    return lista;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //MÉTODO UTILIZADO PARA CONSULTAS COM INNER JOIN UTILIZANDO DATATABLE E DATAADAPTER
        public DataTable ListarExame()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    query.CommandText = "select e.id as ID, e.tipo as Tipo, e.numero as Num, e.paciente as IdPac, " +
                        "e.medico as IdMed, e.convenio as IdCon, e.data_entrada as DataEnt, " +
                        "t.sigla as Sigla, p.nome as Paci, m.nome as Medico, c.nome as Convenio from exames as e " +
                        "inner join tipo_exames as t on e.tipo = t.id " +
                        "inner join pacientes as p on e.paciente = p.id " +
                        "inner join medicos as m on e.medico = m.id " +
                        "inner join convenios as c on e.convenio = c.id; ";
                    query.Connection = con;
                    con.Open();
                    dataAdapter.SelectCommand = query;
                    dataAdapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable BuscarNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    query.CommandText = "select e.id as ID, e.tipo as Tipo, e.numero as Num, e.paciente as IdPac, " +
                        "e.medico as IdMed, e.convenio as IdCon, e.data_entrada as DataEnt, " +
                        "t.sigla as Sigla, p.nome as Paci, m.nome as Medico, c.nome as Convenio from exames as e " +
                        "inner join tipo_exames as t on e.tipo = t.id " +
                        "inner join pacientes as p on e.paciente = p.id " +
                        "inner join medicos as m on e.medico = m.id " +
                        "inner join convenios as c on e.convenio = c.id " +
                        "WHERE p.nome LIKE @nome ORDER BY p.nome ASC";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = nome + "%";
                    query.Connection = con;
                    con.Open();
                    dataAdapter.SelectCommand = query;
                    dataAdapter.Fill(dt);
                    return dt;
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable BuscarPeriodo(string data_inicio, string data_fim)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    query.CommandText = "select e.id as ID, e.tipo as Tipo, e.numero as Num, e.paciente as IdPac, " +
                        "e.medico as IdMed, e.convenio as IdCon, e.data_entrada as DataEnt, " +
                        "t.sigla as Sigla, p.nome as Paci, m.nome as Medico, c.nome as Convenio from exames as e " +
                        "inner join tipo_exames as t on e.tipo = t.id " +
                        "inner join pacientes as p on e.paciente = p.id " +
                        "inner join medicos as m on e.medico = m.id " +
                        "inner join convenios as c on e.convenio = c.id " +
                        "WHERE e.data_entrada BETWEEN @data_inicio AND @data_fim ORDER BY e.data_entrada ASC";
                    query.Parameters.Add("data_inicio", SqlDbType.VarChar).Value = data_inicio;
                    query.Parameters.Add("data_fim", SqlDbType.VarChar).Value = data_fim;
                    query.Connection = con;
                    con.Open();
                    dataAdapter.SelectCommand = query;
                    dataAdapter.Fill(dt);
                    return dt;
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
