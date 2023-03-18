namespace Receitas_hml
{
	partial class detalhesReceita
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detalhesReceita));
			grpDetalhesReceitaCabecalho = new GroupBox();
			lbDetalhesTituloReceita = new Label();
			imgReceita = new PictureBox();
			grpDetalhesReceitaCorpo = new GroupBox();
			lbDetalhesDificuldade = new Label();
			lbDetalhesDificuldadeNumero = new Label();
			lbDetalhesIngredientes = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			grpDetalhesReceitaCabecalho.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)imgReceita).BeginInit();
			grpDetalhesReceitaCorpo.SuspendLayout();
			SuspendLayout();
			// 
			// grpDetalhesReceitaCabecalho
			// 
			grpDetalhesReceitaCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			grpDetalhesReceitaCabecalho.BackColor = SystemColors.ButtonHighlight;
			grpDetalhesReceitaCabecalho.BackgroundImageLayout = ImageLayout.Center;
			grpDetalhesReceitaCabecalho.Controls.Add(label3);
			grpDetalhesReceitaCabecalho.Controls.Add(label2);
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldadeNumero);
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldade);
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesTituloReceita);
			grpDetalhesReceitaCabecalho.Controls.Add(imgReceita);
			grpDetalhesReceitaCabecalho.Location = new Point(4, 3);
			grpDetalhesReceitaCabecalho.Name = "grpDetalhesReceitaCabecalho";
			grpDetalhesReceitaCabecalho.Size = new Size(245, 529);
			grpDetalhesReceitaCabecalho.TabIndex = 0;
			grpDetalhesReceitaCabecalho.TabStop = false;
			// 
			// lbDetalhesTituloReceita
			// 
			lbDetalhesTituloReceita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lbDetalhesTituloReceita.AutoSize = true;
			lbDetalhesTituloReceita.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbDetalhesTituloReceita.Location = new Point(13, 184);
			lbDetalhesTituloReceita.MaximumSize = new Size(220, 0);
			lbDetalhesTituloReceita.MinimumSize = new Size(220, 0);
			lbDetalhesTituloReceita.Name = "lbDetalhesTituloReceita";
			lbDetalhesTituloReceita.Size = new Size(220, 21);
			lbDetalhesTituloReceita.TabIndex = 1;
			lbDetalhesTituloReceita.Text = "Pudim de Padaria";
			lbDetalhesTituloReceita.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// imgReceita
			// 
			imgReceita.Image = (Image)resources.GetObject("imgReceita.Image");
			imgReceita.Location = new Point(8, 22);
			imgReceita.Name = "imgReceita";
			imgReceita.Size = new Size(225, 143);
			imgReceita.SizeMode = PictureBoxSizeMode.Zoom;
			imgReceita.TabIndex = 0;
			imgReceita.TabStop = false;
			// 
			// grpDetalhesReceitaCorpo
			// 
			grpDetalhesReceitaCorpo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			grpDetalhesReceitaCorpo.Controls.Add(label1);
			grpDetalhesReceitaCorpo.Controls.Add(lbDetalhesIngredientes);
			grpDetalhesReceitaCorpo.Location = new Point(255, 3);
			grpDetalhesReceitaCorpo.Name = "grpDetalhesReceitaCorpo";
			grpDetalhesReceitaCorpo.Size = new Size(743, 529);
			grpDetalhesReceitaCorpo.TabIndex = 1;
			grpDetalhesReceitaCorpo.TabStop = false;
			grpDetalhesReceitaCorpo.Enter += groupBox2_Enter;
			// 
			// lbDetalhesDificuldade
			// 
			lbDetalhesDificuldade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lbDetalhesDificuldade.AutoSize = true;
			lbDetalhesDificuldade.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			lbDetalhesDificuldade.Location = new Point(12, 254);
			lbDetalhesDificuldade.MaximumSize = new Size(220, 0);
			lbDetalhesDificuldade.MinimumSize = new Size(220, 0);
			lbDetalhesDificuldade.Name = "lbDetalhesDificuldade";
			lbDetalhesDificuldade.Size = new Size(220, 21);
			lbDetalhesDificuldade.TabIndex = 2;
			lbDetalhesDificuldade.Text = "Nivel de Dificudlade";
			lbDetalhesDificuldade.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbDetalhesDificuldadeNumero
			// 
			lbDetalhesDificuldadeNumero.AutoSize = true;
			lbDetalhesDificuldadeNumero.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
			lbDetalhesDificuldadeNumero.ForeColor = Color.FromArgb(255, 128, 0);
			lbDetalhesDificuldadeNumero.Location = new Point(108, 288);
			lbDetalhesDificuldadeNumero.Name = "lbDetalhesDificuldadeNumero";
			lbDetalhesDificuldadeNumero.Size = new Size(30, 36);
			lbDetalhesDificuldadeNumero.TabIndex = 3;
			lbDetalhesDificuldadeNumero.Text = "5";
			// 
			// lbDetalhesIngredientes
			// 
			lbDetalhesIngredientes.AutoSize = true;
			lbDetalhesIngredientes.BackColor = Color.FromArgb(255, 192, 192);
			lbDetalhesIngredientes.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
			lbDetalhesIngredientes.Location = new Point(91, 31);
			lbDetalhesIngredientes.MaximumSize = new Size(550, 0);
			lbDetalhesIngredientes.MinimumSize = new Size(550, 0);
			lbDetalhesIngredientes.Name = "lbDetalhesIngredientes";
			lbDetalhesIngredientes.Size = new Size(550, 54);
			lbDetalhesIngredientes.TabIndex = 0;
			lbDetalhesIngredientes.Text = "Ingredientes";
			lbDetalhesIngredientes.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(255, 192, 192);
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(91, 309);
			label1.MaximumSize = new Size(550, 0);
			label1.MinimumSize = new Size(550, 0);
			label1.Name = "label1";
			label1.Size = new Size(550, 54);
			label1.TabIndex = 1;
			label1.Text = "Modo de Preparo";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(13, 374);
			label2.MaximumSize = new Size(220, 0);
			label2.MinimumSize = new Size(220, 0);
			label2.Name = "label2";
			label2.Size = new Size(220, 21);
			label2.TabIndex = 4;
			label2.Text = "Tempo de Preparo";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(255, 128, 0);
			label3.Location = new Point(70, 407);
			label3.Name = "label3";
			label3.Size = new Size(100, 36);
			label3.TabIndex = 5;
			label3.Text = "15 Min";
			// 
			// detalhesReceita
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1010, 544);
			Controls.Add(grpDetalhesReceitaCorpo);
			Controls.Add(grpDetalhesReceitaCabecalho);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "detalhesReceita";
			Text = "Detalhes Receita";
			grpDetalhesReceitaCabecalho.ResumeLayout(false);
			grpDetalhesReceitaCabecalho.PerformLayout();
			((System.ComponentModel.ISupportInitialize)imgReceita).EndInit();
			grpDetalhesReceitaCorpo.ResumeLayout(false);
			grpDetalhesReceitaCorpo.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpDetalhesReceitaCabecalho;
		private GroupBox grpDetalhesReceitaCorpo;
		private PictureBox imgReceita;
		private Label lbDetalhesTituloReceita;
		private Label lbDetalhesDificuldade;
		private Label lbDetalhesDificuldadeNumero;
		private Label lbDetalhesIngredientes;
		private Label label1;
		private Label label3;
		private Label label2;
	}
}