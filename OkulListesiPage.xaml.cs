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
    /// Interaction logic for OkulListesiPage.xaml
    /// </summary>
    public partial class OkulListesiPage
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public OkulListesiPage()
        {
            InitializeComponent();

            //Giris yapan kullanıcının idsi >>>  GirisPage.id
            comboBoxDefaultDeger();
            baglanti.Open();
            cmd.CommandText = "SELECT * FROM OkulTercih";
            cmd.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("OkulTercih");
            adapter.Fill(dt);
            dg.ItemsSource = dt.DefaultView;
            comboBoxDoldur();
        }
        void comboBoxDefaultDeger()
        {
            comboBolum.Items.Add("Hepsi");
            comboBurs.Items.Add("Hepsi");
            comboProgturu.Items.Add("Hepsi");
            comboSehir.Items.Add("Hepsi");
            comboUnituru.Items.Add("Hepsi");
        }
        void comboBoxDoldur()
        {
           
            comboBoxDoldur2();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT Bolum FROM OkulTercih";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["Bolum"].ToString();
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
        void comboBoxDoldur2()
        {
            comboBoxDoldur3();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT ProgramTuru FROM OkulTercih";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["ProgramTuru"].ToString();
                    comboProgturu.Items.Add(b);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);
                throw;
            }

        }
        void comboBoxDoldur3()
        {
            comboBoxDoldur4();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT UniversiteTuru FROM OkulTercih";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["UniversiteTuru"].ToString();
                    comboUnituru.Items.Add(b);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);
                throw;
            }

        }
        void comboBoxDoldur4()
        {
            comboBoxDoldur5();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT Sehir FROM OkulTercih";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["Sehir"].ToString();
                    comboSehir.Items.Add(b);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);
                throw;
            }

        }
        void comboBoxDoldur5()
        {
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT DISTINCT BursTuru FROM OkulTercih";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String b = dr["BursTuru"].ToString();
                    comboBurs.Items.Add(b);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e.Message);
                throw;
            }

        }
        
        private void btntercih_Click(object sender, RoutedEventArgs e)
        {
            int Tercihid = Convert.ToInt32(((TextBlock)dg.Columns[0].GetCellContent(dg.SelectedItem)).Text);

            //Giris yapan kullanıcının idsi >>>  GirisPage.id
            cmd.CommandText = "INSERT INTO Tercihler (Bolum,ProgramTuru,UniversiteTuru,BursTuru,Sehir,OkulId,OgrenciId,Puan,Kontenjan) SELECT Bolum,ProgramTuru,UniversiteTuru,BursTuru,Sehir,id,'"+ GirisPage.id + "',Puan,Kontenjan FROM OkulTercih WHERE id='" + Tercihid + "'";
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM OkulTercih WHERE id!='" + Tercihid + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("OkulTercih");
            adapter.Fill(dt);
            dg.ItemsSource = dt.DefaultView;

            MessageBox.Show("Tercih Listesine Gönderildi.");
        }

        private void comboBolum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBolum.SelectedIndex != 0)
            {
                cmd.CommandText = "SELECT * FROM OkulTercih ok WHERE  Bolum='" + comboBolum.SelectedItem + "'";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);

                dg.ItemsSource = dt.DefaultView;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM OkulTercih";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);
                dg.ItemsSource = dt.DefaultView;

            }
        }

        private void comboBurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBurs.SelectedIndex != 0)
            {
                cmd.CommandText = "SELECT * FROM OkulTercih WHERE BursTuru='" + comboBurs.SelectedItem + "'";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);

                dg.ItemsSource = dt.DefaultView;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM OkulTercih";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);
                dg.ItemsSource = dt.DefaultView;

            }
        }

        private void comboProgturu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboProgturu.SelectedIndex != 0)
            {
                cmd.CommandText = "SELECT * FROM OkulTercih  WHERE ProgramTuru='" + comboProgturu.SelectedItem + "'";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);

                dg.ItemsSource = dt.DefaultView;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM OkulTercih ";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);
                dg.ItemsSource = dt.DefaultView;

            }
        }

        private void comboUnituru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboUnituru.SelectedIndex != 0)
            {
                cmd.CommandText = "SELECT * FROM OkulTercih WHERE UniversiteTuru='" + comboUnituru.SelectedItem + "'";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);

                dg.ItemsSource = dt.DefaultView;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM OkulTercih ";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);
                dg.ItemsSource = dt.DefaultView;

            }

        }

        private void comboSehir_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboSehir.SelectedIndex != 0)
            {
                cmd.CommandText = "SELECT * FROM OkulTercih WHERE Sehir='" + comboSehir.SelectedItem + "'";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);

                dg.ItemsSource = dt.DefaultView;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM OkulTercih";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("OkulTercih");
                adapter.Fill(dt);
                dg.ItemsSource = dt.DefaultView;

            }
        }

    }
}

