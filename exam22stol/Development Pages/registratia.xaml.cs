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

namespace exam22stol.Development_Pages
{
    /// <summary>
    /// Логика взаимодействия для registratia.xaml
    /// </summary>
    public partial class registratia : Page
    {
        public registratia()
        {
            InitializeComponent();
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void regl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(log.Text) && string.IsNullOrEmpty(pass.Password))
            {
                MessageBox.Show("нет введеных даных");
            }
            else
            {
                var a = BD.Conekt.web22Entities.customers.Where(z => z.Login == log.Text && z.Passvord == pass.Password).FirstOrDefault();
                if (a != null)
                {
                    if (a.ID_Role == 1)
                    {
                        MessageBox.Show($"добропожаловать{a.Name}");
                        NavigationService.Navigate(new exam22stol.Development_Pages.themainwindowfortheadmin());
                    }
                    if (a.ID_Role == 2)
                    {
                        MessageBox.Show($"добропожаловать{a.Name}");
                        NavigationService.Navigate(new exam22stol.Development_Pages.wolker());
                    }
                    if (a.ID_Role == 3)
                    {
                        MessageBox.Show($"добропожаловать{a.Name}");
                        NavigationService.Navigate(new exam22stol.Development_Pages.Owner());
                    }
                    if (a.ID_Role == 4)
                    {
                        MessageBox.Show($"добропожаловать{a.Name}");
                        NavigationService.Navigate(new exam22stol.Development_Pages.klient());
                    }
                }
                else
                    MessageBox.Show($"нет таких");

            }
        }
        }
}
