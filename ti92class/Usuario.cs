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
        
        public Usuario( string _nome, string _email, string _senha, Nivel _nivel, bool _ativo)
        {
            Nome= _nome;
            Email= _email;
            Senha= _senha;
            Nivel= _nivel;
            Ativo= _ativo;
        }
       public Usuario(int _id, string _nome, string _senha, Nivel _nivel, bool _ativo)
        {
            Id= _id;
            Nome= _nome;
            Senha= _senha;
            Nivel= _nivel;
            Ativo= _ativo;
        }

        public void Inserir()
        {
            // gravar um novo nível na tabela usuarios
            
        }
         
        
        
    }
}
