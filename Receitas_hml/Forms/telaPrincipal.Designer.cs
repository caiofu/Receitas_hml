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
            cboxFiltros = new ComboBox();
            txBoxPesquisaReceita = new TextBox();
            btnPesquisarReceita = new Button();
            btnAdicionarReceita = new Button();
            gpBoxReceitas = new GroupBox();
            flowLayoutPanelReceitas = new FlowLayoutPanel();
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
            gpBoxMenu.Size = new Size(635, 62);
            gpBoxMenu.TabIndex = 0;
            gpBoxMenu.TabStop = false;
            gpBoxMenu.Text = "MENU";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboxFiltros);
            panel1.Controls.Add(txBoxPesquisaReceita);
            panel1.Controls.Add(btnPesquisarReceita);
            panel1.Location = new Point(137, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 41);
            panel1.TabIndex = 3;
            // 
            // cboxFiltros
            // 
            cboxFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxFiltros.AutoCompleteCustomSource.AddRange(new string[] { "TODOS", "TÍTULO", "INGREDIENTES", "DIFICULDADE" });
            cboxFiltros.FormattingEnabled = true;
            cboxFiltros.Items.AddRange(new object[] { "TODOS", "TITULO", "INGREDIENTE", "DIFICULDADE" });
            cboxFiltros.Location = new Point(379, 9);
            cboxFiltros.Name = "cboxFiltros";
            cboxFiltros.Size = new Size(106, 23);
            cboxFiltros.TabIndex = 3;
            // 
            // txBoxPesquisaReceita
            // 
            txBoxPesquisaReceita.Location = new Point(132, 9);
            txBoxPesquisaReceita.Name = "txBoxPesquisaReceita";
            txBoxPesquisaReceita.Size = new Size(241, 23);
            txBoxPesquisaReceita.TabIndex = 2;
            // 
            // btnPesquisarReceita
            // 
            btnPesquisarReceita.Location = new Point(12, 7);
            btnPesquisarReceita.Name = "btnPesquisarReceita";
            btnPesquisarReceita.Size = new Size(115, 28);
            btnPesquisarReceita.TabIndex = 1;
            btnPesquisarReceita.Text = "Pesquisar";
            btnPesquisarReceita.UseVisualStyleBackColor = true;
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
            gpBoxReceitas.Controls.Add(flowLayoutPanelReceitas);
            gpBoxReceitas.Location = new Point(12, 84);
            gpBoxReceitas.Name = "gpBoxReceitas";
            gpBoxReceitas.Size = new Size(635, 398);
            gpBoxReceitas.TabIndex = 1;
            gpBoxReceitas.TabStop = false;
            gpBoxReceitas.Text = "RECEITAS";
            // 
            // flowLayoutPanelReceitas
            // 
            flowLayoutPanelReceitas.Location = new Point(8, 19);
            flowLayoutPanelReceitas.Name = "flowLayoutPanelReceitas";
            flowLayoutPanelReceitas.Size = new Size(617, 373);
            flowLayoutPanelReceitas.TabIndex = 0;
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 487);
            Controls.Add(gpBoxReceitas);
            Controls.Add(gpBoxMenu);
            Name = "telaPrincipal";
            Text = "Receitas";
            Load += telaPrincipal_Load;
            gpBoxMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpBoxReceitas.ResumeLayout(false);
            ResumeLayout(false);
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