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
            pctBoxImagem = new PictureBox();
            lbNomeReceita = new Label();
            lbDificuldade = new Label();
            lbNivelDificuldade = new Label();
            ((System.ComponentModel.ISupportInitialize)pctBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // pctBoxImagem
            // 
            pctBoxImagem.Image = (Image)resources.GetObject("pctBoxImagem.Image");
            pctBoxImagem.Location = new Point(0, 0);
            pctBoxImagem.Name = "pctBoxImagem";
            pctBoxImagem.Size = new Size(162, 142);
            pctBoxImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pctBoxImagem.TabIndex = 0;
            pctBoxImagem.TabStop = false;
            // 
            // lbNomeReceita
            // 
            lbNomeReceita.AutoSize = true;
            lbNomeReceita.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeReceita.Location = new Point(284, 53);
            lbNomeReceita.MaximumSize = new Size(200, 0);
            lbNomeReceita.MinimumSize = new Size(200, 0);
            lbNomeReceita.Name = "lbNomeReceita";
            lbNomeReceita.Size = new Size(200, 21);
            lbNomeReceita.TabIndex = 1;
            lbNomeReceita.Text = "Nome Receita";
            lbNomeReceita.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDificuldade
            // 
            lbDificuldade.AutoSize = true;
            lbDificuldade.Location = new Point(292, 127);
            lbDificuldade.Name = "lbDificuldade";
            lbDificuldade.Size = new Size(70, 15);
            lbDificuldade.TabIndex = 2;
            lbDificuldade.Text = "Dificuldade:";
            // 
            // lbNivelDificuldade
            // 
            lbNivelDificuldade.AutoSize = true;
            lbNivelDificuldade.Location = new Point(358, 127);
            lbNivelDificuldade.Name = "lbNivelDificuldade";
            lbNivelDificuldade.Size = new Size(126, 15);
            lbNivelDificuldade.TabIndex = 3;
            lbNivelDificuldade.Text = "Fácil/Moderado/Difícil";
            // 
            // CardReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbNivelDificuldade);
            Controls.Add(lbDificuldade);
            Controls.Add(lbNomeReceita);
            Controls.Add(pctBoxImagem);
            Name = "CardReceita";
            Size = new Size(619, 200);
            ((System.ComponentModel.ISupportInitialize)pctBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctBoxImagem;
        private Label lbNomeReceita;
        private Label lbDificuldade;
        private Label lbNivelDificuldade;
    }
}
