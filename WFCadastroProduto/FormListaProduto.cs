﻿using System;
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
    public partial class FormListaProduto : Form
    {
        public FormListaProduto()
        {
            InitializeComponent();
        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            dgvListagem.DataSource = Produto.ListaProdutos;
        }
    }
}
