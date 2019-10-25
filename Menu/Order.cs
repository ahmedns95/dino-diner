using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// property for the item
        /// </summary>
        public ObservableCollection<IOrderItem> Item { get; set; } = new ObservableCollection<IOrderItem>(); 
        /// <summary>
        /// property for the subtotal cost
        /// </summary>
        public double SubtotalCost {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem item in Item)
                {
                    subTotal += item.Price;
                }
                return Math.Max(subTotal,0);
            }
        }
        /// <summary>
        /// property for sales tax rate
        /// </summary>
        //public double SalesTaxRate { get; protected set; }
        public double SalesTaxRate { get; protected set; }=0;
        /// <summary>
        /// property for sale tax Cost
        /// </summary>
        public double SalesTaxCost {
            get
            {
                return SalesTaxCost * SubtotalCost;
            }
        }
        /// <summary>
        /// property for the total cost
        /// </summary>
        public double TotalCost {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
        public Order()
        {
            Item = new ObservableCollection<IOrderItem>();

            Item.Add(new SteakosaurusBurger());
            Item.Add(new Fryceritops()); 

        }
        private void OnCollectionChanges(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SAlestax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
