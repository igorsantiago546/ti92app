using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            // Conexão com Mysql no C#

            MySqlCommand cmd = new MySqlCommand();
            return cmd;
        }
    }
}
