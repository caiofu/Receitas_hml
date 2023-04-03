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
            this.cboxFiltros = new System.Windows.Forms.ComboBox();
            this.txBoxPesquisaReceita = new System.Windows.Forms.TextBox();
            this.btnPesquisarReceita = new System.Windows.Forms.Button();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.gpBoxReceitas = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelReceitas = new System.Windows.Forms.FlowLayoutPanel();
            this.gpBoxMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpBoxReceitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxMenu
            // 
            this.gpBoxMenu.Controls.Add(this.panel1);
            this.gpBoxMenu.Controls.Add(this.btnAdicionarReceita);
            this.gpBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.gpBoxMenu.Name = "gpBoxMenu";
            this.gpBoxMenu.Size = new System.Drawing.Size(635, 62);
            this.gpBoxMenu.TabIndex = 0;
            this.gpBoxMenu.TabStop = false;
            this.gpBoxMenu.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxFiltros);
            this.panel1.Controls.Add(this.txBoxPesquisaReceita);
            this.panel1.Controls.Add(this.btnPesquisarReceita);
            this.panel1.Location = new System.Drawing.Point(137, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 41);
            this.panel1.TabIndex = 3;
            // 
            // cboxFiltros
            // 
            this.cboxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxFiltros.AutoCompleteCustomSource.AddRange(new string[] {
            "TODOS",
            "TÍTULO",
            "INGREDIENTES",
            "DIFICULDADE"});
            this.cboxFiltros.FormattingEnabled = true;
            this.cboxFiltros.Items.AddRange(new object[] {
            "TODOS",
            "TITULO",
            "INGREDIENTE",
            "DIFICULDADE"});
            this.cboxFiltros.Location = new System.Drawing.Point(379, 9);
            this.cboxFiltros.Name = "cboxFiltros";
            this.cboxFiltros.Size = new System.Drawing.Size(106, 23);
            this.cboxFiltros.TabIndex = 3;
            // 
            // txBoxPesquisaReceita
            // 
            this.txBoxPesquisaReceita.Location = new System.Drawing.Point(132, 9);
            this.txBoxPesquisaReceita.Name = "txBoxPesquisaReceita";
            this.txBoxPesquisaReceita.Size = new System.Drawing.Size(241, 23);
            this.txBoxPesquisaReceita.TabIndex = 2;
            // 
            // btnPesquisarReceita
            // 
            this.btnPesquisarReceita.Location = new System.Drawing.Point(12, 7);
            this.btnPesquisarReceita.Name = "btnPesquisarReceita";
            this.btnPesquisarReceita.Size = new System.Drawing.Size(115, 28);
            this.btnPesquisarReceita.TabIndex = 1;
            this.btnPesquisarReceita.Text = "Pesquisar";
            this.btnPesquisarReceita.UseVisualStyleBackColor = true;
            this.btnPesquisarReceita.Click += new System.EventHandler(this.btnPesquisarReceita_Click);
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.Location = new System.Drawing.Point(20, 22);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(111, 28);
            this.btnAdicionarReceita.TabIndex = 0;
            this.btnAdicionarReceita.Text = "Adicionar Receita";
            this.btnAdicionarReceita.UseVisualStyleBackColor = true;
            // 
            // gpBoxReceitas
            // 
            this.gpBoxReceitas.Controls.Add(this.flowLayoutPanelReceitas);
            this.gpBoxReceitas.Location = new System.Drawing.Point(12, 80);
            this.gpBoxReceitas.Name = "gpBoxReceitas";
            this.gpBoxReceitas.Size = new System.Drawing.Size(635, 398);
            this.gpBoxReceitas.TabIndex = 1;
            this.gpBoxReceitas.TabStop = false;
            this.gpBoxReceitas.Text = "RECEITAS";
            // 
            // flowLayoutPanelReceitas
            // 
            this.flowLayoutPanelReceitas.AutoScroll = true;
            this.flowLayoutPanelReceitas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelReceitas.Location = new System.Drawing.Point(8, 19);
            this.flowLayoutPanelReceitas.Name = "flowLayoutPanelReceitas";
            this.flowLayoutPanelReceitas.Size = new System.Drawing.Size(617, 373);
            this.flowLayoutPanelReceitas.TabIndex = 0;
            this.flowLayoutPanelReceitas.WrapContents = false;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 487);
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
        private Button btnPesquisarReceita;
        private Button btnAdicionarReceita;
        private Panel panel1;
        private ComboBox cboxFiltros;
        private TextBox txBoxPesquisaReceita;
        private GroupBox gpBoxReceitas;
        private FlowLayoutPanel flowLayoutPanelReceitas;
    }
}