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

namespace AplikacjaDesktop
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

        private void CheckPriceClick(object sender, RoutedEventArgs e)
        {
            if(radioPocztowka.IsChecked == true)
            {
                labelCena.Content = "Cena: 1zł";
                imageRodzaj.Source = new BitmapImage(new Uri("pack://application:,,,/AplikacjaDesktop;component/Images/pocztowka.png"));
            }
            else if(radioList.IsChecked == true)
            {
                labelCena.Content = "Cena: 1,5zł";
                imageRodzaj.Source = new BitmapImage(new Uri("pack://application:,,,/AplikacjaDesktop;component/Images/list.png"));
            }
            else if(radioPaczka.IsChecked == true)
            {
                labelCena.Content = "Cena: 10zł";
                imageRodzaj.Source = new BitmapImage(new Uri("pack://application:,,,/AplikacjaDesktop;component/Images/paczka.png"));
            }
        }
    }
}