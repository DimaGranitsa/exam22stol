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

namespace exam22stol
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            w.Navigate(new exam22stol.Development_Pages.registratia());
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {


        }

        private void regl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void w_Navigated(object sender, NavigationEventArgs e)
        {
            NavigationService.GetNavigationService(new exam22stol.Development_Pages.registratia());
        }
    }

       
}
