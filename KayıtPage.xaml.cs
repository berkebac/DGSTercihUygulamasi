using System;
using System.Collections.Generic;
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
    /// Interaction logic for KayıtPage.xaml
    /// </summary>
    public partial class KayıtPage : Page
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public KayıtPage()
        {
            InitializeComponent();
            comboBoxDoldur();
        }

        void comboBoxDoldur ()
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM Bolum";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["BolumAdi"].ToString();
                    comboBolum.Items.Add(b);
                }
                dr.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);   
                throw;
            }

        }

        private void buttonUyeOl_Click(object sender, RoutedEventArgs e)
        {
            
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO Ogrenci (Ad,SoyAd,Okul,Bolum,Email,Sifre) values('" + textBoxAd.Text + "' , '" + textBoxSoyad.Text + "', '" + textBox_okul.Text + "' , '" + comboBolum.SelectedItem + "' , '" + textBoxEmail.Text + "'  , '" + textBox_sifre.Text + "' )";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("ok");

            
            }
            GirisPage gp = new GirisPage();
            this.NavigationService.Navigate(gp);
        }

       
    }
}
