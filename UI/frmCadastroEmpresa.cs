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
    public partial class frmCadastroEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        public frmCadastroEmpresa(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Cadastro empresa";
        }

        public void LimparCampos()
        {
            TXTIDEmpresa.Clear();
            TXTNomeEmpresa.Clear();
            TXTCODEmpresa.Clear();
            TXTDescricao.Clear();
        }

        public void PopularCampos(MODELOEmpresa em)
        {
            if (em != null)
            {
                TXTNomeEmpresa.Text = em.Nome;
                TXTCODEmpresa.Text = em.CodEmpresa;
                TXTDescricao.Text = em.Descricao;
                TXTIDEmpresa.Text = em.IdEmpresa.ToString();

            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
            LimparCampos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frmLocalizarEmpresa f = new frmLocalizarEmpresa ();
            f.ShowDialog();


            PopularCampos(f.modeloempresa);

            alterapropriedades(3);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllEmpresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                // p.Nome = TXTNome.Text;
                p.Nome = TXTNomeEmpresa.Text;
                p.CodEmpresa = TXTCODEmpresa.Text;
                p.Descricao = TXTDescricao.Text;

                bllEmpresa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

                LimparCampos();
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
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.ExcluirE(Convert.ToInt32(TXTIDEmpresa));
                MessageBox.Show("Usuario excluido com sucesso.");

                LimparCampos();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            alterapropriedades(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.Nome = TXTNomeEmpresa.Text;
                p.CodEmpresa = TXTCODEmpresa.Text;
                p.Descricao = TXTDescricao.Text;

                bllempresa.IncluirE(p);
                TXTIDEmpresa.Text = p.IdEmpresa.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.IdEmpresa);

                LimparCampos();
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
    }
}
