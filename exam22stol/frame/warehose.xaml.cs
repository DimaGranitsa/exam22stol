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

namespace exam22stol.frame
{
    /// <summary>
    /// Логика взаимодействия для warehose.xaml
    /// </summary>
    public partial class warehose : Page
    {
        public warehose()
        {
            InitializeComponent();
            q.ItemsSource = BD.Conekt.web22Entities.Warehouse.ToList();
        }

        private void q_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
