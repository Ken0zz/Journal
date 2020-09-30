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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public static string nametchr;
        JournalEntities db = new JournalEntities();
        
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool bl = false;
            for (int i = 0; i < db.Преподаватель.Count(); i++)
            {
                if ((db.Преподаватель.ToList()[i].Логин == login.Text) && (db.Преподаватель.ToList()[i].Пароль == pass.Text))
                {
                    bl = true;
                    nametchr = db.Преподаватель.ToList()[i].Имя + db.Преподаватель.ToList()[i].Отчество;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                
            }
            if(!bl) MessageBox.Show("Неверный логин или пароль");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            
        }
    }
}
