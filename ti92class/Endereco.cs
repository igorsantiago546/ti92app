using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class endereco
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Uf { get; set; }

        public string Tipo { get; set; }

        public Cliente Cliente { get; set; }




    }
}
