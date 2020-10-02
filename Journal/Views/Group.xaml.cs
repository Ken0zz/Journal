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
    /// Логика взаимодействия для Group.xaml
    /// </summary>
    public partial class Group : Page
    {
        Journal1Entities db = new Journal1Entities();
        public Group()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            GrpDG.ItemsSource = db.Группа.ToList();
        }

        private void NewGrp_Click(object sender, RoutedEventArgs e)
        {
            NewGroup newGroup = new NewGroup();
            newGroup.Show();
        }

        private void delbtn_Click_1(object sender, RoutedEventArgs e)
        {
            int id = (GrpDG.SelectedItem as Группа).Код_группы;
            db.Группа.Remove(db.Группа.Where(m => m.Код_группы == id).Single());
            db.SaveChanges();
            GrpDG.ItemsSource = db.Группа.ToList();
        }
    }
}
