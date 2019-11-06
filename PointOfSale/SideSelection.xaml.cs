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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();

        }
        private Side side;
        private CretaceousCombo combo;
        /// <summary>
        /// Cinstructor
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        /// <summary>
        /// Cinstructor
        /// </summary>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.side = (Side)combo.Side;
            this.combo = combo;
        }
        private void SelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if ((bool)Small.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                if(combo!=null){
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
                
            }

        }
        public void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if ((bool)Small.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }
        public void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if ((bool)Small.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }
        public void SelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if ((bool)Small.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                else if ((bool)Medium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                else if ((bool)Large.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                }
            }
        }
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (side == null) { return; }
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
