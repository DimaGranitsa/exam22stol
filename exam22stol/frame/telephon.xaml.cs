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
using exam22stol.BD;

namespace exam22stol.frame
{
    /// <summary>
    /// Логика взаимодействия для telephon.xaml
    /// </summary>
    public partial class telephon : Page
    {
        public telephon()
        {
            InitializeComponent();
            q.ItemsSource = BD.Conekt.web22Entities.Telephone.ToList();
        }
        private void fsp()
        {
            var special = BD.Conekt.web22Entities.Telephone.ToList();
            if (cellphone.IsChecked.Value)
                special = special.Where(z => z.ID_Tupe == 2).ToList();
            q.ItemsSource = special;
            if (mobile.IsChecked.Value)
                special = special.Where(z => z.ID_Tupe == 3).ToList();
            q.ItemsSource = special;
            if (domestic.IsChecked.Value)
                special = special.Where(z => z.ID_Tupe == 1).ToList();
            q.ItemsSource = special;
        }
        private void pytesh_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void pytesh_Checked(object sender, RoutedEventArgs e)
        {
            //    q.ItemsSource = BD.Conekt.web22Entities.Telephone.ToList();
        }

        private void cellphone_Checked(object sender, RoutedEventArgs e)
        {
            fsp();
        }

        private void cellphone_Unchecked(object sender, RoutedEventArgs e)
        {
            q.ItemsSource = BD.Conekt.web22Entities.Telephone.ToList();

        }

        private void mobile_Checked(object sender, RoutedEventArgs e)
        {
            fsp();
        }

        private void mobile_Unchecked(object sender, RoutedEventArgs e)
        {
            q.ItemsSource = BD.Conekt.web22Entities.Telephone.ToList();
        }

        private void domestic_Checked(object sender, RoutedEventArgs e)
        {
            fsp();
        }

        private void domestic_Unchecked(object sender, RoutedEventArgs e)
        {
            q.ItemsSource = BD.Conekt.web22Entities.Telephone.ToList();
        }

        private void q_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
