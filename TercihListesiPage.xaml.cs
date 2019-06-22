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
    /// Interaction logic for UyeListesiPage.xaml
    /// </summary>
    public partial class UyeListesiPage : Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UyeListesiPage()
        {
            InitializeComponent();
            baglanti.Open();
            
            cmd.CommandText = "SELECT * FROM Tercihler t,Okul ok,Ogrenci o WHERE t.OkulId=ok.id AND t.OgrenciId=o.id AND t.OgrenciId='"+GirisPage.id+"' ";
            cmd.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("OkulTercih");
            adapter.Fill(dt);

            dg.ItemsSource = dt.DefaultView;
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            int silinecekid = Convert.ToInt32(((TextBlock)dg.Columns[0].GetCellContent(dg.SelectedItem)).Text);
            cmd.CommandText = "SELECT * FROM Tercihler t WHERE t.id='" + silinecekid + "'";
            cmd.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Tercihler");
            adapter.Fill(dt);

            dg.ItemsSource = dt.DefaultView;
        }
    }
}
