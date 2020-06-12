using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEleicao
    {
        private DALConexao conexao;

        public DALEleicao(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleicao (IDELEICAO, IDEMPRESA, NOME, DESCRICAO, TIPOVOTO, MENSAGEMENCERRADO, MENSAGEMFIM, DATAINICIO, DATAFIM)" +
                    "VALUES (NULL,@idempresa, @nome, @desc, @tipovoto, @msgcerrado, @msgfim,@datainicio,@datafim);" +
                    "SELECT MAX(IDELEICAO) FROM Eleicao;";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@idempresa", modelo.Idempresa);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
                cmd.Parameters.AddWithValue("@tipovoto", modelo.Tipovoto);
                cmd.Parameters.AddWithValue("@msgcerrado", modelo.Mensagemencerrado);
                cmd.Parameters.AddWithValue("@msgfim", modelo.Mensagemfim);
                cmd.Parameters.AddWithValue("@datainicio", modelo.Datainicio.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@datafim", modelo.Datafim.ToString("yyyy-MM-dd HH:mm:ss"));

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.Ideleicao = idInserido;
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

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = " UPDATE Eleicao SET IDEMPRESA = @idempresa," +
                                  " NOME = @nome," +
                                  " DESCRICAO = @desc," +
                                  " TIPOVOTO = @tipovoto," +
                                  " MENSAGEMENCERRADO = @msgcerrado," +
                                  " MENSAGEMFIM = @msgfim," +
                                  " DATAINICIO = @datainicio," +
                                  " DATAFIM = @datafim" +
                                  " WHERE " +
                                  " IDELEICAO = @id";

                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@idempresa", modelo.Idempresa);
                cmd.Parameters.AddWithValue("@id", modelo.Ideleicao);
                cmd.Parameters.AddWithValue("@desc", modelo.Descricao);
                cmd.Parameters.AddWithValue("@tipovoto", modelo.Tipovoto);
                cmd.Parameters.AddWithValue("@msgcerrado", modelo.Mensagemencerrado);
                cmd.Parameters.AddWithValue("@msgfim", modelo.Mensagemfim);
                cmd.Parameters.AddWithValue("@datainicio", modelo.Datainicio);
                cmd.Parameters.AddWithValue("@datafim", modelo.Datafim);

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

                cmd.CommandText = "DELETE FROM Eleicao WHERE IDELEICAO = @id";
                cmd.Parameters.AddWithValue("@id", codigo);
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
            string SQL = "SELECT * FROM Eleicao WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }







}

