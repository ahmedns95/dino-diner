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

        private List<IOrderItem> items = new List<IOrderItem>();

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
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }        
        /// <summary>
        /// property for the subtotal cost
        /// </summary>
        public double SubtotalCost {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subTotal += item.Price;
                }
                return Math.Max(subTotal,0);
            }
        }
        double salesTaxRate = .1;

        /// <summary>
        /// property for sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = .1;
        //double salesTaxRate = 1;

        /// <summary>
        /// property for sale tax Cost
        /// </summary>
        public double SalesTaxCost {
            get
            {
                return SalesTaxRate * SubtotalCost;
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
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /// <summary>
        /// adds to the order list
        /// </summary>
        /// <param name="item">gets the item</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// remove from the order list
        /// </summary>
        /// <param name="item">gets the item</param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool remove = items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            return remove;
        }
    }
}
