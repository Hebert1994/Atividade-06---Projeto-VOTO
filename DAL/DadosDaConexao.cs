using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "fdb20.agilityhoster.com";
        private string port = "3306";
        private string user = "3471518_projeto";
        private string pass = "f8JH1E]TW";
        private string database = "3471518_projeto";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id= " + this.user + ";" +
                       "Password=" + this.pass + ";" +
                       "database= " + this.database + ";";
            }
        }

    }
}
