using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarProduto form = new FormCadastrarProduto();
            form.ShowDialog();


        }

        
    }
}
