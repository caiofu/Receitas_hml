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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(181, 30);
			label1.Name = "label1";
			label1.Size = new Size(143, 20);
			label1.TabIndex = 0;
			label1.Text = "NOME DA RECEITA";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(341, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(386, 23);
			textBox1.TabIndex = 1;
			// 
			// adicionarReceita
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "adicionarReceita";
			Text = "adicionarReceita";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
	}
}