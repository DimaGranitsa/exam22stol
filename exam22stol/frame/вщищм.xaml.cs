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
using static System.Net.Mime.MediaTypeNames;

namespace exam22stol.frame
{
    /// <summary>
    /// Логика взаимодействия для вщищм.xaml
    /// </summary>
    public partial class вщищм : Page
    {
        public вщищм()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BD.Warehouse q = new BD.Warehouse()
            {
                ProductName = namephoto.Text,
                NameoftheConsumable = namefotogrof.Text,
                quantity = teretory.Text,
                Shelf = Isoo.Text,
                Shelving = diofrag.Text,
               
            };
            BD.Conekt.web22Entities.Warehouse.Add(q);
            BD.Conekt.web22Entities.SaveChanges();
        }
    }
}
