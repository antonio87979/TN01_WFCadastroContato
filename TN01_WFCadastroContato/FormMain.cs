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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void mnsCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroContato form = new FormCadastroContato();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsListagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void CarregarLista()
        {

            Contato.ListaContatos.Add(
                new Contato
                {
                    Codigo = 1,
                    Nome = "Ana",
                    SobreNome = "Silva",
                    Ddd = "11",
                    telefone = "987654321",
                    TipoTelefone = ETipoTelefone.Pessoal,
                    Email = "ana.silva@email.com"
                }
            );

            Contato.ListaContatos.Add(new Contato { Codigo = 2, Nome = "João", SobreNome = "Santos", Ddd = "21", telefone = "998877665", TipoTelefone = ETipoTelefone.Pessoal, Email = "joao.santos@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 3, Nome = "Maria", SobreNome = "Oliveira", Ddd = "31", telefone = "999123456", TipoTelefone = ETipoTelefone.Pessoal, Email = "maria.oliveira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 4, Nome = "Carlos", SobreNome = "Pereira", Ddd = "41", telefone = "986543210", TipoTelefone = ETipoTelefone.Pessoal, Email = "carlos.pereira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 5, Nome = "Fernanda", SobreNome = "Costa", Ddd = "51", telefone = "988776655", TipoTelefone = ETipoTelefone.Pessoal, Email = "fernanda.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 6, Nome = "Pedro", SobreNome = "Almeida", Ddd = "61", telefone = "991122233", TipoTelefone = ETipoTelefone.Comercial, Email = "pedro.almeida@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 7, Nome = "Julia", SobreNome = "Mendes", Ddd = "71", telefone = "992233344", TipoTelefone = ETipoTelefone.Comercial, Email = "julia.mendes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 8, Nome = "Lucas", SobreNome = "Rodrigues", Ddd = "81", telefone = "995544332", TipoTelefone = ETipoTelefone.Comercial, Email = "lucas.rodrigues@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 9, Nome = "Patricia", SobreNome = "Souza", Ddd = "91", telefone = "997788665", TipoTelefone = ETipoTelefone.Comercial, Email = "patricia.souza@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 10, Nome = "Ricardo", SobreNome = "Nascimento", Ddd = "11", telefone = "981234567", TipoTelefone = ETipoTelefone.Pessoal, Email = "ricardo.nascimento@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 11, Nome = "Gabriela", SobreNome = "Lima", Ddd = "21", telefone = "996655443", TipoTelefone = ETipoTelefone.Comercial, Email = "gabriela.lima@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 12, Nome = "Marcos", SobreNome = "Gomes", Ddd = "31", telefone = "977788991", TipoTelefone = ETipoTelefone.Pessoal, Email = "marcos.gomes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 13, Nome = "Camila", SobreNome = "Silveira", Ddd = "41", telefone = "999877665", TipoTelefone = ETipoTelefone.Comercial, Email = "camila.silveira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 14, Nome = "Juliano", SobreNome = "Ferreira", Ddd = "51", telefone = "986543321", TipoTelefone = ETipoTelefone.Pessoal, Email = "juliano.ferreira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 15, Nome = "Renata", SobreNome = "Martins", Ddd = "61", telefone = "993311443", TipoTelefone = ETipoTelefone.Comercial, Email = "renata.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 16, Nome = "Eduardo", SobreNome = "Barbosa", Ddd = "71", telefone = "991144557", TipoTelefone = ETipoTelefone.Pessoal, Email = "eduardo.barbosa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 17, Nome = "Luana", SobreNome = "Moura", Ddd = "81", telefone = "994455668", TipoTelefone = ETipoTelefone.Pessoal, Email = "luana.moura@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 18, Nome = "Thiago", SobreNome = "Costa", Ddd = "91", telefone = "999022233", TipoTelefone = ETipoTelefone.Comercial, Email = "thiago.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 19, Nome = "Adriana", SobreNome = "Dias", Ddd = "11", telefone = "987123456", TipoTelefone = ETipoTelefone.Pessoal, Email = "adriana.dias@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 20, Nome = "Gustavo", SobreNome = "Vasquez", Ddd = "21", telefone = "988334455", TipoTelefone = ETipoTelefone.Comercial, Email = "gustavo.vasquez@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 21, Nome = "Isabela", SobreNome = "Martins", Ddd = "31", telefone = "988887766", TipoTelefone = ETipoTelefone.Pessoal, Email = "isabela.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 22, Nome = "Fábio", SobreNome = "Azevedo", Ddd = "41", telefone = "994422778", TipoTelefone = ETipoTelefone.Comercial, Email = "fabio.azevedo@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 23, Nome = "Simone", SobreNome = "Macedo", Ddd = "51", telefone = "983344556", TipoTelefone = ETipoTelefone.Recado, Email = "simone.macedo@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 24, Nome = "Rodrigo", SobreNome = "Martins", Ddd = "61", telefone = "992211334", TipoTelefone = ETipoTelefone.Recado, Email = "rodrigo.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 25, Nome = "Priscila", SobreNome = "Nunes", Ddd = "71", telefone = "991122334", TipoTelefone = ETipoTelefone.Recado, Email = "priscila.nunes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 26, Nome = "Felipe", SobreNome = "Gonçalves", Ddd = "81", telefone = "996633442", TipoTelefone = ETipoTelefone.Recado, Email = "felipe.goncalves@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 27, Nome = "Renato", SobreNome = "Soares", Ddd = "91", telefone = "998877664", TipoTelefone = ETipoTelefone.Recado, Email = "renato.soares@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 28, Nome = "Tatiane", SobreNome = "Ribeiro", Ddd = "11", telefone = "987654321", TipoTelefone = ETipoTelefone.Recado, Email = "tatiane.ribeiro@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 29, Nome = "Alberto", SobreNome = "Pinto", Ddd = "21", telefone = "993311225", TipoTelefone = ETipoTelefone.Pessoal, Email = "alberto.pinto@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 30, Nome = "Claudia", SobreNome = "Cavalcante", Ddd = "31", telefone = "988991122", TipoTelefone = ETipoTelefone.Comercial, Email = "claudia.cavalcante@email.com" });

        }
    }
}
