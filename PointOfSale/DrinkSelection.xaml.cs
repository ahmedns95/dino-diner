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
        private CretaceousCombo combo;
        public DrinkSelection()
        {
            InitializeComponent();
            
        }
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.drink = combo.Drink;
            this.combo = combo;
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
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
                Decaf.IsEnabled = false;
                Lemon.IsEnabled = false;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = true;
                Ice.IsEnabled = true;
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
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
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
                drink = new JurassicJava();
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
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
                Decaf.IsEnabled = true;
                Lemon.IsEnabled = false;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = false;
                

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
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                }
                Decaf.IsEnabled = false;
                Lemon.IsEnabled = true;
                Sweet.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                
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
        /// <summary>
        /// event to handel lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
                    else if (drink is Tyrannotea tea)
                    {
                        tea.AddLemon();
                    }
                }
            }
        }
        /// <summary>
        /// event to handel SelectDecaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink != null)
                {
                    if (drink is JurassicJava java)
                    {
                        java.AddDecaf();
                    }
                }
            }
        }
        /// <summary>
        /// event to handel SelectSweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// event to handel SelectHoldIce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
                    else if (drink is Sodasaurus soda)
                    {
                        soda.HoldIce();
                    }
                }
            }
        }
    }
}
