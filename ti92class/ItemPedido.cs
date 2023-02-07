using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class ItemPedido
    {
        public Pedido Pedido { get; set; }

        public Produto Produto { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public double Desconto { get; set; }
    }
}
