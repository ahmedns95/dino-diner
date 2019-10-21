using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// property for the item
        /// </summary>
        public ObservableCollection<IOrderItem> Item { get; set; } = new ObservableCollection<IOrderItem>(); 
        /// <summary>
        /// property for the subtotal cost
        /// </summary>
        public double SubtotalCost {
            get;
        }
        /// <summary>
        /// property for sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }
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
    }
}
