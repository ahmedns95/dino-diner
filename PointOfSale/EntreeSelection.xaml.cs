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
                //NavigationService.Navigate(new CustomizePrehistoricPBJ(browm));

            }
        }
        //private void SelectPrehistoric(object sender, RoutedEventArgs args)
        //{
        //    if (DataContext is Order order)
        //    {
        //        PrehistoricPBJ pbj = new PrehistoricPBJ();
        //        order.Add(pbj);
        //        NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));

        //    }
        //}

    }
}
