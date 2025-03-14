using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormListagem : Form
    {
        public FormListagem()
        {
            InitializeComponent();
        }

        private void dgvListaContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaContatos.DataSource = ClassContato.ListaContatos;
        }
    }
}
