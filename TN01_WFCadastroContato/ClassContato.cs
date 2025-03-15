using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroContato
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    class Contato
    {
        public Contato(int codigo, string? nome, string? sobreNome, string? ddd, string? telefone, ETipoTelefone tipoTelefone, string? email)
        {
            Codigo = codigo;
            Nome = nome;
            SobreNome = sobreNome;
            Ddd = ddd;
            this.telefone = telefone;
            TipoTelefone = tipoTelefone;
            Email = email;
        }

        public Contato() { }

        public static List<Contato> ListaContatos = new List<Contato>();
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public string? Ddd { get; set; }
        public string? telefone { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }
       
    }
}
