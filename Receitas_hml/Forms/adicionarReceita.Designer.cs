﻿namespace Receitas_hml.Forms
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
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnRemoverPreparo = new Button();
			lstBoxPreparo = new ListBox();
			btnAdicionarPreparo = new Button();
			txtBoxPreparo = new TextBox();
			label3 = new Label();
			groupBox3 = new GroupBox();
			button1 = new Button();
			panel1 = new Panel();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			panel1.SuspendLayout();
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
			// textBox1
			// 
			textBox1.Location = new Point(157, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(386, 23);
			textBox1.TabIndex = 1;
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
			lstBoxIngredientes.Size = new Size(386, 96);
			lstBoxIngredientes.TabIndex = 5;
			// 
			// btnRemoverIngrediente
			// 
			btnRemoverIngrediente.Location = new Point(157, 168);
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
			groupBox1.Location = new Point(63, 150);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(573, 208);
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
			groupBox2.Location = new Point(63, 359);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(573, 205);
			groupBox2.TabIndex = 8;
			groupBox2.TabStop = false;
			// 
			// btnRemoverPreparo
			// 
			btnRemoverPreparo.Location = new Point(157, 163);
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
			lstBoxPreparo.Size = new Size(386, 96);
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
			groupBox3.Controls.Add(textBox1);
			groupBox3.Location = new Point(63, 85);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(573, 66);
			groupBox3.TabIndex = 9;
			groupBox3.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 192, 192);
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(457, 570);
			button1.Name = "button1";
			button1.Size = new Size(179, 50);
			button1.TabIndex = 10;
			button1.Text = "ADICIONAR RECEITA";
			button1.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			panel1.Controls.Add(groupBox3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(groupBox2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(696, 637);
			panel1.TabIndex = 11;
			// 
			// adicionarReceita
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(729, 661);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "adicionarReceita";
			Text = "adicionarReceita";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
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
		private Button button1;
		private Panel panel1;
	}
}