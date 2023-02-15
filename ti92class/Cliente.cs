using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

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
            cmd.ExecuteNonQuery();
            cmd.CommanText = "select @@identity";
            Id =Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista= new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente
                    (
                        dr.GetString(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetDatetime(3),
                        dr.GetBoolean(4)
                    )
                    );
            }
            return lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where id =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                cliente.Id = dr.GetString(0);
                cliente.Cpf = dr.GetInt32(1);
                cliente.Email = dr.GetString(2);
                cliente.DataCad = dr.GetDatetime(3);
                cliente.Ativo = dr.GetBoolean(4);
            }
            return cliente;
        }
        public static void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set nome = '" + cliente.Nome + "', cpf = " + cliente.Cpf + ",email = '" + cliente.Email + "',datacad = '" + cliente.DataCad + "',ativo = '" + cliente.Ativo;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete * from clientes where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read()) 
            {
                lista.Add(new Cliente
                    (
                        dr.GetString(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetDatetime(3),
                        dr.GetBoolean(4)
                    )
                    );
            }
            return lista;
        }

    }
   
}
