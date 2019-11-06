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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        private CretaceousCombo combo;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ChangeSize(object sender, RoutedEventArgs args)
        {
            if (combo != null) { return; }
            if (sender is FrameworkElement element)
            {
                combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        public void SelectSize(object sender, RoutedEventArgs args)
        {
            //if (combo == null) { return; }
            //if (sender is FrameworkElement element)
            //{
            //    combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            //}
        }

    }
}
