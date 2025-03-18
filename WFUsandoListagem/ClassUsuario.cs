using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFUsandoListagem
{
    public class Usuarios
    {
        public Usuarios(int codigo, string? usuario, string? senha, DateTime dataCadastro)
        {
            Codigo = codigo;
            Login = usuario;
            Senha = senha;
            DataCadastro = dataCadastro;
        }
        public Usuarios () { }
       
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public  DateTime DataCadastro{ get; set; }

        public static List<Usuarios> ListaUsuarios = new List<Usuarios>();


    }
}
