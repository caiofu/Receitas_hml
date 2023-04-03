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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNomeReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIngredientes = new System.Windows.Forms.TextBox();
            this.btnAdicionarIngredientes = new System.Windows.Forms.Button();
            this.lstBoxIngredientes = new System.Windows.Forms.ListBox();
            this.btnRemoverIngrediente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverPreparo = new System.Windows.Forms.Button();
            this.lstBoxPreparo = new System.Windows.Forms.ListBox();
            this.btnAdicionarPreparo = new System.Windows.Forms.Button();
            this.txtBoxPreparo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbDificuldadeMensagem = new System.Windows.Forms.Label();
            this.tckBarDificuldade = new System.Windows.Forms.TrackBar();
            this.lbDificuldade = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdicionaFotoReceita = new System.Windows.Forms.Button();
            this.picBoxFotoReceita = new System.Windows.Forms.PictureBox();
            this.errorProviderValidaReceita = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckBarDificuldade)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoReceita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidaReceita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME DA RECEITA";
            // 
            // txtBoxNomeReceita
            // 
            this.txtBoxNomeReceita.Location = new System.Drawing.Point(157, 22);
            this.txtBoxNomeReceita.Name = "txtBoxNomeReceita";
            this.txtBoxNomeReceita.Size = new System.Drawing.Size(386, 23);
            this.txtBoxNomeReceita.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGREDIENTE";
            // 
            // txtBoxIngredientes
            // 
            this.txtBoxIngredientes.Location = new System.Drawing.Point(157, 21);
            this.txtBoxIngredientes.Name = "txtBoxIngredientes";
            this.txtBoxIngredientes.Size = new System.Drawing.Size(293, 23);
            this.txtBoxIngredientes.TabIndex = 3;
            // 
            // btnAdicionarIngredientes
            // 
            this.btnAdicionarIngredientes.Location = new System.Drawing.Point(456, 21);
            this.btnAdicionarIngredientes.Name = "btnAdicionarIngredientes";
            this.btnAdicionarIngredientes.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarIngredientes.TabIndex = 4;
            this.btnAdicionarIngredientes.Text = "+ Adicionar";
            this.btnAdicionarIngredientes.UseVisualStyleBackColor = true;
            this.btnAdicionarIngredientes.Click += new System.EventHandler(this.btnAdicionarIngredientes_Click);
            // 
            // lstBoxIngredientes
            // 
            this.lstBoxIngredientes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstBoxIngredientes.FormattingEnabled = true;
            this.lstBoxIngredientes.ItemHeight = 23;
            this.lstBoxIngredientes.Location = new System.Drawing.Point(157, 66);
            this.lstBoxIngredientes.Name = "lstBoxIngredientes";
            this.lstBoxIngredientes.Size = new System.Drawing.Size(293, 73);
            this.lstBoxIngredientes.TabIndex = 5;
            // 
            // btnRemoverIngrediente
            // 
            this.btnRemoverIngrediente.Location = new System.Drawing.Point(157, 145);
            this.btnRemoverIngrediente.Name = "btnRemoverIngrediente";
            this.btnRemoverIngrediente.Size = new System.Drawing.Size(154, 28);
            this.btnRemoverIngrediente.TabIndex = 6;
            this.btnRemoverIngrediente.Text = "- Remover Ingrediente";
            this.btnRemoverIngrediente.UseVisualStyleBackColor = true;
            this.btnRemoverIngrediente.Click += new System.EventHandler(this.btnRemoverIngrediente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxIngredientes);
            this.groupBox1.Controls.Add(this.btnRemoverIngrediente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxIngredientes);
            this.groupBox1.Controls.Add(this.btnAdicionarIngredientes);
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoverPreparo);
            this.groupBox2.Controls.Add(this.lstBoxPreparo);
            this.groupBox2.Controls.Add(this.btnAdicionarPreparo);
            this.groupBox2.Controls.Add(this.txtBoxPreparo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 175);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnRemoverPreparo
            // 
            this.btnRemoverPreparo.Location = new System.Drawing.Point(157, 140);
            this.btnRemoverPreparo.Name = "btnRemoverPreparo";
            this.btnRemoverPreparo.Size = new System.Drawing.Size(154, 28);
            this.btnRemoverPreparo.TabIndex = 7;
            this.btnRemoverPreparo.Text = "- Remover Ingrediente";
            this.btnRemoverPreparo.UseVisualStyleBackColor = true;
            this.btnRemoverPreparo.Click += new System.EventHandler(this.btnRemoverPreparo_Click);
            // 
            // lstBoxPreparo
            // 
            this.lstBoxPreparo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstBoxPreparo.FormattingEnabled = true;
            this.lstBoxPreparo.ItemHeight = 23;
            this.lstBoxPreparo.Location = new System.Drawing.Point(157, 61);
            this.lstBoxPreparo.Name = "lstBoxPreparo";
            this.lstBoxPreparo.Size = new System.Drawing.Size(293, 73);
            this.lstBoxPreparo.TabIndex = 7;
            // 
            // btnAdicionarPreparo
            // 
            this.btnAdicionarPreparo.Location = new System.Drawing.Point(456, 19);
            this.btnAdicionarPreparo.Name = "btnAdicionarPreparo";
            this.btnAdicionarPreparo.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarPreparo.TabIndex = 10;
            this.btnAdicionarPreparo.Text = "+ Adicionar";
            this.btnAdicionarPreparo.UseVisualStyleBackColor = true;
            this.btnAdicionarPreparo.Click += new System.EventHandler(this.btnAdicionarPreparo_Click);
            // 
            // txtBoxPreparo
            // 
            this.txtBoxPreparo.Location = new System.Drawing.Point(157, 19);
            this.txtBoxPreparo.Name = "txtBoxPreparo";
            this.txtBoxPreparo.Size = new System.Drawing.Size(293, 23);
            this.txtBoxPreparo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "MODO DE PREPARO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxNomeReceita);
            this.groupBox3.Location = new System.Drawing.Point(3, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 59);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarReceita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarReceita.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarReceita.Location = new System.Drawing.Point(397, 574);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(179, 50);
            this.btnAdicionarReceita.TabIndex = 10;
            this.btnAdicionarReceita.Text = "ADICIONAR RECEITA";
            this.btnAdicionarReceita.UseVisualStyleBackColor = false;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.btnAdicionarReceita_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnAdicionarReceita);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 629);
            this.panel1.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbDificuldadeMensagem);
            this.groupBox5.Controls.Add(this.tckBarDificuldade);
            this.groupBox5.Controls.Add(this.lbDificuldade);
            this.groupBox5.Location = new System.Drawing.Point(383, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 138);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // lbDificuldadeMensagem
            // 
            this.lbDificuldadeMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDificuldadeMensagem.AutoSize = true;
            this.lbDificuldadeMensagem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDificuldadeMensagem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbDificuldadeMensagem.Location = new System.Drawing.Point(49, 87);
            this.lbDificuldadeMensagem.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbDificuldadeMensagem.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDificuldadeMensagem.Name = "lbDificuldadeMensagem";
            this.lbDificuldadeMensagem.Size = new System.Drawing.Size(100, 25);
            this.lbDificuldadeMensagem.TabIndex = 4;
            this.lbDificuldadeMensagem.Text = "Fácil";
            this.lbDificuldadeMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tckBarDificuldade
            // 
            this.tckBarDificuldade.LargeChange = 1;
            this.tckBarDificuldade.Location = new System.Drawing.Point(47, 51);
            this.tckBarDificuldade.Maximum = 3;
            this.tckBarDificuldade.Minimum = 1;
            this.tckBarDificuldade.Name = "tckBarDificuldade";
            this.tckBarDificuldade.Size = new System.Drawing.Size(104, 45);
            this.tckBarDificuldade.TabIndex = 3;
            this.tckBarDificuldade.Value = 1;
            this.tckBarDificuldade.Scroll += new System.EventHandler(this.tckBarDificuldade_Scroll);
            // 
            // lbDificuldade
            // 
            this.lbDificuldade.AutoSize = true;
            this.lbDificuldade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDificuldade.Location = new System.Drawing.Point(44, 19);
            this.lbDificuldade.Name = "lbDificuldade";
            this.lbDificuldade.Size = new System.Drawing.Size(107, 20);
            this.lbDificuldade.TabIndex = 2;
            this.lbDificuldade.Text = "DIFICULDADE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdicionaFotoReceita);
            this.groupBox4.Controls.Add(this.picBoxFotoReceita);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 138);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnAdicionaFotoReceita
            // 
            this.btnAdicionaFotoReceita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdicionaFotoReceita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionaFotoReceita.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaFotoReceita.Location = new System.Drawing.Point(189, 46);
            this.btnAdicionaFotoReceita.Name = "btnAdicionaFotoReceita";
            this.btnAdicionaFotoReceita.Size = new System.Drawing.Size(179, 50);
            this.btnAdicionaFotoReceita.TabIndex = 12;
            this.btnAdicionaFotoReceita.Text = "ADICIONAR IMAGEM";
            this.btnAdicionaFotoReceita.UseVisualStyleBackColor = false;
            this.btnAdicionaFotoReceita.Click += new System.EventHandler(this.btnAdicionaFotoReceita_Click);
            // 
            // picBoxFotoReceita
            // 
            this.picBoxFotoReceita.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBoxFotoReceita.Location = new System.Drawing.Point(8, 13);
            this.picBoxFotoReceita.Name = "picBoxFotoReceita";
            this.picBoxFotoReceita.Size = new System.Drawing.Size(175, 116);
            this.picBoxFotoReceita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFotoReceita.TabIndex = 0;
            this.picBoxFotoReceita.TabStop = false;
            // 
            // errorProviderValidaReceita
            // 
            this.errorProviderValidaReceita.ContainerControl = this;
            // 
            // adicionarReceita
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 653);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adicionarReceita";
            this.Text = "Adicionar Receita";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckBarDificuldade)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoReceita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidaReceita)).EndInit();
            this.ResumeLayout(false);

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