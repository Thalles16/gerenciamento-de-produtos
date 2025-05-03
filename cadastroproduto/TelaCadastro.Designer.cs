namespace cadastroproduto
{
    partial class TelaCadastro
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtCadSenha = new TextBox();
            txtCadUsuario = new TextBox();
            txtCadEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mtxtCadCpf = new MaskedTextBox();
            btnCadastrar = new Button();
            txtCadNome = new TextBox();
            btnVoltar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCadSenha);
            groupBox1.Controls.Add(txtCadUsuario);
            groupBox1.Controls.Add(txtCadEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtxtCadCpf);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCadNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(123, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 100);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 10;
            label5.Text = "E-mail";
            // 
            // txtCadSenha
            // 
            txtCadSenha.Location = new Point(171, 234);
            txtCadSenha.MaxLength = 8;
            txtCadSenha.Name = "txtCadSenha";
            txtCadSenha.Size = new Size(150, 31);
            txtCadSenha.TabIndex = 9;
            // 
            // txtCadUsuario
            // 
            txtCadUsuario.Location = new Point(171, 187);
            txtCadUsuario.Name = "txtCadUsuario";
            txtCadUsuario.Size = new Size(150, 31);
            txtCadUsuario.TabIndex = 8;
            // 
            // txtCadEmail
            // 
            txtCadEmail.Location = new Point(171, 97);
            txtCadEmail.Name = "txtCadEmail";
            txtCadEmail.Size = new Size(290, 31);
            txtCadEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 193);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 6;
            label4.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 234);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // mtxtCadCpf
            // 
            mtxtCadCpf.Location = new Point(171, 144);
            mtxtCadCpf.Mask = "000.000.000-00";
            mtxtCadCpf.Name = "mtxtCadCpf";
            mtxtCadCpf.Size = new Size(117, 31);
            mtxtCadCpf.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(232, 283);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 34);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCadNome
            // 
            txtCadNome.Location = new Point(171, 53);
            txtCadNome.Name = "txtCadNome";
            txtCadNome.Size = new Size(290, 31);
            txtCadNome.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 404);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(groupBox1);
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastre-se";
            FormClosing += this.TelaCadastro_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnCadastrar;
        private TextBox txtCadNome;
        private MaskedTextBox mtxtCadCpf;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtCadSenha;
        private TextBox txtCadUsuario;
        private TextBox txtCadEmail;
        private Button btnVoltar;
    }
}