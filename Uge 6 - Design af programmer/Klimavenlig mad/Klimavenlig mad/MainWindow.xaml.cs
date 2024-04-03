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

namespace Klimavenlig_mad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Food food = new Food();
            food.Name = inputName.Text;
            food.Category = inputCategory.Text;
            food.Co2_Agriculture = double.Parse(inputCo2_Agriculture.Text);
            food.Co2_Transport = double.Parse(inputCo2_Transport.Text);
            food.Co2_ILUC = double.Parse(inputCo2_ILUC.Text);
            food.Co2_Processing = double.Parse(inputCo2_Processing.Text);
            food.Co2_Packaging = double.Parse(inputCo2_Packaging.Text);
            food.Co2_Retail = double.Parse(inputCo2_Retail.Text);

            labelTotalCo2.Content = food.GetTotalCo2();
        }
    }
}