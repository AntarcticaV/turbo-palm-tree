using _21._106_Beliy_4.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21._106_Beliy_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSerch_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                using (var db = new Entities())
                {
                    db.Speciality.Load();
                    List<Group> result = new List<Group>();
                    result = db.Group.Where(o => o.Speciality.Title == "15.02.09 Аддитивные технологии")
                        .OrderByDescending(g => g.Title).ToList();
                    LoadDate.ItemsSource = result;
                    if (result.Count == 0)
                    {
                        labelError.Content = "Записи отсутствуют";
                    }
                }
            }
            catch
            {

            }
        }
    }
}
