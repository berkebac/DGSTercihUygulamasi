using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Baglanti
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
    }
}
