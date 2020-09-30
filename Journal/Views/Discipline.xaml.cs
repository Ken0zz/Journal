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
    /// Логика взаимодействия для Discipline.xaml
    /// </summary>
    public partial class Discipline : Page
    {
        JournalEntities db = new JournalEntities();
        public static DataGrid discdatagrid = new DataGrid();
        public Discipline()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DiscDG.ItemsSource = db.Дисциплина.ToList();
            discdatagrid = DiscDG;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (DiscDG.SelectedItem as Дисциплина).Код_дисциплины;
            var deleteMember = db.Дисциплина.Where(m => m.Код_дисциплины == Id).Single();
            db.Дисциплина.Remove(deleteMember);
            db.SaveChanges();
            DiscDG.ItemsSource = db.Дисциплина.ToList();
        }

        private void NewDisc_Click(object sender, RoutedEventArgs e)
        {
            NewDiscipline newDiscipline = new NewDiscipline();
            newDiscipline.Show();
        }
    }
}
