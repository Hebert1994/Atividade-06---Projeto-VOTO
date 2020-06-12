using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELO;
using System.Data;

namespace DAL
{
    public class DALEmpresa
    {
        private DALConexao conexao;


        public DALEmpresa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Empresa(IDEMPRESA, NOME, DESCRICAO, CODEMPRESA);" +
                    " VALUES (NULL, @Nome, @desc, @Cod);" +
                    "SELECT MAX(IDEmpresa) FROM;";
                cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
                cmd.Parameters.AddWithValue("@Cod", modelo.CodEmpresa);
                
               

                conexao.Conectar();
                int IDEmpresa = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IdEmpresa = IDEmpresa;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Alterar(MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Empresa SET Nome = @nome," +
                                  "Descricao = @desc," +
                                  "CodEmpresa = @Cod" +
                                  " WHERE " +
                                  "IDEmpresa = @idp";
                
                cmd.Parameters.AddWithValue("@idp", modelo.IdEmpresa);
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@Cod", modelo.CodEmpresa);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Empresa WHERE id = @idp";
                cmd.Parameters.AddWithValue("@idp", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM Empresa WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }

    }
}
