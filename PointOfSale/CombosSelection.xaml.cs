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
    }
}
