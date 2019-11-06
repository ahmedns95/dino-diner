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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo combo;

        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;// you need this. here 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combo"></param>
        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.pbj = (PrehistoricPBJ)combo.Entree;
            this.combo = combo;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SlectHoldPeanutButter(object sender , RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButter();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SlectHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SlectDone(object sender, RoutedEventArgs args)
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
