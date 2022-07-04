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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.Pacjent
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.imie_pacjenta);
                Console.WriteLine(item.nazwisko_pacjenta);
                Console.WriteLine(item.wiek_pacjenta);
            }
            this.GridPacjenci.ItemsSource = docs.ToList();
        }
        private void OdswiezDane_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();

            var docs = from d in db.Pacjent
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.imie_pacjenta);
                Console.WriteLine(item.nazwisko_pacjenta);
                Console.WriteLine(item.wiek_pacjenta);
            }
            this.GridPacjenci.ItemsSource = docs.ToList();
        }

        private void DodajDane_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();

            var pacjentObj = new Pacjent()
            {
                ID_pacjenta = default,
                imie_pacjenta = ImPacjenta.Text,
                nazwisko_pacjenta = NazPacjenta.Text,
            };

            db.Pacjent.Add(pacjentObj);
            db.SaveChanges();

            var docs = from d in db.Pacjent
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.imie_pacjenta);
                Console.WriteLine(item.nazwisko_pacjenta);
            }
            this.GridPacjenci.ItemsSource = docs.ToList();
        }
    }
}
