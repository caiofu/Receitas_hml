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
            lbDefault = new Label();
            ((System.ComponentModel.ISupportInitialize)pctBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // pctBoxImagem
            // 
            pctBoxImagem.Image = (Image)resources.GetObject("pctBoxImagem.Image");
            pctBoxImagem.Location = new Point(3, 3);
            pctBoxImagem.Name = "pctBoxImagem";
            pctBoxImagem.Size = new Size(176, 172);
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
            // lbDefault
            // 
            lbDefault.Anchor = AnchorStyles.None;
            lbDefault.AutoSize = true;
            lbDefault.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDefault.Location = new Point(111, 21);
            lbDefault.Name = "lbDefault";
            lbDefault.Padding = new Padding(0, 50, 0, 0);
            lbDefault.RightToLeft = RightToLeft.No;
            lbDefault.Size = new Size(0, 97);
            lbDefault.TabIndex = 4;
            lbDefault.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardReceita
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lbDefault);
            Controls.Add(lbNivelDificuldade);
            Controls.Add(lbDificuldade);
            Controls.Add(lbNomeReceita);
            Controls.Add(pctBoxImagem);
            Location = new Point(100, 0);
            Name = "CardReceita";
            Size = new Size(610, 181);
            Click += ReceitaEscolhida_Click;
            ((System.ComponentModel.ISupportInitialize)pctBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctBoxImagem;
        private Label lbNomeReceita;
        private Label lbDificuldade;
        private Label lbNivelDificuldade;
        private Label lbDefault;
    }
}
