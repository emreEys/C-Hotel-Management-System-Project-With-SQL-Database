using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pansiyon_otomasyonu
{
    class SqlCon
    {
        public SqlConnection bgl()
        {
            SqlConnection sbgl = new SqlConnection("Data Source=DESKTOP-SJ67R61\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");
            sbgl.Open();
            return sbgl;
        }
    }
}
