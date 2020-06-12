using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEmpresa
    {
        private Int32 idEmpresa;
        private string nome;
        private string descricao;
        private string codEmpresa;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string CodEmpresa { get => codEmpresa; set => codEmpresa = value; }
    }
}
