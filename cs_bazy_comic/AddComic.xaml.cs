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
using System.Globalization;

namespace cs_bazy_comic
{
    /// <summary>
    /// Dodawanie nowych pozycji do bazy danych
    /// Tytuł, autor, wydawcy, data dodania, status projektu, gatunek(kategoria)
    /// </summary>
    public partial class AddComic : Window
    {
        readonly webtoon Komiks;
        readonly db_WebtoonsEntities DB;
        public AddComic(webtoon Komiks, db_WebtoonsEntities DB)
        {
            this.Komiks = Komiks;
            this.DB = DB;
            InitializeComponent();
        }

        private void PoleZapisz(object sender, RoutedEventArgs e)
        {
            try
            {
                webtoon NowyKomiks = new webtoon();
                author NowyAutor = new author();
                NowyKomiks.title = PoleTytul.Text;
                NowyAutor.name = PoleName.Text;
                NowyAutor.surname = PoleSurname.Text;
                for_publishers nowy_zag_wyd = new for_publishers();
                orig_publishers nowy_oryg_wyd = new orig_publishers();
                nowy_oryg_wyd.name = PoleOrWyd.Text;
                nowy_zag_wyd.name = PoleZagWyd.Text;
                var cultureInfo = new CultureInfo("pl-PL");
                string dateString = PoleDataPub.Text;
                NowyKomiks.date_of_publication = DateTime.Parse(dateString, cultureInfo);

                DB.webtoons.Add(NowyKomiks);
                DB.webtoons.Add(NowyKomiks);

                DB.SaveChanges();
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Błędne dane");
            }
        }
        
    }
}
