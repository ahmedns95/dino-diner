using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink , INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the lemon property
        /// </summary>
        public bool lemon = false;
        public bool Ice = true;
        /// <summary>
        /// Constructor for the water
        /// adds the ingredients and check if the lemon is added
        /// </summary>
        public Water()
        {
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon) ingredients.Add("Lemon");
                NotifyPropertyChanged("Special");
                NotifyPropertyChanged("Description");
                return ingredients;
            }

        }

        /// <summary>
        /// method to heold the ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
            NotifyPropertyChanged("Description");

        }
        /// <summary>
        /// to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Water";

        }
        /// <summary>
        ///
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    case Size.Medium:
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    case Size.Large:
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    default:
                        break;
                }
                NotifyPropertyChanged("Special");
                NotifyPropertyChanged("Description");
                NotifyPropertyChanged("Price");
            }
        }
        /// <summary>
        /// method to set the lemon to true if lemon added
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
            NotifyPropertyChanged("Special");
            NotifyPropertyChanged("Description");
            NotifyPropertyChanged("Ingredients");
        }


        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

    }
}