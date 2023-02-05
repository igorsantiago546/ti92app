using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Produto
    {
        public int Id { get; set;}
        public string Descrição { get; set;}
        public string Unidade { get; set;}
        public int CodBar { get; set;}
        public float Preco { get; set;}
        public float Desconto { get; set;}
        public bool Descontinuado { get; set;}

    }
}
