namespace PadraoDeProjetoEmCamadas
{
    partial class frmLocalizarEmpresa
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
            this.SuspendLayout();
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // frmLocalizarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Name = "frmLocalizarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
