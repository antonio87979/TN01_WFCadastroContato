using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WFCadastroProduto
{
    public partial class FormCadastrarProduto : Form
    {
        public FormCadastrarProduto()
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
            txtCodigo.Clear();
            


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verifica 
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo Código não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Erro("Campo categoria não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("Campo nome do produto não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(nudPreco.Text))
            {
                Erro("Campo preço não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(dtpDataV.Text))
            {
                Erro("Campo data de vencimento não pode estar Vazio!");
                return;
            }
            //Verifica 
            else if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                Erro("Campo Observação não pode estar Vazio!");
                return;
            }

            foreach (Produto pr in Produto.ListaProdutos)
            {
                if (txtCodigo.Text == pr.Codigo.ToString())
                {
                    {
                        Erro("Código já cadastrado!");
                        txtCodigo.Clear();
                        return;
                    }
                }
            }
            
            
                Sucesso("Produto cadastrado com sucesso!");
            

            Produto prod = new Produto();
            {
                prod.Codigo = Convert.ToInt32(txtCodigo.Text);
                prod.Nome = txtNomeProduto.Text;
                prod.Categoria = cbxCategoria.Text;
                prod.Preco = (double)nudPreco.Value;
                prod.DataVencimento = dtpDataV.Text;
                prod.Observacao = txtObservacao.Text;

                
                    Produto.ListaProdutos.Add(prod);

                    LimparFormulario();
                


            }
        }
    }
}
