namespace Receitas_hml.Classes
{
    partial class CardReceita
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardReceita));
            this.pctBoxImagem = new System.Windows.Forms.PictureBox();
            this.lbNomeReceita = new System.Windows.Forms.Label();
            this.lbDificuldade = new System.Windows.Forms.Label();
            this.lbNivelDificuldade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxImagem
            // 
            this.pctBoxImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxImagem.Image")));
            this.pctBoxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctBoxImagem.Name = "pctBoxImagem";
            this.pctBoxImagem.Size = new System.Drawing.Size(162, 142);
            this.pctBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxImagem.TabIndex = 0;
            this.pctBoxImagem.TabStop = false;
            // 
            // lbNomeReceita
            // 
            this.lbNomeReceita.AutoSize = true;
            this.lbNomeReceita.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNomeReceita.Location = new System.Drawing.Point(196, 33);
            this.lbNomeReceita.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbNomeReceita.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbNomeReceita.Name = "lbNomeReceita";
            this.lbNomeReceita.Size = new System.Drawing.Size(200, 21);
            this.lbNomeReceita.TabIndex = 1;
            this.lbNomeReceita.Text = "Nome Receita";
            this.lbNomeReceita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDificuldade
            // 
            this.lbDificuldade.AutoSize = true;
            this.lbDificuldade.Location = new System.Drawing.Point(227, 89);
            this.lbDificuldade.Name = "lbDificuldade";
            this.lbDificuldade.Size = new System.Drawing.Size(70, 15);
            this.lbDificuldade.TabIndex = 2;
            this.lbDificuldade.Text = "Dificuldade:";
            // 
            // lbNivelDificuldade
            // 
            this.lbNivelDificuldade.AutoSize = true;
            this.lbNivelDificuldade.Location = new System.Drawing.Point(293, 89);
            this.lbNivelDificuldade.Name = "lbNivelDificuldade";
            this.lbNivelDificuldade.Size = new System.Drawing.Size(126, 15);
            this.lbNivelDificuldade.TabIndex = 3;
            this.lbNivelDificuldade.Text = "Fácil/Moderado/Difícil";
            // 
            // CardReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNivelDificuldade);
            this.Controls.Add(this.lbDificuldade);
            this.Controls.Add(this.lbNomeReceita);
            this.Controls.Add(this.pctBoxImagem);
            this.Name = "CardReceita";
            this.Size = new System.Drawing.Size(432, 142);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctBoxImagem;
        private Label lbNomeReceita;
        private Label lbDificuldade;
        private Label lbNivelDificuldade;
    }
}
