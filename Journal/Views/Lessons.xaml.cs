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
    /// Логика взаимодействия для Lessons.xaml
    /// </summary>
    public partial class Lessons : Page
    {
        Journal1Entities db = new Journal1Entities();
        public static DataGrid LesDG1 = new DataGrid();
        public Lessons()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            LesDG.ItemsSource = db.Занятие.ToList();
            LesDG1 = LesDG;
        }

        private void NewGrp_Click(object sender, RoutedEventArgs e)
        {
            NewLessons nl = new NewLessons();
            nl.Show();
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (LesDG.SelectedItem as Занятие).Код_Занятия;
            var deleteles = db.Занятие.Where(m => m.Код_Занятия == Id).Single();
            db.Занятие.Remove(deleteles);
            db.SaveChanges();
            LesDG.ItemsSource = db.Дисциплина.ToList();
        }
    }
}
