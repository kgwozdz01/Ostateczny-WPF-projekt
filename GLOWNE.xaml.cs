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
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Ostateczny_WPF_projekt
{
    /// <summary>
    /// Logika interakcji dla klasy GLOWNE.xaml
    /// </summary>
    public partial class GLOWNE : Window
    {
        public GLOWNE()
        {
            InitializeComponent();

            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();
            var docs = from d in db.Lekarz
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.imie_lekarza);
                Console.WriteLine(item.nazwisko_lekarza);
                Console.WriteLine(item.specjalizacja);
            }
            this.GridLekarze.ItemsSource = docs.ToList();
        }
        private void DodajL_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();

            var lekarzObj = new Lekarz()
            {
                ID_lekarza = default,
                imie_lekarza = LTXT1.Text,
                nazwisko_lekarza = NazwiskoT.Text, 
                specjalizacja = specjalizacjaT.Text,
            };

            db.Lekarz.Add(lekarzObj);
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }


            var docs = from d in db.Lekarz
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_lekarza);
                Console.WriteLine(item.imie_lekarza);
                Console.WriteLine(item.nazwisko_lekarza);
                Console.WriteLine(item.specjalizacja);
            }
            this.GridLekarze.ItemsSource = docs.ToList();
        }

        private void OdswiezL_Click(object sender, RoutedEventArgs e)
        {
            OstatecznaWersjaEntities2 db = new OstatecznaWersjaEntities2();

            var docs = from d in db.Lekarz
                       select d;

            foreach (var item in docs)
            {
                Console.WriteLine(item.ID_lekarza);
                Console.WriteLine(item.imie_lekarza);
                Console.WriteLine(item.nazwisko_lekarza);
                Console.WriteLine(item.specjalizacja);
            }
            this.GridLekarze.ItemsSource = docs.ToList();
        }

    }
}
