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
    public partial class frmLocalizarEmpresa : PadraoDeProjetoEmCamadas.FRMLocalizar
    {
        public MODELOEmpresa modeloempresa;
        public frmLocalizarEmpresa()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEmpresa bLLEmpresa = new BLLEmpresa(cx);
            DataTable tabelae = bLLEmpresa.LocalizarE(TXTBusca.Text);
            DGVDados.DataSource = tabelae;
        }

        private void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloempresa = new MODELOEmpresa();
            this.modeloempresa.IdEmpresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloempresa.Nome = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modeloempresa.CodEmpresa = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloempresa.Descricao = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.Close();
        }
    }
}
