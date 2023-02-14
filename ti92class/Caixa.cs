using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Caixa
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Saldo { get; set; }

        public string Status { get; set; }

        public Usuario Usuario { get; set; }

        public Caixa() { }

        public Caixa(DateTime data, double saldo, string status, Usuario usuario) 
        { 
            Data = data;
            Saldo = saldo;
            Status = status;
            Usuario = usuario;
        }

        public Caixa(int id, DateTime data, double saldo, string status, Usuario usuario)
        {
            Id = id;
            Data = data;
            Saldo = saldo;
            Status = status;
            Usuario = usuario;
        }
    }
   
}
