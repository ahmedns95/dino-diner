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

            this.Ingredients.Add("Water");
            this.Ingredients.Add("Natural Flavors");
            this.Ingredients.Add("Cane Sugar");
            this.Size = Size.Small;
        }
        /// <summary>
        /// method of type Size to set the price and the calories according to the size
        /// </summary>
        public override  Size Size
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
    }
}
