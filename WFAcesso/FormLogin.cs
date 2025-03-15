namespace WFAcesso
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


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
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
                us.Codigo = 001;
                us.Login = "admin";
                us.Senha = "admin";
                us.DataCadastro = Convert.ToDateTime("01/01/2000");
                Usuarios.ListaUsuarios.Add(us);
            }
            

            Usuarios us2 = new Usuarios();
            {
                us.Codigo = 002;
                us.Login = "user";
                us.Senha = "user";
                us.DataCadastro = Convert.ToDateTime("01/01/2010");

            }
            Usuarios.ListaUsuarios.Add(us);
        }
    }
}
