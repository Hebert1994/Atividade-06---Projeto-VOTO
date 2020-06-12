using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEleicao
    {
        private DALEleicao DALeleicao;

        public BLLEleicao(DALConexao cx)
        {
            DALeleicao = new DALEleicao(cx);
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {

                if (modelo.Idempresa == "")
                {

                    throw new ArgumentNullException("Codigo", "O campo Codigo não pode estar vazio");
                }

                bool CaracterIndevido = Regex.IsMatch(modelo.Nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (CaracterIndevido == true)
                {
                    throw new ArgumentNullException("Nome", "Nome não pode conter caractéres especiais");
                }
                if (modelo.Nome == "")
                {

                    throw new ArgumentNullException("Nome", "O Campo Nome não pode estar vazio");
                }

                if (modelo.Mensagemencerrado == "")
                {

                    throw new ArgumentNullException("Mensagem de encerrar", "O Campo Mensagem encerrar não pode estar vazio");
                }

                if (modelo.Mensagemfim == "")
                {

                    throw new ArgumentNullException("Mensagem fim", "O Campo Mensagem fim não pode estar vazio");
                }

                if (Convert.ToString(modelo.Datainicio) == "")
                {

                    throw new ArgumentNullException("Data inicio", "O Campo Data Inicio não pode estar vazio");
                }
                if (modelo.Datafim <= modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data inicio", "A Data de fim não pode ser menor ou igual a data de inicio ");
                }

                if (Convert.ToString(modelo.Datafim) == "")
                {

                    throw new ArgumentNullException("Data fim", "O Campo Data fim não pode estar vazio");
                }
                if (modelo.Datafim < modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data fim", "A Data de inicio não pode ser maior que a data de fim ");
                }

                
                DALeleicao.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                if (modelo.Idempresa == "")
                {

                    throw new ArgumentNullException("Codigo", "O campo  não pode estar vazio");
                }

                bool CaracterIndevido = Regex.IsMatch(modelo.Nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (CaracterIndevido == true)
                {
                    throw new ArgumentNullException("Nome", "Nome não pode conter caractéres especiais");
                }
                if (modelo.Nome == "")
                {

                    throw new ArgumentNullException("Nome", "O Campo Nome não pode estar vazio");
                }

                if (modelo.Mensagemencerrado == "")
                {

                    throw new ArgumentNullException("Mensagem de encerrar", "O Campo Mensagem encerrar não pode estar vazio");
                }

                if (modelo.Mensagemfim == "")
                {

                    throw new ArgumentNullException("Mensagem fim", "O Campo Mensagem fim não pode estar vazio");
                }

                if (Convert.ToString(modelo.Datainicio) == "")
                {

                    throw new ArgumentNullException("Data inicio", "O Campo Data Inicio não pode estar vazio");
                }
                if (modelo.Datafim <= modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data inicio", "A Data de fim não pode ser menor ou igual a data de inicio ");
                }

                if (Convert.ToString(modelo.Datafim) == "")
                {

                    throw new ArgumentNullException("Data fim", "O Campo Data fim não pode estar vazio");
                }
                if (modelo.Datafim < modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data fim", "A Data de inicio não pode ser maior que a data de fim ");
                }


                DALeleicao.Alterar(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALeleicao.Excluir(codigo);


        }

        public DataTable Localizar(string texto)
        {
            return DALeleicao.Localizar(texto);
        }
    }




}

