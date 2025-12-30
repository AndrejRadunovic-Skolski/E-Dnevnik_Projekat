using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ednevnik410b
{
    internal class Konekcija
    {
        public static SqlConnection NapraviVezu()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ednevnik;Integrated Security=True;");
        }
    }
}
