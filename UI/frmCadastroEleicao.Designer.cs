namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEleicao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTIdEleicao = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLDtNascimento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNomeEleicao = new System.Windows.Forms.TextBox();
            this.TXTDescricaoEleicao = new System.Windows.Forms.RichTextBox();
            this.TXTMEncerramento = new System.Windows.Forms.RichTextBox();
            this.TXTMConclusao = new System.Windows.Forms.RichTextBox();
            this.DTEInicio = new System.Windows.Forms.DateTimePicker();
            this.DTETermino = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTCodEmpresa = new System.Windows.Forms.TextBox();
            this.CB_Voto = new System.Windows.Forms.ComboBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.CB_Voto);
            this.painel_campos.Controls.Add(this.TXTCodEmpresa);
            this.painel_campos.Controls.Add(this.label6);
            this.painel_campos.Controls.Add(this.DTETermino);
            this.painel_campos.Controls.Add(this.DTEInicio);
            this.painel_campos.Controls.Add(this.TXTMConclusao);
            this.painel_campos.Controls.Add(this.TXTMEncerramento);
            this.painel_campos.Controls.Add(this.TXTDescricaoEleicao);
            this.painel_campos.Controls.Add(this.TXTNomeEleicao);
            this.painel_campos.Controls.Add(this.label5);
            this.painel_campos.Controls.Add(this.LBLDtNascimento);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.Nome);
            this.painel_campos.Controls.Add(this.Codigo);
            this.painel_campos.Controls.Add(this.TXTIdEleicao);
            this.painel_campos.Size = new System.Drawing.Size(611, 442);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 460);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // TXTIdEleicao
            // 
            this.TXTIdEleicao.Enabled = false;
            this.TXTIdEleicao.Location = new System.Drawing.Point(158, 7);
            this.TXTIdEleicao.Name = "TXTIdEleicao";
            this.TXTIdEleicao.Size = new System.Drawing.Size(46, 20);
            this.TXTIdEleicao.TabIndex = 29;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(9, 10);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 30;
            this.Codigo.Text = "Codigo";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(9, 38);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(88, 13);
            this.Nome.TabIndex = 31;
            this.Nome.Text = "Nome da Eleição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Voto secreto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mensagem de Encerramneto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mensagem Conclusão";
            // 
            // LBLDtNascimento
            // 
            this.LBLDtNascimento.AutoSize = true;
            this.LBLDtNascimento.Location = new System.Drawing.Point(9, 382);
            this.LBLDtNascimento.Name = "LBLDtNascimento";
            this.LBLDtNascimento.Size = new System.Drawing.Size(58, 13);
            this.LBLDtNascimento.TabIndex = 36;
            this.LBLDtNascimento.Text = "Data Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Data Termino";
            // 
            // TXTNomeEleicao
            // 
            this.TXTNomeEleicao.Location = new System.Drawing.Point(158, 35);
            this.TXTNomeEleicao.Name = "TXTNomeEleicao";
            this.TXTNomeEleicao.Size = new System.Drawing.Size(297, 20);
            this.TXTNomeEleicao.TabIndex = 38;
            // 
            // TXTDescricaoEleicao
            // 
            this.TXTDescricaoEleicao.Location = new System.Drawing.Point(158, 58);
            this.TXTDescricaoEleicao.Name = "TXTDescricaoEleicao";
            this.TXTDescricaoEleicao.Size = new System.Drawing.Size(443, 74);
            this.TXTDescricaoEleicao.TabIndex = 39;
            this.TXTDescricaoEleicao.Text = "";
            // 
            // TXTMEncerramento
            // 
            this.TXTMEncerramento.Location = new System.Drawing.Point(158, 171);
            this.TXTMEncerramento.Name = "TXTMEncerramento";
            this.TXTMEncerramento.Size = new System.Drawing.Size(443, 88);
            this.TXTMEncerramento.TabIndex = 41;
            this.TXTMEncerramento.Text = "";
            // 
            // TXTMConclusao
            // 
            this.TXTMConclusao.Location = new System.Drawing.Point(158, 278);
            this.TXTMConclusao.Name = "TXTMConclusao";
            this.TXTMConclusao.Size = new System.Drawing.Size(443, 90);
            this.TXTMConclusao.TabIndex = 42;
            this.TXTMConclusao.Text = "";
            // 
            // DTEInicio
            // 
            this.DTEInicio.Location = new System.Drawing.Point(81, 376);
            this.DTEInicio.Name = "DTEInicio";
            this.DTEInicio.Size = new System.Drawing.Size(244, 20);
            this.DTEInicio.TabIndex = 43;
            // 
            // DTETermino
            // 
            this.DTETermino.Location = new System.Drawing.Point(81, 411);
            this.DTETermino.Name = "DTETermino";
            this.DTETermino.Size = new System.Drawing.Size(244, 20);
            this.DTETermino.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cod. Empresa";
            // 
            // TXTCodEmpresa
            // 
            this.TXTCodEmpresa.Location = new System.Drawing.Point(283, 7);
            this.TXTCodEmpresa.Name = "TXTCodEmpresa";
            this.TXTCodEmpresa.Size = new System.Drawing.Size(172, 20);
            this.TXTCodEmpresa.TabIndex = 46;
            // 
            // CB_Voto
            // 
            this.CB_Voto.FormattingEnabled = true;
            this.CB_Voto.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.CB_Voto.Location = new System.Drawing.Point(158, 138);
            this.CB_Voto.Name = "CB_Voto";
            this.CB_Voto.Size = new System.Drawing.Size(121, 21);
            this.CB_Voto.TabIndex = 47;
            // 
            // frmCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 526);
            this.Name = "frmCadastroEleicao";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox TXTIdEleicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.RichTextBox TXTDescricaoEleicao;
        private System.Windows.Forms.TextBox TXTNomeEleicao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLDtNascimento;
        private System.Windows.Forms.RichTextBox TXTMConclusao;
        private System.Windows.Forms.RichTextBox TXTMEncerramento;
        private System.Windows.Forms.DateTimePicker DTETermino;
        private System.Windows.Forms.DateTimePicker DTEInicio;
        private System.Windows.Forms.TextBox TXTCodEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_Voto;
    }
}
