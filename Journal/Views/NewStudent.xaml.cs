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
    /// Логика взаимодействия для NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        Journal1Entities db = new Journal1Entities();
        public NewStudent()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            GrpCB.ItemsSource = db.Группа.ToList();
            GrpCB.DisplayMemberPath = "Наименование";
            GrpCB.SelectedValuePath = "Код_группы";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Студент st = new Студент()
            {
                Фамилия = lname.Text,
                Имя = name.Text,
                Отчество = mname.Text,
                Группа = Convert.ToInt32(GrpCB.SelectedValue)
            };
            db.Студент.Add(st);
            db.SaveChanges();
            Students.StdDG1.ItemsSource = db.Студент.ToList();
        }
    }
}
