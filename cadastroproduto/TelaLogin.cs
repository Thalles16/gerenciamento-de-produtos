namespace cadastroproduto
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void llblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro FormCadastro = new TelaCadastro(this);
            FormCadastro.Show();
            this.Hide();
        }
    }
}
