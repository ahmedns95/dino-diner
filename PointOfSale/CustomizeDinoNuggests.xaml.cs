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
    /// Interaction logic for CustomizeDinoNuggests.xaml
    /// </summary>
    public partial class CustomizeDinoNuggests : Page
    {
        private DinoNuggets nug;
        public CustomizeDinoNuggests(DinoNuggets nug)
        {
            InitializeComponent();
            this.nug = nug;
        }
        private void SlectAddNuggets(object sender, RoutedEventArgs args)
        {
            nug.AddNugget();
        }
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
