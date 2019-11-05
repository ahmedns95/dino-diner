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
    /// Interaction logic for CombosSelection.xaml
    /// </summary>
    public partial class CombosSelection : Page
    {
        public CombosSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handeler for the Customize combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSize(object sender, RoutedEventArgs args)
        {
           NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBrontowrst(object sender, RoutedEventArgs args)
        {
            Brontowurst browm = new Brontowurst();
            CretaceousCombo c = new CretaceousCombo(browm);
            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizeBrontowurst(browm));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nug = new DinoNuggets();
            CretaceousCombo c = new CretaceousCombo(nug);
            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizeDinoNuggests(nug));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSteakosaurus(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger sBurger = new SteakosaurusBurger();
            CretaceousCombo c = new CretaceousCombo(sBurger);
            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sBurger));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            TRexKingBurger kBurger = new TRexKingBurger();
            CretaceousCombo c = new CretaceousCombo(kBurger);

            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizeTRexKingBurger(kBurger));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPrehistoric(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pre = new PrehistoricPBJ();
            CretaceousCombo c = new CretaceousCombo(pre);

            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pre));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPterodactyWings(object sender, RoutedEventArgs args)
        {
            PterodactylWings wings = new PterodactylWings();
            CretaceousCombo c = new CretaceousCombo(wings);

            if (DataContext is Order order)
            {
                order.Add(c);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            CretaceousCombo c = new CretaceousCombo(wrap);


            if (DataContext is Order order)
            {
                order.Add(c);
                NavigationService.Navigate(new CustomizeVelociWrap(wrap));
            }
        }
    }
}
