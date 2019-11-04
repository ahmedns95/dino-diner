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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger steakBurger;
        public CustomizeSteakosaurusBurger(SteakosaurusBurger steakBurger)
        {
            InitializeComponent();
            this.steakBurger = steakBurger;
        }

        private void SlectHoldBun(object sender, RoutedEventArgs args)
        {
            steakBurger.HoldBun();
        }
        private void SlectHoldPickle(object sender, RoutedEventArgs args)
        {
            steakBurger.HoldPickle();
        }
        private void SlectHoldKetchup(object sender, RoutedEventArgs args)
        {
            steakBurger.HoldKetchup();
        }
        private void SlectHoldMustard(object sender, RoutedEventArgs args)
        {
            steakBurger.HoldMustard();
        }
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();

        }
    }
}
