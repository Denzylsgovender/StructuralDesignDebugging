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

using System.Windows;

namespace CoffeeShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOrderCoffee_Click(object sender, RoutedEventArgs e)
        {
            string coffeeType = cmbCoffeeType.Text;
            string order = "Ordered: " + coffeeType;

            if (chkMilk.IsChecked == true)
            {
                order += " + Milk";
            }

            if (chkSugar.IsChecked == true)
            {
                order += " + Sugar";
            }

            txtOrderSummary.Text = order;
        }
    }
}
