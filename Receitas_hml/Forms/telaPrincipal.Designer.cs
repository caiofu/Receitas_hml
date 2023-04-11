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
            gpBoxMenu.Location = new Point(14, 16);
            gpBoxMenu.Margin = new Padding(3, 4, 3, 4);
            gpBoxMenu.Name = "gpBoxMenu";
            gpBoxMenu.Padding = new Padding(3, 4, 3, 4);
            gpBoxMenu.Size = new Size(726, 83);
            gpBoxMenu.TabIndex = 0;
            gpBoxMenu.TabStop = false;
            gpBoxMenu.Text = "MENU";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboxFiltros);
            panel1.Controls.Add(txBoxPesquisaReceita);
            panel1.Controls.Add(btnPesquisarReceita);
            panel1.Location = new Point(157, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 55);
            panel1.TabIndex = 3;
            // 
            // cboxFiltros
            // 
            cboxFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxFiltros.AutoCompleteCustomSource.AddRange(new string[] { "TODOS", "TÍTULO", "INGREDIENTES", "DIFICULDADE" });
            cboxFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxFiltros.FormattingEnabled = true;
            cboxFiltros.Items.AddRange(new object[] { "TODOS", "TITULO", "INGREDIENTE", "DIFICULDADE" });
            cboxFiltros.Location = new Point(433, 12);
            cboxFiltros.Margin = new Padding(3, 4, 3, 4);
            cboxFiltros.Name = "cboxFiltros";
            cboxFiltros.Size = new Size(121, 28);
            cboxFiltros.TabIndex = 3;
            cboxFiltros.SelectedIndexChanged += cboxFiltros_SelectedIndexChanged;
            // 
            // txBoxPesquisaReceita
            // 
            txBoxPesquisaReceita.Location = new Point(151, 12);
            txBoxPesquisaReceita.Margin = new Padding(3, 4, 3, 4);
            txBoxPesquisaReceita.Name = "txBoxPesquisaReceita";
            txBoxPesquisaReceita.Size = new Size(275, 27);
            txBoxPesquisaReceita.TabIndex = 2;
            // 
            // btnPesquisarReceita
            // 
            btnPesquisarReceita.Location = new Point(14, 9);
            btnPesquisarReceita.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarReceita.Name = "btnPesquisarReceita";
            btnPesquisarReceita.Size = new Size(131, 37);
            btnPesquisarReceita.TabIndex = 1;
            btnPesquisarReceita.Text = "Pesquisar";
            btnPesquisarReceita.UseVisualStyleBackColor = true;
            btnPesquisarReceita.Click += btnPesquisarReceita_Click;
            // 
            // btnAdicionarReceita
            // 
            btnAdicionarReceita.Location = new Point(23, 29);
            btnAdicionarReceita.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarReceita.Name = "btnAdicionarReceita";
            btnAdicionarReceita.Size = new Size(127, 37);
            btnAdicionarReceita.TabIndex = 0;
            btnAdicionarReceita.Text = "Adicionar Receita";
            btnAdicionarReceita.UseVisualStyleBackColor = true;
            btnAdicionarReceita.Click += btnAdicionarReceita_Click;
            // 
            // gpBoxReceitas
            // 
            gpBoxReceitas.Controls.Add(flowLayoutPanelReceitas);
            gpBoxReceitas.Location = new Point(14, 107);
            gpBoxReceitas.Margin = new Padding(3, 4, 3, 4);
            gpBoxReceitas.Name = "gpBoxReceitas";
            gpBoxReceitas.Padding = new Padding(3, 4, 3, 4);
            gpBoxReceitas.Size = new Size(726, 531);
            gpBoxReceitas.TabIndex = 1;
            gpBoxReceitas.TabStop = false;
            gpBoxReceitas.Text = "RECEITAS";
            // 
            // flowLayoutPanelReceitas
            // 
            flowLayoutPanelReceitas.AutoScroll = true;
            flowLayoutPanelReceitas.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelReceitas.Location = new Point(9, 25);
            flowLayoutPanelReceitas.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelReceitas.Name = "flowLayoutPanelReceitas";
            flowLayoutPanelReceitas.Size = new Size(705, 497);
            flowLayoutPanelReceitas.TabIndex = 0;
            flowLayoutPanelReceitas.WrapContents = false;
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 649);
            Controls.Add(gpBoxReceitas);
            Controls.Add(gpBoxMenu);
            Margin = new Padding(3, 5, 3, 5);
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