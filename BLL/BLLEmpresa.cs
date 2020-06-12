using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLEmpresa
    {

        private DALEmpresa DALempresa;

        public BLLEmpresa(DALConexao cx)
        {
           DALempresa = new DALEmpresa(cx);
        }

        public void IncluirE(MODELOEmpresa modelo)
        {
            try
            {
               
                if (modelo.Nome == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.CodEmpresa == "")
                {
                    throw new ArgumentNullException("CNPJ", "Nao pode ser vazio.");
                }
                if (modelo.Descricao == "")
                {
                    throw new ArgumentNullException("Descricao", "Nao pode ser vazio.");
                }

                DALempresa.Incluir(modelo);

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

        public void Alterar(MODELOEmpresa modelo)
        {

            try
            {
                if (modelo.Nome == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.CodEmpresa == "")
                {
                    throw new ArgumentNullException("CNPJ", "Nao pode ser vazio.");
                }
                if (modelo.Descricao == "")
                {
                    throw new ArgumentNullException("Descricao", "Nao pode ser vazio.");
                }

                DALempresa.Alterar(modelo);
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

        public void ExcluirE(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALempresa.Excluir(codigo);

        }

        public DataTable LocalizarE(string texto)
        {
            return DALempresa.Localizar(texto);
        }

    }
}
