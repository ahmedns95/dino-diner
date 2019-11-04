﻿using System;
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
        private void SelectBrontowrst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst browm = new Brontowurst();
                order.Add(browm);
                NavigationService.Navigate(new CustomizeBrontowurst(browm));
            }
        }
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nug = new DinoNuggets();
                order.Add(nug);
                NavigationService.Navigate(new CustomizeDinoNuggests(nug));
            }
        }
    }
}
