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
			lbDetalhesDificuldadeNumero = new Label();
			lbDetalhesDificuldade = new Label();
			lbDetalhesTituloReceita = new Label();
			imgReceita = new PictureBox();
			grpDetalhesReceitaCorpo = new GroupBox();
			listViewIngredientes = new ListView();
			listViewModoPreparo = new ListView();
			label1 = new Label();
			lbDetalhesIngredientes = new Label();
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
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldadeNumero);
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldade);
			grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesTituloReceita);
			grpDetalhesReceitaCabecalho.Controls.Add(imgReceita);
			grpDetalhesReceitaCabecalho.Location = new Point(4, 3);
			grpDetalhesReceitaCabecalho.Name = "grpDetalhesReceitaCabecalho";
			grpDetalhesReceitaCabecalho.Size = new Size(245, 601);
			grpDetalhesReceitaCabecalho.TabIndex = 0;
			grpDetalhesReceitaCabecalho.TabStop = false;
			// 
			// lbDetalhesDificuldadeNumero
			// 
			lbDetalhesDificuldadeNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbDetalhesDificuldadeNumero.AutoSize = true;
			lbDetalhesDificuldadeNumero.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
			lbDetalhesDificuldadeNumero.ForeColor = Color.FromArgb(255, 128, 0);
			lbDetalhesDificuldadeNumero.Location = new Point(28, 278);
			lbDetalhesDificuldadeNumero.MaximumSize = new Size(180, 0);
			lbDetalhesDificuldadeNumero.MinimumSize = new Size(180, 0);
			lbDetalhesDificuldadeNumero.Name = "lbDetalhesDificuldadeNumero";
			lbDetalhesDificuldadeNumero.Size = new Size(180, 36);
			lbDetalhesDificuldadeNumero.TabIndex = 3;
			lbDetalhesDificuldadeNumero.Text = "Moderado";
			lbDetalhesDificuldadeNumero.TextAlign = ContentAlignment.TopCenter;
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
			grpDetalhesReceitaCorpo.Controls.Add(listViewIngredientes);
			grpDetalhesReceitaCorpo.Controls.Add(listViewModoPreparo);
			grpDetalhesReceitaCorpo.Controls.Add(label1);
			grpDetalhesReceitaCorpo.Controls.Add(lbDetalhesIngredientes);
			grpDetalhesReceitaCorpo.Location = new Point(255, 3);
			grpDetalhesReceitaCorpo.Name = "grpDetalhesReceitaCorpo";
			grpDetalhesReceitaCorpo.Size = new Size(743, 601);
			grpDetalhesReceitaCorpo.TabIndex = 1;
			grpDetalhesReceitaCorpo.TabStop = false;
			grpDetalhesReceitaCorpo.Enter += grpDetalhesReceitaCorpo_Enter;
			// 
			// listViewIngredientes
			// 
			listViewIngredientes.Alignment = ListViewAlignment.Default;
			listViewIngredientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listViewIngredientes.Cursor = Cursors.IBeam;
			listViewIngredientes.Enabled = false;
			listViewIngredientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			listViewIngredientes.GridLines = true;
			listViewIngredientes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listViewIngredientes.HideSelection = true;
			listViewIngredientes.Location = new Point(91, 88);
			listViewIngredientes.MultiSelect = false;
			listViewIngredientes.Name = "listViewIngredientes";
			listViewIngredientes.Size = new Size(550, 187);
			listViewIngredientes.TabIndex = 4;
			listViewIngredientes.UseCompatibleStateImageBehavior = false;
			listViewIngredientes.View = View.List;
			// 
			// listViewModoPreparo
			// 
			listViewModoPreparo.Cursor = Cursors.IBeam;
			listViewModoPreparo.Enabled = false;
			listViewModoPreparo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			listViewModoPreparo.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listViewModoPreparo.HideSelection = true;
			listViewModoPreparo.Location = new Point(91, 335);
			listViewModoPreparo.MultiSelect = false;
			listViewModoPreparo.Name = "listViewModoPreparo";
			listViewModoPreparo.Size = new Size(550, 187);
			listViewModoPreparo.TabIndex = 3;
			listViewModoPreparo.UseCompatibleStateImageBehavior = false;
			listViewModoPreparo.View = View.List;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(255, 192, 192);
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(91, 278);
			label1.MaximumSize = new Size(550, 0);
			label1.MinimumSize = new Size(550, 0);
			label1.Name = "label1";
			label1.Size = new Size(550, 54);
			label1.TabIndex = 1;
			label1.Text = "Modo de Preparo";
			label1.TextAlign = ContentAlignment.MiddleCenter;
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
			// detalhesReceita
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1010, 616);
			Controls.Add(grpDetalhesReceitaCorpo);
			Controls.Add(grpDetalhesReceitaCabecalho);
			Margin = new Padding(3, 4, 3, 4);
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
		private ListView listViewModoPreparo;
		private ListView listViewIngredientes;
	}
}