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
    public class TipoGenericosCont
    {
        public int CadastrarTipoGenerico(TiposMod obj)
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
                    query.CommandText = "INSERT INTO tipo_genericos ([sigla],[descricao]) VALUES (@sigla, @descricao)";
                    query.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
                    query.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                    //VERIFICAR SE TIPO GENÉRICO JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM tipo_genericos WHERE sigla =@sigla";
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
        public int EditarTipoGenerico(TiposMod obj)
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
                    query.CommandText = "UPDATE tipo_genericos SET sigla =@sigla, descricao =@descricao WHERE id = @id";
                    query.Parameters.Add("sigla", SqlDbType.VarChar).Value = obj.Sigla;
                    query.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    //VERIFICAR SE TIPO GENERICO JÁ EXISTE NO BANCO
                    if (obj.Sigla != Program.tipoAntigo)
                    {
                        SqlCommand queryVerifica = new SqlCommand();
                        queryVerifica.CommandType = CommandType.Text;
                        queryVerifica.CommandText = "SELECT * FROM tipo_genericos WHERE sigla =@sigla";
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
        public int DeletarTipoGenerico(TiposMod obj)
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
                    query.CommandText = "DELETE FROM tipo_genericos WHERE id = @id";
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
        public List<TiposMod> ListarTipoGenerico()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM tipo_genericos ORDER BY sigla ASC";
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
