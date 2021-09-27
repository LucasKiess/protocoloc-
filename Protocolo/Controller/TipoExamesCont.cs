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
    public class TipoExamesCont
    {
        public int CadastrarTipoExame(TiposMod obj)
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
                    query.CommandText = "INSERT INTO tipo_exames ([sigla],[descricao]) VALUES (@sigla, @descricao)";
                    query.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
                    query.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                    //VERIFICAR SE TIPO EXAME JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM tipo_exames WHERE sigla =@sigla";
                    queryVerifica.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
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
        public int EditarTipoExame(TiposMod obj)
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
                    query.CommandText = "UPDATE tipo_exames SET sigla =@sigla, descricao =@descricao WHERE id = @id";
                    query.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
                    query.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    //VERIFICAR SE TIPO EXAME JÁ EXISTE NO BANCO
                    if (obj.Sigla != Program.tipoAntigo)
                    {
                        SqlCommand queryVerifica = new SqlCommand();
                        queryVerifica.CommandType = CommandType.Text;
                        queryVerifica.CommandText = "SELECT * FROM tipo_exames WHERE sigla =@sigla";
                        queryVerifica.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
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
        public int DeletarTipoExame(TiposMod obj)
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
                    query.CommandText = "DELETE FROM tipo_exames WHERE id = @id";
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
        public DataTable CarregarComboBox()
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
                    query.CommandText = "select * from tipo_exames";
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
        public DataTable CarregarComboBoxSigla(string sigla)
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
                    query.CommandText = "select * from tipo_exames WHERE sigla =@sigla";
                    query.Parameters.Add("sigla", SqlDbType.VarChar).Value = sigla;
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
        public List<TiposMod> ListarTipoExame()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM tipo_exames ORDER BY sigla ASC";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<TiposMod> lista = new List<TiposMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            TiposMod dado = new TiposMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Sigla = Convert.ToString(dataReader["sigla"]);
                            dado.Descricao = Convert.ToString(dataReader["descricao"]);
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
    }
}
