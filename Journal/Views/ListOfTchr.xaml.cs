using Journal.Models;
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

namespace Journal.Views
{
    /// <summary>
    /// Логика взаимодействия для ListOfTchr.xaml
    /// </summary>
    public partial class ListOfTchr : Page
    {
        JournalEntities db = new JournalEntities();
        public static DataGrid dgl = new DataGrid();
        public ListOfTchr()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            ldg.ItemsSource = db.Список.ToList();
            dgl = ldg;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (ldg.SelectedItem as Список).Кол_списка;
            db.Список.Remove(db.Список.Where(m => m.Кол_списка == id).Single());
            db.SaveChanges();
            ldg.ItemsSource = db.Список.ToList();
        }

        private void Newlist_Click(object sender, RoutedEventArgs e)
        {
            NewList nl = new NewList();
            nl.Show();
        }
    }
}
