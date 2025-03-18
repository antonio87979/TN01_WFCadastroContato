using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
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
            txtSenha.Clear();

            txtConfirmarSenha.Clear();

            txtLogin.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            

            //Verifica Login
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                Erro("Campo Login não pode estar Vazio!");
                return;
            }
            //Verifica Senha
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("Campo Senha não pode estar Vazio!");
                return;
            }
            //Verifica Confirmar senha
            else if (string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                Erro("Confirme a senha!");
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Erro("As senhas devem ser iguais");
                return;
            }

            Usuarios us = new Usuarios();
            {
                us.Codigo = Usuarios.ListaUsuarios.Count + 1;
                us.Login = txtLogin.Text;
                us.Senha = txtSenha.Text;
                us.DataCadastro = DateTime.Now;
            }

            Usuarios.ListaUsuarios.Add(us);

            Sucesso("Cadastrado com Sucesso!");



            LimparFormulario();
        }

       
    }
}
