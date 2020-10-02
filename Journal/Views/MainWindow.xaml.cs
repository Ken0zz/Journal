using Journal.Views;
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

namespace Journal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            hello.Text = "Добро пожаловать," + Authorization.nametchr;
        }

        private void disciplines_Click(object sender, RoutedEventArgs e)
        {
            Discipline newdisc = new Discipline();
            fr.Navigate(newdisc);
        }

        private void groups_Click(object sender, RoutedEventArgs e)
        {
            Group grp = new Group();
            fr.Navigate(grp);
        }

        private void teachers_Click(object sender, RoutedEventArgs e)
        {
            ListOfTchr l = new ListOfTchr();
            fr.Navigate(l);
        }

        private void lessons_Click(object sender, RoutedEventArgs e)
        {
            Lessons les = new Lessons();
            fr.Navigate(les);
        }
    }
}
