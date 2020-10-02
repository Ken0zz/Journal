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
    
    public partial class NewGroup : Window
    {
        Journal1Entities db = new Journal1Entities();
        public NewGroup()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            thcr.ItemsSource = db.Преподаватель.ToList();
            thcr.SelectedValuePath = "Код_преподавателя";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Группа grp = new Группа()
            {
                Наименование = name.Text,
                Куратор = Convert.ToInt32(thcr.SelectedValue.ToString()),
            };
            db.Группа.Add(grp);
            db.SaveChanges();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
