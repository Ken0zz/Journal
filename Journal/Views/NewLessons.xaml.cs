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
    /// Логика взаимодействия для NewLessons.xaml
    /// </summary>
    public partial class NewLessons : Window
    {
        Journal1Entities db = new Journal1Entities();
        public NewLessons()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            GrpCB.ItemsSource = db.Группа.ToList();
            thcr.ItemsSource = db.Преподаватель.ToList();
            DiscCB.ItemsSource = db.Дисциплина.ToList();
            GrpCB.DisplayMemberPath = "Наименование";
            DiscCB.DisplayMemberPath = "Наименование";
            GrpCB.SelectedValuePath = "Код_группы";
            thcr.SelectedValuePath = "Код_преподавателя";
            DiscCB.SelectedValuePath = "Код_дисциплины";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Занятие les = new Занятие()
            {
                Дата = LesDP.SelectedDate,
                Тема = theme.Text,
                Домашнее_задание = homewrk.Text,
                Группа = Convert.ToInt32(GrpCB.SelectedValue),
                Преподаватель = Convert.ToInt32(thcr.SelectedValue),
                Дисциплина = Convert.ToInt32(DiscCB.SelectedValue)
            };
            db.Занятие.Add(les);
            db.SaveChanges();
            Lessons.LesDG1.ItemsSource = db.Занятие.ToList();
        }
    }
}
