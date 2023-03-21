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
            this.gpBoxMenu = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpBoxReceitas = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpBoxMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpBoxReceitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxMenu
            // 
            this.gpBoxMenu.Controls.Add(this.panel1);
            this.gpBoxMenu.Controls.Add(this.button1);
            this.gpBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.gpBoxMenu.Name = "gpBoxMenu";
            this.gpBoxMenu.Size = new System.Drawing.Size(755, 62);
            this.gpBoxMenu.TabIndex = 0;
            this.gpBoxMenu.TabStop = false;
            this.gpBoxMenu.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(137, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 41);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "TODOS",
            "TÍTULO",
            "INGREDIENTES",
            "DIFICULDADE"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TODOS",
            "TITULO",
            "INGREDIENTE",
            "DIFICULDADE"});
            this.comboBox1.Location = new System.Drawing.Point(436, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar Receita";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gpBoxReceitas
            // 
            this.gpBoxReceitas.Controls.Add(this.flowLayoutPanel1);
            this.gpBoxReceitas.Location = new System.Drawing.Point(12, 84);
            this.gpBoxReceitas.Name = "gpBoxReceitas";
            this.gpBoxReceitas.Size = new System.Drawing.Size(755, 398);
            this.gpBoxReceitas.TabIndex = 1;
            this.gpBoxReceitas.TabStop = false;
            this.gpBoxReceitas.Text = "RECEITAS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 373);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.gpBoxReceitas);
            this.Controls.Add(this.gpBoxMenu);
            this.Name = "telaPrincipal";
            this.Text = "Receitas";
            this.gpBoxMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpBoxReceitas.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private GroupBox gpBoxMenu;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox gpBoxReceitas;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}