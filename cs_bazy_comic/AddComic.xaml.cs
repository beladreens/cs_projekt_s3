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
    /// Interaction logic for AddComic.xaml
    /// </summary>
    public partial class AddComic : Window
    {
        webtoon Komiks;
        db_WebtoonsEntities DB;
        public AddComic(webtoon Komiks, db_WebtoonsEntities DB)
        {
            this.Komiks = Komiks;
            this.DB = DB;
            InitializeComponent();
            AddNewComic();
        }
        private void AddNewComic()
        {

        }
    }
}
