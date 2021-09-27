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
    public class PacientesCont
    {
        public int CadastrarPaciente(PacientesMod obj)
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
                    query.CommandText = "INSERT INTO pacientes ([nome],[idade],[telefone]) VALUES (@nome, @idade, @telefone)";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("idade", SqlDbType.Int).Value = obj.Idade;
                    query.Parameters.Add("@telefone", SqlDbType.VarChar).Value = obj.Telefone;
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
        public int EditarPaciente(PacientesMod obj)
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
                    query.CommandText = "UPDATE pacientes SET nome =@nome, idade =@idade, telefone =@telefone WHERE id = @id";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                    query.Parameters.Add("idade", SqlDbType.Int).Value = obj.Idade;
                    query.Parameters.Add("@telefone", SqlDbType.VarChar).Value = obj.Telefone;
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
        public int DeletarPaciente(PacientesMod obj)
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
                    query.CommandText = "DELETE FROM pacientes WHERE id = @id";
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
        public List<PacientesMod> Listar()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = Properties.Settings.Default.banco;
                    SqlCommand query = new SqlCommand();
                    query.CommandType = CommandType.Text;
                    con.Open();
                    query.CommandText = "SELECT * FROM pacientes ORDER BY nome ASC";
                    query.Connection = con;

                    SqlDataReader dataReader;
                    List<PacientesMod> lista = new List<PacientesMod>();
                    dataReader = query.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            PacientesMod dado = new PacientesMod();
                            dado.Id = Convert.ToInt32(dataReader["id"]);
                            dado.Nome = Convert.ToString(dataReader["nome"]);
                            dado.Idade = Convert.ToInt32(dataReader["idade"]);
                            dado.Telefone = Convert.ToString(dataReader["telefone"]);
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
                    query.CommandText = "SELECT * FROM pacientes ORDER BY nome ASC";
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
                    query.CommandText = "SELECT * FROM pacientes WHERE nome LIKE @nome ORDER BY nome ASC";
                    query.Parameters.Add("nome", SqlDbType.VarChar).Value = nome+"%";
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
