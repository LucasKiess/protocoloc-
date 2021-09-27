using Protocolo.Model;
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
    public class MedicosCont
    {
        public int CadastrarMedico(MedicosMod obj)
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
                    query.CommandText = "INSERT INTO medicos ([nome],[crm],[especialidade],[data_cadastro]) VALUES (@nome,@crm,@especialidade, @data_cadastro)";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("crm", SqlDbType.Int).Value = obj.Crm;
                    query.Parameters.Add("especialidade", SqlDbType.Int).Value = obj.Especialidade;
                    query.Parameters.Add("data_cadastro", SqlDbType.DateTime).Value = obj.Data_cadastro;
                    //VERIFICAR SE CRM JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM medicos WHERE crm =@crm";
                    queryVerifica.Parameters.Add("crm", SqlDbType.Int).Value = obj.Crm;
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
                return retorno = -1;
            }
        }

        public int EditarMedico(MedicosMod obj)
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
                    query.CommandText = "UPDATE medicos SET nome =@nome, especialidade =@especialidade WHERE id = @id";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("especialidade", SqlDbType.Int).Value = obj.Especialidade;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    //VERIFICAR SE CRM JÁ EXISTE NO BANCO
                    if (obj.Crm != Program.crmAntigo)
                    {
                        SqlCommand queryVerifica = new SqlCommand();
                        queryVerifica.CommandType = CommandType.Text;
                        queryVerifica.CommandText = "SELECT * FROM medicos WHERE crm =@crm";
                        queryVerifica.Parameters.Add("crm", SqlDbType.Int).Value = obj.Crm;
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
                    }
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

        public int DeletarMedico(MedicosMod obj)
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
                    query.CommandText = "DELETE FROM medicos WHERE id = @id";
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

        public List<MedicosMod> Listar()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "select * from vw_medicos";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<MedicosMod> lista = new List<MedicosMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            MedicosMod dado = new MedicosMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Nome = Convert.ToString(dataReader["nome"]);
                            dado.Crm = Convert.ToInt32(dataReader["crm"]);
                            dado.Especialidade = Convert.ToInt32(dataReader["especialidade"]);
                            dado.NomeEspecialidade = Convert.ToString(dataReader["nomeEsp"]);
                            dado.Data_cadastro = Convert.ToString(dataReader["data_cadastro"]);
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
        public DataTable ListarMedico()
        {
            try
            {
                DataTable dt = new DataTable();
                using(SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    query.CommandText = "select * from vw_medicos";
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
        public DataTable BuscarMedicoCrm(int crm)
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
                    query.CommandText = "select * from medicos where crm =@crm";
                    query.Parameters.Add("crm", SqlDbType.Int).Value = crm;
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
    }
}
