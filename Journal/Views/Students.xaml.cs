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
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Page
    {
        Journal1Entities db = new Journal1Entities();
        public static DataGrid StdDG1;
        public Students()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            StdDG.ItemsSource = db.Студент.ToList();
            StdDG1 = StdDG;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (StdDG.SelectedItem as Студент).Код_студента;
            var deleteStud = db.Студент.Where(m => m.Код_студента == Id).Single();
            db.Студент.Remove(deleteStud);
            db.SaveChanges();
            StdDG.ItemsSource = db.Студент.ToList();
        }

        private void NewStd_Click(object sender, RoutedEventArgs e)
        {
            NewStudent st = new NewStudent();
            st.Show();
        }
    }
}
