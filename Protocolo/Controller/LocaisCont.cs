using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Model;
using System.Data.SqlClient;
using System.Data;

namespace Protocolo.Controller
{
    public class LocaisCont
    {
        public int CadastrarLocal(LocaisMod obj)
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
                    query.CommandText = "INSERT INTO locais ([nome],[data_cadastro]) VALUES (@nome, @data_cadastro)";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("@data_cadastro", SqlDbType.VarChar).Value = obj.Data_cadastro;
                    //VERIFICAR SE LOCAL JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM locais WHERE nome =@nome";
                    queryVerifica.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
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
            catch (Exception)
            {
                return retorno = -1;
            }
            
        }
        public int EditarLocal(LocaisMod obj)
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
                    query.CommandText = "UPDATE locais SET nome =@nome WHERE id = @id";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    //VERIFICAR SE LOCAL JÁ EXISTE NO BANCO
                    if (obj.Nome != Program.localAntigo)
                    {
                        SqlCommand queryVerifica = new SqlCommand();
                        queryVerifica.CommandType = CommandType.Text;
                        queryVerifica.CommandText = "SELECT * FROM locais WHERE nome =@nome";
                        queryVerifica.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
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
        public int DeletarLocal(LocaisMod obj)
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
                    query.CommandText = "DELETE FROM locais WHERE id = @id";
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
        public List<LocaisMod> Listar()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM locais ORDER BY nome ASC";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<LocaisMod> lista = new List<LocaisMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            LocaisMod dado = new LocaisMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Nome = Convert.ToString(dataReader["nome"]);
                            dado.Data_cadastro = Convert.ToString(dataReader["data_cadastro"]);
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
        public DataTable ListarPerso()
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
                    query.CommandText = "SELECT * FROM locais ORDER BY nome ASC";
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
