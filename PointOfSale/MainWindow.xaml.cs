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
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            order.Item.Add(new Fryceritops());
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = DinoDiner.Menu.Size.Medium;
            order.Item.Add(new Tyrannotea());
            //Order order = new Order();
            //OrderList.DataContext = order;
            //OrderInterface.DataContext = order;
        }
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContetext();
        }

        public void OnDataContextChanged(object sender , DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContetext();

        }

        public void SetFrameDataContetext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderInterface.DataContext;
        }
    }
}
