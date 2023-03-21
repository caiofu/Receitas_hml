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
			gpBoxMenu = new GroupBox();
			panel1 = new Panel();
			comboBox1 = new ComboBox();
			textBox1 = new TextBox();
			button2 = new Button();
			btnAdicionarReceita = new Button();
			gpBoxReceitas = new GroupBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			gpBoxMenu.SuspendLayout();
			panel1.SuspendLayout();
			gpBoxReceitas.SuspendLayout();
			SuspendLayout();
			// 
			// gpBoxMenu
			// 
			gpBoxMenu.Controls.Add(panel1);
			gpBoxMenu.Controls.Add(btnAdicionarReceita);
			gpBoxMenu.Location = new Point(12, 12);
			gpBoxMenu.Name = "gpBoxMenu";
			gpBoxMenu.Size = new Size(755, 62);
			gpBoxMenu.TabIndex = 0;
			gpBoxMenu.TabStop = false;
			gpBoxMenu.Text = "MENU";
			// 
			// panel1
			// 
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(button2);
			panel1.Location = new Point(137, 15);
			panel1.Name = "panel1";
			panel1.Size = new Size(612, 41);
			panel1.TabIndex = 3;
			// 
			// comboBox1
			// 
			comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "TODOS", "TÍTULO", "INGREDIENTES", "DIFICULDADE" });
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "TODOS", "TITULO", "INGREDIENTE", "DIFICULDADE" });
			comboBox1.Location = new Point(436, 9);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(163, 23);
			comboBox1.TabIndex = 3;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(132, 9);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(298, 23);
			textBox1.TabIndex = 2;
			// 
			// button2
			// 
			button2.Location = new Point(12, 7);
			button2.Name = "button2";
			button2.Size = new Size(115, 28);
			button2.TabIndex = 1;
			button2.Text = "Pesquisar";
			button2.UseVisualStyleBackColor = true;
			// 
			// btnAdicionarReceita
			// 
			btnAdicionarReceita.Location = new Point(20, 22);
			btnAdicionarReceita.Name = "btnAdicionarReceita";
			btnAdicionarReceita.Size = new Size(111, 28);
			btnAdicionarReceita.TabIndex = 0;
			btnAdicionarReceita.Text = "Adicionar Receita";
			btnAdicionarReceita.UseVisualStyleBackColor = true;
			btnAdicionarReceita.Click += btnAdicionarReceita_Click;
			// 
			// gpBoxReceitas
			// 
			gpBoxReceitas.Controls.Add(flowLayoutPanel1);
			gpBoxReceitas.Location = new Point(12, 84);
			gpBoxReceitas.Name = "gpBoxReceitas";
			gpBoxReceitas.Size = new Size(755, 398);
			gpBoxReceitas.TabIndex = 1;
			gpBoxReceitas.TabStop = false;
			gpBoxReceitas.Text = "RECEITAS";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(8, 19);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(742, 373);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// telaPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(781, 487);
			Controls.Add(gpBoxReceitas);
			Controls.Add(gpBoxMenu);
			Name = "telaPrincipal";
			Text = "Receitas";
			gpBoxMenu.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			gpBoxReceitas.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gpBoxMenu;
		private Button button2;
		private Button btnAdicionarReceita;
		private Panel panel1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private GroupBox gpBoxReceitas;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}