namespace gerenciamento_de_produtos
{
    partial class formCadastro
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblCpf = new Label();
            lblNome = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(42, 225);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(230, 31);
            txtSenha.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(42, 177);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(93, 38);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ImageAlign = ContentAlignment.MiddleRight;
            lblEmail.Location = new Point(42, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 32);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 31);
            textBox2.TabIndex = 10;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(381, 177);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(64, 38);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ImageAlign = ContentAlignment.MiddleRight;
            lblNome.Location = new Point(381, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(89, 32);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(381, 327);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 34);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // formCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Name = "formCadastro";
            Text = "formCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblCpf;
        private Label lblNome;
        private Button btnCadastrar;
    }
}