using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEleicao : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {


        public frmCadastroEleicao(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Cadastro Eleicao";
        }


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }


        public void limparCampos()
        {
            TXTIdEleicao.Clear();
            TXTCodEmpresa.Clear();
            TXTNomeEleicao.Clear();
            TXTDescricaoEleicao.Clear();
            CB_Voto.SelectedItem = null;
            TXTMEncerramento.Clear();
            TXTMConclusao.Clear();
            DTEInicio.Text = "";
            DTETermino.Text = "";
        }



        private void Popularcampos(MODELOEleicao p)
        {
            if (p != null)
            {
                TXTIdEleicao.Text = Convert.ToString(p.Ideleicao);
                TXTCodEmpresa.Text = p.Idempresa;
                TXTNomeEleicao.Text = p.Nome;
                TXTDescricaoEleicao.Text = p.Descricao;
                switch (p.Tipovoto)
                {
                    case "S":
                        CB_Voto.SelectedItem = "Sim";
                        break;
                    case "N":
                        CB_Voto.SelectedItem = "Nao";
                        break;
                }
                TXTMEncerramento.Text = p.Mensagemencerrado;
                TXTMConclusao.Text = p.Mensagemfim;
                DTEInicio.Text = Convert.ToString(p.Datainicio);
                DTETermino.Text = Convert.ToString(p.Datafim);
            }
        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frmLocalizarEleicao f = new frmLocalizarEleicao();
            f.ShowDialog();


            Popularcampos(f.modeloeleicao);

            alterapropriedades(3);


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Idempresa = TXTCodEmpresa.Text;
                p.Nome = TXTNomeEleicao.Text;
                p.Descricao = TXTDescricaoEleicao.Text;

                switch (CB_Voto.SelectedItem.ToString())
                {
                    case "Sim":
                        p.Tipovoto = "S";
                        break;
                    case "Nao":
                        p.Tipovoto = "N";
                        break;
                }
                p.Mensagemencerrado = TXTMEncerramento.Text;
                p.Mensagemfim = TXTMConclusao.Text;
                p.Datainicio = new DateTime(DTEInicio.Value.Year,
                    DTEInicio.Value.Month,
                    DTEInicio.Value.Day);
                p.Datafim = new DateTime(DTETermino.Value.Year,
                    DTETermino.Value.Month,
                    DTETermino.Value.Day);

                blleleicao.Incluir(p);
                TXTIdEleicao.Text = p.Ideleicao.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Ideleicao);

                limparCampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir erro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }

        }



        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {

                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Idempresa = TXTCodEmpresa.Text;
                p.Nome = TXTNomeEleicao.Text;
                p.Descricao = TXTDescricaoEleicao.Text;

                switch (CB_Voto.SelectedItem.ToString())
                {
                    case "Sim":
                        p.Tipovoto = "S";
                        break;
                    case "Nao":
                        p.Tipovoto = "N";
                        break;
                }
                p.Mensagemencerrado = TXTMEncerramento.Text;
                p.Mensagemfim = TXTMConclusao.Text;
                p.Datainicio = new DateTime(DTEInicio.Value.Year,
                    DTEInicio.Value.Month,
                    DTEInicio.Value.Day);
                p.Datafim = new DateTime(DTETermino.Value.Year,
                    DTETermino.Value.Month,
                    DTETermino.Value.Day);

                blleleicao.Alterar(p);
                TXTIdEleicao.Text = p.Ideleicao.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Ideleicao);

                limparCampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                blleleicao.Excluir(Convert.ToInt32(TXTIdEleicao.Text));
                MessageBox.Show("Usuario excluido com sucesso.");

                limparCampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }

    }
}


