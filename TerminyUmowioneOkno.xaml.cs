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
    /// Logika interakcji dla klasy TerminyUmowioneOkno.xaml
    /// </summary>
    public partial class TerminyUmowioneOkno : Window
    {
        public TerminyUmowioneOkno()
        {
            InitializeComponent();

            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.TerminyUmowione
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_TerminyUmowione);
                Console.WriteLine(item.ID_lekarza);
                Console.WriteLine(item.ID_pacjenta);
                Console.WriteLine(item.ID_termiu);

            }
            this.GridTerminyUmowione.ItemsSource = docs.ToList();
        }

        private void Odswiezzz_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.TerminyUmowione
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_TerminyUmowione);
                Console.WriteLine(item.ID_lekarza);
                Console.WriteLine(item.ID_pacjenta);
                Console.WriteLine(item.ID_termiu);

            }
            this.GridTerminyUmowione.ItemsSource = docs.ToList();
        }
    }
}
