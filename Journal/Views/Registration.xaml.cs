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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        JournalEntities db = new JournalEntities();
        public Registration()
        {
            InitializeComponent();
            
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Преподаватель thcr = new Преподаватель()
            {
                Фамилия = lname.Text,
                Имя = name.Text,
                Отчество = mname.Text,
                Пароль = pass.Text,
                Логин = login.Text

            };
            db.Преподаватель.Add(thcr);
            db.SaveChanges();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
