using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using WpfApplication1.Pages;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {
            try
            {
                if (e.Content.ToString() == "WpfApplication1.Pages.OkulListesiPage")
                {
                    menu.Visibility = Visibility.Visible;
                }
            }
            catch (Exception b)
            {

            }
            
        }

        private void mi_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            Main.Source = new Uri("/WpfApplication1;component/" + mi.Tag + ".xaml", UriKind.Relative);

        }
    }
}
