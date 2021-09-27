using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protocolo.Model;

namespace Protocolo.Controller
{
    public class UsuariosCont
    {
        public int CadastrarUsuario(UsuariosMod obj)
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
                    query.CommandText = "INSERT INTO usuarios ([nome],[usuario],[senha],[nivel],[status]) VALUES (@nome, @usuario, @senha, @nivel, @status)";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                    query.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                    query.Parameters.Add("nivel", SqlDbType.VarChar).Value = obj.Nivel;
                    query.Parameters.Add("status", SqlDbType.VarChar).Value = obj.Status;
                    //VERIFICAR SE USUÁRIO JÁ EXISTE NO BANCO
                    SqlCommand queryVerifica = new SqlCommand();
                    queryVerifica.CommandType = CommandType.Text;
                    queryVerifica.CommandText = "SELECT * FROM usuarios WHERE usuario =@usuario";
                    queryVerifica.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
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
        public int EditarUsuario(UsuariosMod obj)
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
                    query.CommandText = "UPDATE usuarios SET nome =@nome, usuario =@usuario, senha =@senha, nivel =@nivel, status =@status WHERE id = @id";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                    query.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                    query.Parameters.Add("nivel", SqlDbType.VarChar).Value = obj.Nivel;
                    query.Parameters.Add("status", SqlDbType.VarChar).Value = obj.Status;
                    query.Parameters.Add("id", SqlDbType.Int).Value = Program.id;
                    //VERIFICAR SE USUÁRIO JÁ EXISTE NO BANCO
                    if (obj.Usuario != Program.usuarioAntigo)
                    {
                        SqlCommand queryVerifica = new SqlCommand();
                        queryVerifica.CommandType = CommandType.Text;
                        queryVerifica.CommandText = "SELECT * FROM usuarios WHERE usuario =@usuario";
                        queryVerifica.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
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
        public int DeletarUsuario(UsuariosMod obj)
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
                    query.CommandText = "DELETE FROM usuarios WHERE id = @id";
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
        public List<UsuariosMod> Listar()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM usuarios ORDER BY nome ASC";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<UsuariosMod> lista = new List<UsuariosMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            UsuariosMod dado = new UsuariosMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Nome = Convert.ToString(dataReader["nome"]);
                            dado.Usuario = Convert.ToString(dataReader["usuario"]);
                            dado.Senha = Convert.ToString(dataReader["senha"]);
                            dado.Nivel = Convert.ToString(dataReader["nivel"]);
                            dado.Status = Convert.ToString(dataReader["status"]);
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
        public UsuariosMod Logar(UsuariosMod obj)
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha AND status = @status";
                    query.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                    query.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                    query.Parameters.Add("status", SqlDbType.VarChar).Value = obj.Status;
                    query.Connection = con;

                    SqlDataReader dataReader;

                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //UsuariosMod dado = new UsuariosMod();
                            obj.Nome = Convert.ToString(dataReader["nome"]);
                            obj.Usuario = Convert.ToString(dataReader["usuario"]);
                            obj.Senha = Convert.ToString(dataReader["senha"]);
                            obj.Nivel = Convert.ToString(dataReader["nivel"]);
                            obj.Status = Convert.ToString(dataReader["status"]);
                        }
                    }
                    else
                    {
                        obj.Nome = null;
                        obj.Usuario = null;
                        obj.Senha = null;
                        obj.Nivel = null;
                        obj.Status = null;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
