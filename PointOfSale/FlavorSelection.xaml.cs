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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        private void SelectCherry(object sender, RoutedEventArgs args)
        {
            this.soda.Flavor = SodasaurusFlavor.Cherry;
        }

        private void SelectChocolate(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;

        }
        private void SelectCola(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cola;

        }

        private void SelectLime(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Lime;

        }
        private void SelectOrange(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Orange;

        }
        private void SlectRootBeer(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;

        }
    }
}
