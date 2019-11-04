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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPrehistoric(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));

            }
        }
        private void SelectBrontowrst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst browm = new Brontowurst();
                order.Add(browm);
                NavigationService.Navigate(new CustomizeBrontowurst(browm));
            }
        }
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nug = new DinoNuggets();
                order.Add(nug);
                NavigationService.Navigate(new CustomizeDinoNuggests(nug));

            }
        }
        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger stekBurger = new SteakosaurusBurger();
                order.Add(stekBurger);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(stekBurger));
            }
        }
        private void SeletTRxTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger kingBurger = new TRexKingBurger();
                order.Add(kingBurger);
                NavigationService.Navigate(new CustomizeTRexKingBurger(kingBurger));
            }
        }
        private void SeletTVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
                NavigationService.Navigate(new CustomizeVelociWrap(wrap));
            }
        }
        private void SeletPterodactyWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
                //NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

    }
}
