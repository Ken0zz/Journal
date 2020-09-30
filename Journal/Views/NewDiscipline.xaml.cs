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
    /// Логика взаимодействия для NewDiscipline.xaml
    /// </summary>
    public partial class NewDiscipline : Window
    {
        JournalEntities db = new JournalEntities();
        public NewDiscipline()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Дисциплина newdisc = new Дисциплина()
            {
                Наименование = name.Text,
            };
            db.Дисциплина.Add(newdisc);
            Discipline.discdatagrid.ItemsSource = db.Дисциплина.ToList();
            db.SaveChanges();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
