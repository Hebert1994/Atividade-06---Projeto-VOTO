using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleicao
    {
        private Int32 ideleicao;
        private string idempresa;
        private string nome;
        private string descricao;
        private string tipovoto;
        private string mensagemencerrado;
        private string mensagemfim;
        private DateTime datainicio;
        private DateTime datafim;

        public Int32 Ideleicao { get => ideleicao; set => ideleicao = value; }
        public string Idempresa { get => idempresa; set => idempresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipovoto { get => tipovoto; set => tipovoto = value; }
        public string Mensagemencerrado { get => mensagemencerrado; set => mensagemencerrado = value; }
        public string Mensagemfim { get => mensagemfim; set => mensagemfim = value; }
        public DateTime Datainicio { get => datainicio; set => datainicio = value; }
        public DateTime Datafim { get => datafim; set => datafim = value; }


    }
}
