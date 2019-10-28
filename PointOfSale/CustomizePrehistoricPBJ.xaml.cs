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
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;// you need this. here 
        }

        private void SlectHoldPeanutButter(object sender , RoutedEventArgs args)
        {
            this.pbj.HoldJelly();
        }
        private void SlectHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        private void SlectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();

        }
    }
}
