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
    /// Логика взаимодействия для Tabel.xaml
    /// </summary>
    public partial class Tabel : Page
    {
        Journal1Entities db = new Journal1Entities();
        public Tabel()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            
        }
    }
}
