/*
 * Sodasaurus.cs
 * Author:Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu

{
    /// <summary>
    /// Class Sodasaurus thats inherits for the drinks base class
    /// </summary>
    public class Sodasaurus : Drink ,IMenuItem
    {
        /// <summary>
        /// Gets or sets the flavor property
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// property of Flavor of type SodasaurusFlavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        public override string ToString()
        {
            return size +" "+ flavor + " Sodasaurus";
        }
        /// <summary>
        /// Constructor for Sodasaurus
        /// Adds the ingredients
        /// </summary>
        public Sodasaurus() {
            this.Ice = true;
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// method of type Size to set the price and the calories according to the size
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
                        this.price = 1.50;
                        this.calories = 112;
                        break;
                    case Size.Medium:
                        this.price = 2.00;
                        this.calories = 156;
                        break;
                    case Size.Large:
                        this.price = 2.50;
                        this.calories = 208;
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public override string Description
        {
            get { return size.ToString(); }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");

                return special.ToArray();
            }
        }
    }
}

