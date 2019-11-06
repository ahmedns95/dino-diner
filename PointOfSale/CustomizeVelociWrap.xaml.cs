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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap wrap;
        private CretaceousCombo combo;
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }
        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.wrap = (VelociWrap)combo.Entree;
            this.combo = combo;
        }
        private void SlectHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }
        private void SlectHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }
        private void SlectHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCatogriPage());

            }
        }
    }
}
