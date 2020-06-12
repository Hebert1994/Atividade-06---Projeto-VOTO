namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTDescricao = new System.Windows.Forms.RichTextBox();
            this.TXTNomeEmpresa = new System.Windows.Forms.TextBox();
            this.TXTCODEmpresa = new System.Windows.Forms.TextBox();
            this.TXTIDEmpresa = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTIDEmpresa);
            this.painel_campos.Controls.Add(this.TXTCODEmpresa);
            this.painel_campos.Controls.Add(this.TXTNomeEmpresa);
            this.painel_campos.Controls.Add(this.TXTDescricao);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Size = new System.Drawing.Size(611, 200);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 218);
            this.Painel_botoes.Size = new System.Drawing.Size(611, 55);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CodEmpresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDEmpresa";
            // 
            // TXTDescricao
            // 
            this.TXTDescricao.Location = new System.Drawing.Point(70, 95);
            this.TXTDescricao.Name = "TXTDescricao";
            this.TXTDescricao.Size = new System.Drawing.Size(531, 88);
            this.TXTDescricao.TabIndex = 4;
            this.TXTDescricao.Text = "";
            // 
            // TXTNomeEmpresa
            // 
            this.TXTNomeEmpresa.Location = new System.Drawing.Point(70, 42);
            this.TXTNomeEmpresa.Name = "TXTNomeEmpresa";
            this.TXTNomeEmpresa.Size = new System.Drawing.Size(531, 20);
            this.TXTNomeEmpresa.TabIndex = 6;
            // 
            // TXTCODEmpresa
            // 
            this.TXTCODEmpresa.Location = new System.Drawing.Point(81, 68);
            this.TXTCODEmpresa.Name = "TXTCODEmpresa";
            this.TXTCODEmpresa.Size = new System.Drawing.Size(520, 20);
            this.TXTCODEmpresa.TabIndex = 7;
            // 
            // TXTIDEmpresa
            // 
            this.TXTIDEmpresa.Enabled = false;
            this.TXTIDEmpresa.Location = new System.Drawing.Point(70, 16);
            this.TXTIDEmpresa.Name = "TXTIDEmpresa";
            this.TXTIDEmpresa.Size = new System.Drawing.Size(46, 20);
            this.TXTIDEmpresa.TabIndex = 29;
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 285);
            this.Name = "frmCadastroEmpresa";
            this.Controls.SetChildIndex(this.painel_campos, 0);
            this.Controls.SetChildIndex(this.Painel_botoes, 0);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCODEmpresa;
        private System.Windows.Forms.TextBox TXTNomeEmpresa;
        private System.Windows.Forms.RichTextBox TXTDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIDEmpresa;
    }
}
