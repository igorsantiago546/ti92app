using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ti92class
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public string Email { get; set;}
        public DateTime DataCad { get; set;}
        public bool Ativo { get; set;}
        public Cliente() { }

        public Cliente (string nome, int cpf, string email, DateTime datacad, bool ativo)
        {
            Nome= nome;
            Cpf= cpf;
            Email= email;
            DataCad = datacad;
            Ativo= ativo;
        }

        public Cliente (int id, string nome, int cpf, string email, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = datacad;
            Ativo = ativo;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values ('" + Nome + "','" + Cpf + "','" + Email + "','" + DataCad + "',1)";

        }
    }
   
}
