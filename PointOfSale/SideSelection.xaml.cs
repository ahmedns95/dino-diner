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
using DinoDiner.Menu;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Item.Add(new Fryceritops());
            btnAddFryceritops.IsEnabled = false;

        }
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Item.Add(new MeteorMacAndCheese());
        }
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Item.Add(new MezzorellaSticks());
        }
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Item.Add(new Triceritots());
        }
    }
}
