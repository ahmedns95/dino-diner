using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    public abstract class Side : IMenuItem ,IOrderItem, INotifyPropertyChanged
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
        protected double price;
        protected uint calories;
        protected List<string> ingredients=new List<string>();
        protected Size size;

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price {
            get {
                return price;
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
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
        public  virtual string[] Special { get; }
        public string Category { get; } = "Side";
    }
}
