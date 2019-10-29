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
        /// <summary>
        /// 
        /// </summary>
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSize(object sender, RoutedEventArgs args)
        {
            if(drink == null) { return; }
            if(sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSodassaurus(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                drink = new Sodasaurus();
                if ((bool)Small.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                Decaf.IsEnabled = false;
                Lemon.IsEnabled = false;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = true;
                Ice.IsEnabled = true;


                order.Add(drink);
            }
        }
        private void SelectTryrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if ((bool)Small.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(drink);
                Decaf.IsEnabled = false;
                Lemon.IsEnabled = true;
                Sweet.IsEnabled = true;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = false; 

            }
        }
        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                if ((bool)Small.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                Decaf.IsEnabled = true;
                Lemon.IsEnabled = false;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = false;
                order.Add(drink);

            }
        }
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                if ((bool)Small.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                Decaf.IsEnabled = false;
                Lemon.IsEnabled = true;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
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
              NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
            }
        }
        private void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink != null)
                {
                    if (drink is Water water)
                    {
                        water.AddLemon();
                    }
                    if (drink is Tyrannotea tea)
                    {
                        tea.AddLemon();
                    }
                }
            }
        }
        private void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink != null)
                {
                    if (drink is JurrasicJava java)
                    {
                        java.AddDecaf();
                    }
                }
            }
        }
        private void SelectSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink != null)
                {
                    if (drink is Tyrannotea tea)
                    {
                        tea.AddSweet();
                    }
                }
            }
        }
        private void SelectHoldIce(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                if (drink != null)
                {
                    if (drink is Water water)
                    {
                        water.HoldIce();
                    }
                    
                    if (drink is Sodasaurus soda)
                    {
                        soda.HoldIce();
                    }
                }
            }
        }
    }
}
