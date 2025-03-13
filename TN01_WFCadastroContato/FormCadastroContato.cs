namespace TN01_WFCadastroContato
{
    public partial class FormCadastroContato : Form
    {
        public FormCadastroContato()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();

            txtSobreNome.Clear();

            mkdTelefone.Clear();

            rdbComercial.Checked = false;

            rdbPessoal.Checked = false;

            rdbRecado.Checked = false;

            txtEmail.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobreNome.Text;
            string telefone = mkdTelefone.Text;
            string tipotelefone = "";
            string email = txtEmail.Text;

            if (rdbPessoal.Checked)
            {
                tipotelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                tipotelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                tipotelefone = "Recado";
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi definido!");
                return;
            }

            if (mkdTelefone.Text == "" || txtEmail.Text == "" || txtSobreNome.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos",
                    "erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                MessageBox.Show("Cadastro realizado com sucesso",
                    "info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LimparFormulario();

        }

       

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbPessoal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
