namespace Receitas_hml
{
    partial class detalhesReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detalhesReceita));
            grpDetalhesReceitaCabecalho = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            lbDetalhesDificuldadeNumero = new Label();
            lbDetalhesDificuldade = new Label();
            lbDetalhesTituloReceita = new Label();
            imgReceita = new PictureBox();
            grpDetalhesReceitaCorpo = new GroupBox();
            listView1 = new ListView();
            label1 = new Label();
            lbDetalhesIngredientes = new Label();
            grpDetalhesReceitaCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgReceita).BeginInit();
            grpDetalhesReceitaCorpo.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalhesReceitaCabecalho
            // 
            grpDetalhesReceitaCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpDetalhesReceitaCabecalho.BackColor = SystemColors.ButtonHighlight;
            grpDetalhesReceitaCabecalho.BackgroundImageLayout = ImageLayout.Center;
            grpDetalhesReceitaCabecalho.Controls.Add(label3);
            grpDetalhesReceitaCabecalho.Controls.Add(label2);
            grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldadeNumero);
            grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesDificuldade);
            grpDetalhesReceitaCabecalho.Controls.Add(lbDetalhesTituloReceita);
            grpDetalhesReceitaCabecalho.Controls.Add(imgReceita);
            grpDetalhesReceitaCabecalho.Location = new Point(5, 4);
            grpDetalhesReceitaCabecalho.Margin = new Padding(3, 4, 3, 4);
            grpDetalhesReceitaCabecalho.Name = "grpDetalhesReceitaCabecalho";
            grpDetalhesReceitaCabecalho.Padding = new Padding(3, 4, 3, 4);
            grpDetalhesReceitaCabecalho.Size = new Size(280, 705);
            grpDetalhesReceitaCabecalho.TabIndex = 0;
            grpDetalhesReceitaCabecalho.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(80, 543);
            label3.Name = "label3";
            label3.Size = new Size(124, 45);
            label3.TabIndex = 5;
            label3.Text = "15 Min";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 499);
            label2.MaximumSize = new Size(251, 0);
            label2.MinimumSize = new Size(251, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 27);
            label2.TabIndex = 4;
            label2.Text = "Tempo de Preparo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDetalhesDificuldadeNumero
            // 
            lbDetalhesDificuldadeNumero.AutoSize = true;
            lbDetalhesDificuldadeNumero.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetalhesDificuldadeNumero.ForeColor = Color.FromArgb(255, 128, 0);
            lbDetalhesDificuldadeNumero.Location = new Point(123, 384);
            lbDetalhesDificuldadeNumero.Name = "lbDetalhesDificuldadeNumero";
            lbDetalhesDificuldadeNumero.Size = new Size(38, 45);
            lbDetalhesDificuldadeNumero.TabIndex = 3;
            lbDetalhesDificuldadeNumero.Text = "5";
            // 
            // lbDetalhesDificuldade
            // 
            lbDetalhesDificuldade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbDetalhesDificuldade.AutoSize = true;
            lbDetalhesDificuldade.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetalhesDificuldade.Location = new Point(14, 339);
            lbDetalhesDificuldade.MaximumSize = new Size(251, 0);
            lbDetalhesDificuldade.MinimumSize = new Size(251, 0);
            lbDetalhesDificuldade.Name = "lbDetalhesDificuldade";
            lbDetalhesDificuldade.Size = new Size(251, 27);
            lbDetalhesDificuldade.TabIndex = 2;
            lbDetalhesDificuldade.Text = "Nivel de Dificudlade";
            lbDetalhesDificuldade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDetalhesTituloReceita
            // 
            lbDetalhesTituloReceita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbDetalhesTituloReceita.AutoSize = true;
            lbDetalhesTituloReceita.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetalhesTituloReceita.Location = new Point(15, 245);
            lbDetalhesTituloReceita.MaximumSize = new Size(251, 0);
            lbDetalhesTituloReceita.MinimumSize = new Size(251, 0);
            lbDetalhesTituloReceita.Name = "lbDetalhesTituloReceita";
            lbDetalhesTituloReceita.Size = new Size(251, 27);
            lbDetalhesTituloReceita.TabIndex = 1;
            lbDetalhesTituloReceita.Text = "Pudim de Padaria";
            lbDetalhesTituloReceita.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgReceita
            // 
            imgReceita.Image = (Image)resources.GetObject("imgReceita.Image");
            imgReceita.Location = new Point(9, 29);
            imgReceita.Margin = new Padding(3, 4, 3, 4);
            imgReceita.Name = "imgReceita";
            imgReceita.Size = new Size(257, 191);
            imgReceita.SizeMode = PictureBoxSizeMode.Zoom;
            imgReceita.TabIndex = 0;
            imgReceita.TabStop = false;
            // 
            // grpDetalhesReceitaCorpo
            // 
            grpDetalhesReceitaCorpo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDetalhesReceitaCorpo.Controls.Add(listView1);
            grpDetalhesReceitaCorpo.Controls.Add(label1);
            grpDetalhesReceitaCorpo.Controls.Add(lbDetalhesIngredientes);
            grpDetalhesReceitaCorpo.Location = new Point(291, 4);
            grpDetalhesReceitaCorpo.Margin = new Padding(3, 4, 3, 4);
            grpDetalhesReceitaCorpo.Name = "grpDetalhesReceitaCorpo";
            grpDetalhesReceitaCorpo.Padding = new Padding(3, 4, 3, 4);
            grpDetalhesReceitaCorpo.Size = new Size(849, 705);
            grpDetalhesReceitaCorpo.TabIndex = 1;
            grpDetalhesReceitaCorpo.TabStop = false;
            grpDetalhesReceitaCorpo.Enter += grpDetalhesReceitaCorpo_Enter;
            // 
            // listView1
            // 
            listView1.Cursor = Cursors.IBeam;
            listView1.Enabled = false;
            listView1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.HideSelection = true;
            listView1.Location = new Point(104, 117);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(628, 248);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 371);
            label1.MaximumSize = new Size(629, 0);
            label1.MinimumSize = new Size(629, 0);
            label1.Name = "label1";
            label1.Size = new Size(629, 67);
            label1.TabIndex = 1;
            label1.Text = "Modo de Preparo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDetalhesIngredientes
            // 
            lbDetalhesIngredientes.AutoSize = true;
            lbDetalhesIngredientes.BackColor = Color.FromArgb(255, 192, 192);
            lbDetalhesIngredientes.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbDetalhesIngredientes.Location = new Point(104, 41);
            lbDetalhesIngredientes.MaximumSize = new Size(629, 0);
            lbDetalhesIngredientes.MinimumSize = new Size(629, 0);
            lbDetalhesIngredientes.Name = "lbDetalhesIngredientes";
            lbDetalhesIngredientes.Size = new Size(629, 67);
            lbDetalhesIngredientes.TabIndex = 0;
            lbDetalhesIngredientes.Text = "Ingredientes";
            lbDetalhesIngredientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // detalhesReceita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 725);
            Controls.Add(grpDetalhesReceitaCorpo);
            Controls.Add(grpDetalhesReceitaCabecalho);
            Margin = new Padding(3, 5, 3, 5);
            Name = "detalhesReceita";
            Text = "Detalhes Receita";
            grpDetalhesReceitaCabecalho.ResumeLayout(false);
            grpDetalhesReceitaCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgReceita).EndInit();
            grpDetalhesReceitaCorpo.ResumeLayout(false);
            grpDetalhesReceitaCorpo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDetalhesReceitaCabecalho;
        private GroupBox grpDetalhesReceitaCorpo;
        private PictureBox imgReceita;
        private Label lbDetalhesTituloReceita;
        private Label lbDetalhesDificuldade;
        private Label lbDetalhesDificuldadeNumero;
        private Label lbDetalhesIngredientes;
        private Label label1;
        private Label label3;
        private Label label2;
        private ListView listView1;
    }
}