using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for YorumGoruntulemePage.xaml
    /// </summary>
    public partial class YorumGoruntulemePage : Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public YorumGoruntulemePage()
        {
            InitializeComponent();

            baglanti.Open();

            comboUzman.Items.Add("Yorum yapan yok");
            comboBoxDoldur();
        }

        void comboBoxDoldur()
        {
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT Ad FROM Uzman u,Yorumlar y WHERE u.id=y.UzmanId  AND y.OgrenciId='" + GirisPage.id +"' ";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboUzman.Items.Clear();
                    String b = dr["Ad"].ToString();
                    comboUzman.Items.Add(b);

                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);
                throw;
            }

           
        }


        private void comboUzman_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            cmd.CommandText = "SELECT u.Ad,o.Ad,y.Yorum FROM Yorumlar y,Uzman u,Ogrenci o WHERE y.UzmanId=u.id AND y.OgrenciId=o.id AND y.OgrenciId='" + GirisPage.id + "' AND u.Ad='"+comboUzman.SelectedItem+"' ";
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {

               
                textBoxOgrad.Text= dr["Ad"].ToString();
                textBoxYorum.Text = dr["Yorum"].ToString();
            }
        }
    }
}
