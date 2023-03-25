namespace Receitas_hml.Forms
{
	partial class adicionarReceita
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			txtBoxNomeReceita = new TextBox();
			label2 = new Label();
			txtBoxIngredientes = new TextBox();
			btnAdicionarIngredientes = new Button();
			lstBoxIngredientes = new ListBox();
			btnRemoverIngrediente = new Button();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnRemoverPreparo = new Button();
			lstBoxPreparo = new ListBox();
			btnAdicionarPreparo = new Button();
			txtBoxPreparo = new TextBox();
			label3 = new Label();
			groupBox3 = new GroupBox();
			btnAdicionarReceita = new Button();
			panel1 = new Panel();
			groupBox5 = new GroupBox();
			lbDificuldadeMensagem = new Label();
			tckBarDificuldade = new TrackBar();
			lbDificuldade = new Label();
			groupBox4 = new GroupBox();
			btnAdicionaFotoReceita = new Button();
			picBoxFotoReceita = new PictureBox();
			errorProviderValidaReceita = new ErrorProvider(components);
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			panel1.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tckBarDificuldade).BeginInit();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxFotoReceita).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProviderValidaReceita).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(8, 23);
			label1.Name = "label1";
			label1.Size = new Size(143, 20);
			label1.TabIndex = 0;
			label1.Text = "NOME DA RECEITA";
			// 
			// txtBoxNomeReceita
			// 
			txtBoxNomeReceita.Location = new Point(157, 22);
			txtBoxNomeReceita.Name = "txtBoxNomeReceita";
			txtBoxNomeReceita.Size = new Size(386, 23);
			txtBoxNomeReceita.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(34, 24);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 2;
			label2.Text = "INGREDIENTE";
			label2.Click += label2_Click;
			// 
			// txtBoxIngredientes
			// 
			txtBoxIngredientes.Location = new Point(157, 21);
			txtBoxIngredientes.Name = "txtBoxIngredientes";
			txtBoxIngredientes.Size = new Size(293, 23);
			txtBoxIngredientes.TabIndex = 3;
			// 
			// btnAdicionarIngredientes
			// 
			btnAdicionarIngredientes.Location = new Point(456, 21);
			btnAdicionarIngredientes.Name = "btnAdicionarIngredientes";
			btnAdicionarIngredientes.Size = new Size(87, 23);
			btnAdicionarIngredientes.TabIndex = 4;
			btnAdicionarIngredientes.Text = "+ Adicionar";
			btnAdicionarIngredientes.UseVisualStyleBackColor = true;
			btnAdicionarIngredientes.Click += btnAdicionarIngredientes_Click;
			// 
			// lstBoxIngredientes
			// 
			lstBoxIngredientes.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			lstBoxIngredientes.FormattingEnabled = true;
			lstBoxIngredientes.ItemHeight = 23;
			lstBoxIngredientes.Location = new Point(157, 66);
			lstBoxIngredientes.Name = "lstBoxIngredientes";
			lstBoxIngredientes.Size = new Size(293, 73);
			lstBoxIngredientes.TabIndex = 5;
			// 
			// btnRemoverIngrediente
			// 
			btnRemoverIngrediente.Location = new Point(157, 145);
			btnRemoverIngrediente.Name = "btnRemoverIngrediente";
			btnRemoverIngrediente.Size = new Size(154, 28);
			btnRemoverIngrediente.TabIndex = 6;
			btnRemoverIngrediente.Text = "- Remover Ingrediente";
			btnRemoverIngrediente.UseVisualStyleBackColor = true;
			btnRemoverIngrediente.Click += btnRemoverIngrediente_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lstBoxIngredientes);
			groupBox1.Controls.Add(btnRemoverIngrediente);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtBoxIngredientes);
			groupBox1.Controls.Add(btnAdicionarIngredientes);
			groupBox1.Location = new Point(3, 203);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(573, 184);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnRemoverPreparo);
			groupBox2.Controls.Add(lstBoxPreparo);
			groupBox2.Controls.Add(btnAdicionarPreparo);
			groupBox2.Controls.Add(txtBoxPreparo);
			groupBox2.Controls.Add(label3);
			groupBox2.Location = new Point(3, 393);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(573, 175);
			groupBox2.TabIndex = 8;
			groupBox2.TabStop = false;
			// 
			// btnRemoverPreparo
			// 
			btnRemoverPreparo.Location = new Point(157, 140);
			btnRemoverPreparo.Name = "btnRemoverPreparo";
			btnRemoverPreparo.Size = new Size(154, 28);
			btnRemoverPreparo.TabIndex = 7;
			btnRemoverPreparo.Text = "- Remover Ingrediente";
			btnRemoverPreparo.UseVisualStyleBackColor = true;
			// 
			// lstBoxPreparo
			// 
			lstBoxPreparo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			lstBoxPreparo.FormattingEnabled = true;
			lstBoxPreparo.ItemHeight = 23;
			lstBoxPreparo.Location = new Point(157, 61);
			lstBoxPreparo.Name = "lstBoxPreparo";
			lstBoxPreparo.Size = new Size(293, 73);
			lstBoxPreparo.TabIndex = 7;
			// 
			// btnAdicionarPreparo
			// 
			btnAdicionarPreparo.Location = new Point(456, 19);
			btnAdicionarPreparo.Name = "btnAdicionarPreparo";
			btnAdicionarPreparo.Size = new Size(87, 23);
			btnAdicionarPreparo.TabIndex = 10;
			btnAdicionarPreparo.Text = "+ Adicionar";
			btnAdicionarPreparo.UseVisualStyleBackColor = true;
			btnAdicionarPreparo.Click += btnAdicionarPreparo_Click;
			// 
			// txtBoxPreparo
			// 
			txtBoxPreparo.Location = new Point(157, 19);
			txtBoxPreparo.Name = "txtBoxPreparo";
			txtBoxPreparo.Size = new Size(293, 23);
			txtBoxPreparo.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(6, 19);
			label3.Name = "label3";
			label3.Size = new Size(150, 20);
			label3.TabIndex = 7;
			label3.Text = "MODO DE PREPARO";
			label3.Click += label3_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label1);
			groupBox3.Controls.Add(txtBoxNomeReceita);
			groupBox3.Location = new Point(3, 138);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(573, 59);
			groupBox3.TabIndex = 9;
			groupBox3.TabStop = false;
			// 
			// btnAdicionarReceita
			// 
			btnAdicionarReceita.BackColor = Color.FromArgb(0, 192, 192);
			btnAdicionarReceita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdicionarReceita.ForeColor = Color.White;
			btnAdicionarReceita.Location = new Point(397, 574);
			btnAdicionarReceita.Name = "btnAdicionarReceita";
			btnAdicionarReceita.Size = new Size(179, 50);
			btnAdicionarReceita.TabIndex = 10;
			btnAdicionarReceita.Text = "ADICIONAR RECEITA";
			btnAdicionarReceita.UseVisualStyleBackColor = false;
			btnAdicionarReceita.Click += btnAdicionarReceita_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(groupBox5);
			panel1.Controls.Add(groupBox4);
			panel1.Controls.Add(groupBox3);
			panel1.Controls.Add(btnAdicionarReceita);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(groupBox2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(593, 629);
			panel1.TabIndex = 11;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(lbDificuldadeMensagem);
			groupBox5.Controls.Add(tckBarDificuldade);
			groupBox5.Controls.Add(lbDificuldade);
			groupBox5.Location = new Point(383, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(193, 138);
			groupBox5.TabIndex = 13;
			groupBox5.TabStop = false;
			// 
			// lbDificuldadeMensagem
			// 
			lbDificuldadeMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbDificuldadeMensagem.AutoSize = true;
			lbDificuldadeMensagem.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbDificuldadeMensagem.ForeColor = Color.LimeGreen;
			lbDificuldadeMensagem.Location = new Point(49, 87);
			lbDificuldadeMensagem.MaximumSize = new Size(200, 0);
			lbDificuldadeMensagem.MinimumSize = new Size(100, 0);
			lbDificuldadeMensagem.Name = "lbDificuldadeMensagem";
			lbDificuldadeMensagem.Size = new Size(100, 25);
			lbDificuldadeMensagem.TabIndex = 4;
			lbDificuldadeMensagem.Text = "Fácil";
			lbDificuldadeMensagem.TextAlign = ContentAlignment.MiddleCenter;
			lbDificuldadeMensagem.Click += label4_Click;
			// 
			// tckBarDificuldade
			// 
			tckBarDificuldade.LargeChange = 1;
			tckBarDificuldade.Location = new Point(47, 51);
			tckBarDificuldade.Maximum = 3;
			tckBarDificuldade.Minimum = 1;
			tckBarDificuldade.Name = "tckBarDificuldade";
			tckBarDificuldade.Size = new Size(104, 45);
			tckBarDificuldade.TabIndex = 3;
			tckBarDificuldade.Value = 1;
			tckBarDificuldade.Scroll += tckBarDificuldade_Scroll;
			// 
			// lbDificuldade
			// 
			lbDificuldade.AutoSize = true;
			lbDificuldade.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			lbDificuldade.Location = new Point(44, 19);
			lbDificuldade.Name = "lbDificuldade";
			lbDificuldade.Size = new Size(107, 20);
			lbDificuldade.TabIndex = 2;
			lbDificuldade.Text = "DIFICULDADE";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(btnAdicionaFotoReceita);
			groupBox4.Controls.Add(picBoxFotoReceita);
			groupBox4.Location = new Point(3, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(374, 138);
			groupBox4.TabIndex = 11;
			groupBox4.TabStop = false;
			// 
			// btnAdicionaFotoReceita
			// 
			btnAdicionaFotoReceita.BackColor = Color.LightSeaGreen;
			btnAdicionaFotoReceita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdicionaFotoReceita.ForeColor = Color.White;
			btnAdicionaFotoReceita.Location = new Point(189, 46);
			btnAdicionaFotoReceita.Name = "btnAdicionaFotoReceita";
			btnAdicionaFotoReceita.Size = new Size(179, 50);
			btnAdicionaFotoReceita.TabIndex = 12;
			btnAdicionaFotoReceita.Text = "ADICIONAR IMAGEM";
			btnAdicionaFotoReceita.UseVisualStyleBackColor = false;
			btnAdicionaFotoReceita.Click += btnAdicionaFotoReceita_Click;
			// 
			// picBoxFotoReceita
			// 
			picBoxFotoReceita.BackColor = SystemColors.ActiveBorder;
			picBoxFotoReceita.Location = new Point(8, 13);
			picBoxFotoReceita.Name = "picBoxFotoReceita";
			picBoxFotoReceita.Size = new Size(175, 116);
			picBoxFotoReceita.SizeMode = PictureBoxSizeMode.Zoom;
			picBoxFotoReceita.TabIndex = 0;
			picBoxFotoReceita.TabStop = false;
			// 
			// errorProviderValidaReceita
			// 
			errorProviderValidaReceita.ContainerControl = this;
			// 
			// adicionarReceita
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(616, 653);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "adicionarReceita";
			Text = "Adicionar Receita";
			Load += adicionarReceita_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			panel1.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tckBarDificuldade).EndInit();
			groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picBoxFotoReceita).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProviderValidaReceita).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox txtBoxNomeReceita;
		private Label label2;
		private TextBox txtBoxIngredientes;
		private Button btnAdicionarIngredientes;
		private ListBox lstBoxIngredientes;
		private Button btnRemoverIngrediente;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Label label3;
		private Button btnRemoverPreparo;
		private ListBox lstBoxPreparo;
		private Button btnAdicionarPreparo;
		private TextBox txtBoxPreparo;
		private Button btnAdicionarReceita;
		private Panel panel1;
		private GroupBox groupBox4;
		private Button btnAdicionaFotoReceita;
		private PictureBox picBoxFotoReceita;
		private ErrorProvider errorProviderValidaReceita;
		private GroupBox groupBox5;
		private TrackBar tckBarDificuldade;
		private Label lbDificuldade;
		private Label lbDificuldadeMensagem;
	}
}