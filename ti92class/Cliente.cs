using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ti92class
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public string Email { get; set;}
        public DateTime Data { get; set;}
        public bool Ativo { get; set;}
    }
}
