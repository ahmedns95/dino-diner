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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        public Brontowurst bron;
        public  CretaceousCombo combo;
        public CustomizeBrontowurst(Brontowurst bron)
        {
            InitializeComponent();
            this.bron = bron;
        }

        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.bron = (Brontowurst)combo.Entree;
            this.combo = combo;
        }

        private void SelctHoldBun(object sender, RoutedEventArgs e)
        {
            bron.HoldBun();
        }
        private void SelectHoldPeppers(object sender, RoutedEventArgs e)
        {
            bron.HoldPeppers();
        }
        private void SelectHoldOnions(object sender, RoutedEventArgs e)
        {
            bron.HoldOnion();
        }
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if(combo != null)
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
