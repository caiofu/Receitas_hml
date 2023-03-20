namespace Receitas_hml
{
	partial class telaPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			panel1 = new Panel();
			btnBuscarReceita = new Button();
			groupBox1 = new GroupBox();
			dataGridView1 = new DataGridView();
			nomeReceita = new DataGridViewTextBoxColumn();
			dificuldadeReceita = new DataGridViewTextBoxColumn();
			receitaAutor = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(3, 3);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(457, 33);
			textBox1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnBuscarReceita);
			panel1.Controls.Add(textBox1);
			panel1.Location = new Point(21, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(1015, 42);
			panel1.TabIndex = 1;
			// 
			// btnBuscarReceita
			// 
			btnBuscarReceita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnBuscarReceita.BackColor = SystemColors.Control;
			btnBuscarReceita.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnBuscarReceita.Location = new Point(496, 3);
			btnBuscarReceita.Name = "btnBuscarReceita";
			btnBuscarReceita.Padding = new Padding(5);
			btnBuscarReceita.Size = new Size(284, 34);
			btnBuscarReceita.TabIndex = 1;
			btnBuscarReceita.Text = "Buscar Receita";
			btnBuscarReceita.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dataGridView1);
			groupBox1.Location = new Point(21, 60);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1015, 462);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Receitas";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeReceita, dificuldadeReceita, receitaAutor });
			dataGridView1.Location = new Point(6, 22);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(994, 153);
			dataGridView1.TabIndex = 0;
			// 
			// nomeReceita
			// 
			nomeReceita.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			nomeReceita.HeaderText = "Receita";
			nomeReceita.Name = "nomeReceita";
			nomeReceita.ReadOnly = true;
			// 
			// dificuldadeReceita
			// 
			dificuldadeReceita.HeaderText = "Dificuldade";
			dificuldadeReceita.Name = "dificuldadeReceita";
			dificuldadeReceita.ReadOnly = true;
			// 
			// receitaAutor
			// 
			receitaAutor.HeaderText = "Autor";
			receitaAutor.Name = "receitaAutor";
			receitaAutor.ReadOnly = true;
			// 
			// telaPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1057, 564);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			Name = "telaPrincipal";
			Text = "Receitas";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox textBox1;
		private Panel panel1;
		private Button btnBuscarReceita;
		private GroupBox groupBox1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn nomeReceita;
		private DataGridViewTextBoxColumn dificuldadeReceita;
		private DataGridViewTextBoxColumn receitaAutor;
	}
}