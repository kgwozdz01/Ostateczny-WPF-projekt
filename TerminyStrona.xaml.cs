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
using System.Windows.Shapes;

namespace Ostateczny_WPF_projekt
{
    /// <summary>
    /// Logika interakcji dla klasy TerminyStrona.xaml
    /// </summary>
    public partial class TerminyStrona : Window
    {
        public TerminyStrona()
        {
            InitializeComponent();

            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.Terminy
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_terminu);
                Console.WriteLine(item.termin);
                Console.WriteLine(item.czy_wolne);
            }
            this.GridTerminyStrona.ItemsSource = docs.ToList();
        }

        private void Odswiezz_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.Terminy
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_terminu);
                Console.WriteLine(item.termin);
                Console.WriteLine(item.czy_wolne);
            }
            this.GridTerminyStrona.ItemsSource = docs.ToList();
        }

        private void DoDajj_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();

            var terminObj = new Terminy()
            {
                ID_terminu = default,
            };

            db.Terminy.Add(terminObj);
            db.SaveChanges();

            var docs = from d in db.Lekarz
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_lekarza);
                Console.WriteLine(item.imie_lekarza);
                Console.WriteLine(item.nazwisko_lekarza);
                Console.WriteLine(item.specjalizacja);
            }
            this.GridTerminyStrona.ItemsSource = docs.ToList();
        }
    }
}
