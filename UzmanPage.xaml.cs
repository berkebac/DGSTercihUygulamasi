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

namespace WpfApplication1.Pages
{
    /// <summary>
    /// Interaction logic for UzmanPage.xaml
    /// </summary>
    public partial class UzmanPage : Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UzmanPage()
        {
            InitializeComponent();
            baglanti.Open();
            cmd.CommandText = "SELECT * FROM Ogrenci o,Bolum b,Okul ok WHERE o.BolumId=b.id AND o.OkulId=ok.id";
            cmd.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Ogrenci");
            adapter.Fill(dt);
            dg.ItemsSource = dt.DefaultView;
        }
        int ogrid;
        private void btntercihGoruntule_Click(object sender, RoutedEventArgs e)
        {
            ogrid = Convert.ToInt32(((TextBlock)dg.Columns[0].GetCellContent(dg.SelectedItem)).Text);

            
            cmd.CommandText = "SELECT* FROM Tercihler t, Okul ok,Ogrenci o WHERE t.OkulId = ok.id AND t.OgrenciId = o.id AND OgrenciId='" + ogrid + "'";
            cmd.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Ogrenci");
            adapter.Fill(dt);
            dg.Visibility = Visibility.Hidden;
            stackTercih.Visibility = Visibility.Visible;
            dgTercihler.ItemsSource = dt.DefaultView;
            cmd.ExecuteNonQuery();
        }

        private void buttonGoster_Click(object sender, RoutedEventArgs e)
        {
            wpYorum.Visibility = Visibility.Visible;
        }

        private void buttonyorumGonder_Click(object sender, RoutedEventArgs e)
        {
            int UzmanID = Convert.ToInt32(GirisPage.uid);
            
            cmd.CommandText = "INSERT INTO Yorumlar (UzmanId,OgrenciId,Yorum) values('" + UzmanID + "' , '" + ogrid + "', '" + tbYorum.Text + "')";
            cmd.Connection = baglanti;
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Yorumunuz Gönderildi Öğrenci Listesine Yönlendiriliyorsunuz");
            wpYorum.Visibility = Visibility.Hidden;
            stackTercih.Visibility = Visibility.Hidden;
            dg.Visibility = Visibility.Visible;
        }
    }
}
