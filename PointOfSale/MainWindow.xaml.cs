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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NavigationService NavigationService { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            //order = (Order)DataContext;
            DataContext = order;
            OrderItems.NavigationService = OrderUI.NavigationService;
        }
        private void PassDataContentToPage()
        {
            if (OrderUI.Content is FrameworkElement page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }
        private void OnLoadCompleted(object sender, EventArgs args)
        {
            PassDataContentToPage();
        }
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
        private void SlectReturn(object sender, RoutedEventArgs args)
        {
            //OrderItems.Navigate(new OrderItems());//???
            //NavigationService.Navigate(new CustomizeCombo());

        }
    }
}
