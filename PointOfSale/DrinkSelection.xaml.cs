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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }
        private void ChangeSize(object sender, RoutedEventArgs args)
        {
            if(drink == null) { return; }
            if(sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        private void SelectSodassaurus(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                drink = new Sodasaurus();
                //if ((bool)Small.IsChecked)
                //{
                //    drink.Size = DinoDiner.Menu.Size.Small;
                //}
                order.Add(drink);
            }
        }
        private void SelectTryrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }
        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Add(drink);
            }
        }
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }
        /// <summary>
        /// Event handeler for Selcet falvor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(drink is Sodasaurus)
            {
              //NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
            }
        }
    }
}
