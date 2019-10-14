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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCatogriPage.xaml
    /// </summary>
    public partial class MenuCatogriPage : Page
    {
        public MenuCatogriPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handeler for the Select combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CombosSelection());
        }
        /// <summary>
        /// Event handeler for the Select Entrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectEntrees(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Event handeler for the Select Drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrinks(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Event handeler for the Select Sides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        
    }
}
