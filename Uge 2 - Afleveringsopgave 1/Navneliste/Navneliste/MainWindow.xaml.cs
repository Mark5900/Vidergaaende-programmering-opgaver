using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Navneliste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] names = { "FC København", "Brøndby IF", "AGF", "FC Midtjylland", "OB", "AaB", "Randers FC", "SønderjyskE", "Vejle BK", "Lyngby BK" };

        public MainWindow()
        {
            InitializeComponent();
            Array.Sort(names);
            lstNames.ItemsSource = names;
        }

        private void btnRemovePosition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortAscending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortDescending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemoveSelectedName_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}