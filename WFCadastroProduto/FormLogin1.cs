namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            txtUsuario.Clear();
            txtSenha.Clear();
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
                        LimparFormulario();
                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            LimparFormulario();
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
                us.Codigo = 001;
                us.Login = "admin";
                us.Senha = "123456";
                us.DataCadastro = Convert.ToDateTime("18/03/2025 18:30");

            }
            Usuarios.ListaUsuarios.Add(us);
        }
    }
}
