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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger kingBurger;
        public CustomizeTRexKingBurger(TRexKingBurger kingBurger)
        {
            InitializeComponent();
            this.kingBurger = kingBurger;
        }

        private void SlectHoldBun(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldBun();
        }
        private void SlectHoldPickle(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldPickle();
        }
        private void SlectHoldKetchup(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldKetchup();
        }
        private void SlectHoldMustard(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldMustard();
        }
        private void SlectHoldOnions(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldOnion();
        }
        private void SlectHoldLettuse(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldLettuce();
        }
        private void SlectHoldTomato(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldTomato();
        }
        private void SlectHoldMayo(object sender, RoutedEventArgs args)
        {
            kingBurger.HoldMayo();
        }
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
