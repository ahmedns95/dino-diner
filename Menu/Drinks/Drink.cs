/*
 * Drink.cs
 * Author: Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Drink Base Class
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// field for price
        /// </summary>
        protected double price;
        /// <summary>
        /// field for calories
        /// </summary>
        protected uint calories;
        /// <summary>
        /// field for ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// field for ice
        /// </summary>
        //protected bool ice = true;///////////////////////
        /// <summary>
        /// field for size
        /// </summary>
        protected Size size = Size.Small;
        /// <summary>
        /// property for Price
        /// </summary>
        public double Price { get { return price; } set { price = value; } }
        /// <summary>
        /// property for calories
        /// </summary>
        public uint Calories { get { return calories; } set { calories = value; } }
        /// <summary>
        /// property for ice
        /// </summary>
        //public bool Ice { get { return ice; } set { ice = value; } }////////////
        /// <summary>
        /// property for ingredients
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        ///// <summary>
        ///// method to heold the ice
        ///// </summary>
        //public void HoldIce()
        //{
        //    this.ice = false;
        //    NotifyPropertyChanged("Special");
        //    NotifyPropertyChanged("Description");/////////////////////////

        //}
        /// <summary>
        /// property to Gets and sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public virtual string Description { get; }
        public virtual string[] Special { get; }
    }
}