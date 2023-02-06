using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Nivel
    {
        // Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        // Métodos construtores

        public Nivel() { }

        public Nivel(string _nome, string _sigla)
        {
            Nome = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }

        // Métodos da classe 
        public void Inserir()
        {
            // Gravar um novo nível na tabela niveis

        }
        public List<Nivel> Listar()
        {
            // Entrega uma lista de todos os níveis
            List<Nivel> lista = new List<Nivel>();

            // Lógica que recupera todos os níveis da tabela
            return lista;
        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }
        public static void Atualizar(Nivel nivel)
        {

        }
        public bool Excliur(int _id)
        {

            return true;

        }

    }
}