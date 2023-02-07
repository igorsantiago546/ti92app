using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario() { }
        // public Usuario() { string nome, string email, string senha, Nivel nivel }
         
        
        
    }
}
