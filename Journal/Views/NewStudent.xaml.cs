using Journal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Load1();
            
        }

        private void Load1()
        {
            if (Students.updid != -1)
            {
                var stud1 = db.Студент.FirstOrDefault(a => a.Код_студента == Students.updid);
                name.Text = stud1.Имя.ToString();
                mname.Text = stud1.Отчество.ToString();
                lname.Text = stud1.Фамилия.ToString();
                GrpCB.SelectedValue = stud1.Группа;
            }
            else
            {
                name.Text = "";
                mname.Text = "";
                lname.Text = "";
                GrpCB.SelectedValue = 0;
            }
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
            
            if (Students.updid == -1)
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
                this.Close();
            }
            else
            {

                
                //Студент st = (from m in db.Студент 
                //              where m.Код_студента == Students.updid 
                //              select m).Single();
                //st.Фамилия = lname.Text;
                //st.Имя = name.Text;
                //st.Отчество = mname.Text;
                //st.Группа = Convert.ToInt32(GrpCB.SelectedValue);
                //db.SaveChanges();
                //Students.StdDG1.ItemsSource = db.Студент.ToList();
                //this.Close();
                //Students.updid = -1;
            }
        }
    }
}
