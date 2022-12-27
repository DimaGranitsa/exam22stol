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
    /// Логика взаимодействия для wolker.xaml
    /// </summary>
    public partial class wolker : Page
    {
        public wolker()
        {
            InitializeComponent();
        }

        private void foto_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new exam22stol.frame.warehose());
        }

        private void redact_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new exam22stol.frame.вщищм());
        }
    }
}
