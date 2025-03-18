namespace WFUsandoListagem
{
    public partial class FAutenticação : Form
    {
        public FAutenticação()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFormulario()
        {


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Erro("Campo usuário não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("Campo senha não pode estar Vazio!");
                return;
            }
            Usuarios TelaUsuario = new Usuarios();

            foreach (Usuarios user in Usuarios.ListaUsuarios)
            {
                if (user.Login == txtUsuario.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        FormMain form = new FormMain();
                        form.ShowDialog();
                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            

            Usuarios us = new Usuarios();
            {
                us.Codigo = 1;
                us.Login = "user";
                us.Senha = "123456";
                us.DataCadastro = Convert.ToDateTime("10/01/2025 18:30");

            }
            Usuarios.ListaUsuarios.Add(us);
        }
    }
}
