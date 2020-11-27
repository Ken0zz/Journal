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
using System.Windows.Shapes;

namespace Journal.Views
{
    /// <summary>
    /// Логика взаимодействия для NewList.xaml
    /// </summary>
    public partial class NewList : Window
    {
        Journal1Entities db = new Journal1Entities();
        public NewList()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            thcr.ItemsSource = db.Преподаватель.ToList();
            thcr.SelectedValuePath = "Код_преподавателя";
            disc.ItemsSource = db.Дисциплина.ToList();
            disc.SelectedValuePath = "Код_дисциплины";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Список sp = new Список()  
            {
                Преподаватель = Convert.ToInt32(thcr.SelectedValue),
                Дисциплина = Convert.ToInt32(disc.SelectedValue)
            };
            db.Список.Add(sp);
            db.SaveChanges();
        }
    }
}
