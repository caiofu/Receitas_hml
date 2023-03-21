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
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbNomeReceita.Location = new System.Drawing.Point(271, 38);
            this.lbNomeReceita.Name = "lbNomeReceita";
            this.lbNomeReceita.Size = new System.Drawing.Size(38, 15);
            this.lbNomeReceita.TabIndex = 1;
            this.lbNomeReceita.Text = "label1";
            this.lbNomeReceita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dificuldade:";
            // 
            // lbNivelDificuldade
            // 
            this.lbNivelDificuldade.AutoSize = true;
            this.lbNivelDificuldade.Location = new System.Drawing.Point(293, 89);
            this.lbNivelDificuldade.Name = "lbNivelDificuldade";
            this.lbNivelDificuldade.Size = new System.Drawing.Size(0, 15);
            this.lbNivelDificuldade.TabIndex = 3;
            // 
            // CardReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNivelDificuldade);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label lbNivelDificuldade;
    }
}
