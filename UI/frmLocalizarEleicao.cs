using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmLocalizarEleicao : PadraoDeProjetoEmCamadas.FRMLocalizar
    {
        public MODELOEleicao modeloeleicao;
        public frmLocalizarEleicao()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao blleleicao = new BLLEleicao(cx);
            DataTable tabela = blleleicao.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }
        private void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloeleicao = new MODELOEleicao();

            this.modeloeleicao.Ideleicao = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloeleicao.Idempresa = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modeloeleicao.Nome = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloeleicao.Descricao = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeloeleicao.Tipovoto = DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modeloeleicao.Mensagemencerrado = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modeloeleicao.Mensagemfim = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime datai = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());
            this.modelpessoa.DataNascimento = datai;
            DateTime dataf = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[8].Value.ToString());
            this.modelpessoa.DataNascimento = dataf;


            this.Close();

        }



    }
}
