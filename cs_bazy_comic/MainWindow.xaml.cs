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

namespace cs_bazy_comic
{
    /// <summary>
    /// wyświetlanie listy istniejących pozycji
    /// dodawanie nowych pozycji poprzez otwarcie nowego okna (AddComic)
    /// </summary>
    public partial class MainWindow : Window
    {
        webtoon Komiks;
        db_WebtoonsEntities DB;
        public MainWindow()
        {
            AktualizujListe();
        }
        private void PrzyciskDodajPozycje_Click(object sender, RoutedEventArgs e)
        {
            AddComic oknoKomiks = new AddComic(Komiks, DB);
            oknoKomiks.ShowDialog();
        }
        private void AktualizujListe()
        {
            ListBoxItem itm = new ListBoxItem
            {
                Content = DB.webtoons
            };

            Lista_Tytulow.Items.Add(itm);
        }
    }
}
