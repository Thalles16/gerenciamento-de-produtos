namespace gerenciamento_de_produtos
{
    partial class TelaProdutos
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
            datagridProdutos = new DataGridView();
            this.txtPreco = new TextBox();
            this.txtNome = new TextBox();
            txtQuantidade = new TextBox();
            lblNome = new Label();
            lblPreco = new Label();
            lblQuantidade = new Label();
            label4 = new Label();
            cbCategoria = new ComboBox();
            txtPesquisa = new TextBox();
            lblProdutos = new Label();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridProdutos).BeginInit();
            SuspendLayout();
            // 
            // datagridProdutos
            // 
            datagridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridProdutos.Location = new Point(0, 49);
            datagridProdutos.Name = "datagridProdutos";
            datagridProdutos.RowHeadersWidth = 62;
            datagridProdutos.Size = new Size(903, 261);
            datagridProdutos.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new Point(27, 448);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new Size(150, 31);
            this.txtPreco.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new Point(27, 353);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(150, 31);
            this.txtNome.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(268, 353);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(150, 31);
            txtQuantidade.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 325);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(27, 403);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(56, 25);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(268, 325);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(105, 25);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 403);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 8;
            label4.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(268, 448);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(150, 33);
            cbCategoria.TabIndex = 9;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(689, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(214, 31);
            txtPesquisa.TabIndex = 10;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Location = new Point(27, 12);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(85, 25);
            lblProdutos.TabIndex = 11;
            lblProdutos.Text = "Produtos";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(578, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(63, 25);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar";
            // 
            // TelaProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 516);
            Controls.Add(lblBuscar);
            Controls.Add(lblProdutos);
            Controls.Add(txtPesquisa);
            Controls.Add(cbCategoria);
            Controls.Add(label4);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(txtQuantidade);
            Controls.Add(this.txtNome);
            Controls.Add(this.txtPreco);
            Controls.Add(datagridProdutos);
            Name = "TelaProdutos";
            Text = "TelaProdutos";
            ((System.ComponentModel.ISupportInitialize)datagridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridProdutos;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtQuantidade;
        private Label lblNome;
        private Label lblPreco;
        private Label lblQuantidade;
        private Label label4;
        private ComboBox cbCategoria;
        private TextBox txtPesquisa;
        private Label lblProdutos;
        private Label lblBuscar;
    }
}