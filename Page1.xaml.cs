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

namespace Ostateczny_WPF_projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void OdniesDoGlowne_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GLOWNE());
        }

        private void OdniesDoTerminy_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GLOWNE());
 //do zmiany
        }

        private void OdniesMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainWindow());
        }
    }
}
