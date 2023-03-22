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
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			txtBoxIngredientes = new TextBox();
			btnAdicionarIngredientes = new Button();
			lstBoxIngredientes = new ListBox();
			btnRemoverIngrediente = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(146, 32);
			label1.Name = "label1";
			label1.Size = new Size(143, 20);
			label1.TabIndex = 0;
			label1.Text = "NOME DA RECEITA";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(307, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(386, 23);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(181, 77);
			label2.Name = "label2";
			label2.Size = new Size(108, 20);
			label2.TabIndex = 2;
			label2.Text = "INGREDIENTE";
			label2.Click += label2_Click;
			// 
			// txtBoxIngredientes
			// 
			txtBoxIngredientes.Location = new Point(307, 78);
			txtBoxIngredientes.Name = "txtBoxIngredientes";
			txtBoxIngredientes.Size = new Size(293, 23);
			txtBoxIngredientes.TabIndex = 3;
			// 
			// btnAdicionarIngredientes
			// 
			btnAdicionarIngredientes.Location = new Point(606, 78);
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
			lstBoxIngredientes.Location = new Point(307, 120);
			lstBoxIngredientes.Name = "lstBoxIngredientes";
			lstBoxIngredientes.Size = new Size(386, 73);
			lstBoxIngredientes.TabIndex = 5;
			// 
			// btnRemoverIngrediente
			// 
			btnRemoverIngrediente.Location = new Point(307, 220);
			btnRemoverIngrediente.Name = "btnRemoverIngrediente";
			btnRemoverIngrediente.Size = new Size(154, 28);
			btnRemoverIngrediente.TabIndex = 6;
			btnRemoverIngrediente.Text = "- Remover Ingrediente";
			btnRemoverIngrediente.UseVisualStyleBackColor = true;
			btnRemoverIngrediente.Click += btnRemoverIngrediente_Click;
			// 
			// adicionarReceita
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 572);
			Controls.Add(btnRemoverIngrediente);
			Controls.Add(lstBoxIngredientes);
			Controls.Add(btnAdicionarIngredientes);
			Controls.Add(txtBoxIngredientes);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "adicionarReceita";
			Text = "adicionarReceita";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private TextBox txtBoxIngredientes;
		private Button btnAdicionarIngredientes;
		private ListBox lstBoxIngredientes;
		private Button btnRemoverIngrediente;
	}
}