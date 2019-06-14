﻿using System;
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
using WpfApplication1.Pages;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for GirisPage.xaml
    /// </summary>
    public partial class GirisPage : Page
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LCGK9FQ\\SQLEXPRESS;Initial Catalog=DGSTercih;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public GirisPage()
        {
            InitializeComponent();
            baglanti.Open();
            cmd.Connection = baglanti;

        }

        public static String id;
        public static String uid;

        private void buttonGiris_Click(object sender, RoutedEventArgs e)
        {
            if(baglanti.State.ToString()=="Close")
            {
                baglanti.Open();
            }
            cmd.CommandText = "Select * From Ogrenci WHERE Email='" + textBox_email.Text + "' AND Sifre='" + textBox_sifre.Text + "' ";
            // cmd.CommandText = "Select * From Ogrenci WHERE Ad='" + textBox_email.Text + "' ";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr[0].ToString();
                //NavigationWindow win = new NavigationWindow(); >>> yenı pencerede açar
                //win.Content = new OkulListesiPage();
                //win.Show();

                OkulListesiPage olp = new OkulListesiPage();
                this.NavigationService.Navigate(olp);
            }

        }

        private void buttonUyeOl_Click(object sender, RoutedEventArgs e)
        {
            KayıtPage kp = new KayıtPage();
            this.NavigationService.Navigate(kp);
        }


        private void buttonuzmanGiris_Click(object sender, RoutedEventArgs e)
        {
            cmd.CommandText = "Select * From Uzman WHERE Ad='" + textBox_email.Text + "'";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                uid = dr[0].ToString();
                //NavigationWindow win = new NavigationWindow(); >>> yenı pencerede açar
                //win.Content = new OkulListesiPage();
                //win.Show();

                UzmanPage up = new UzmanPage();
                this.NavigationService.Navigate(up);
            }
        }
    }
}
