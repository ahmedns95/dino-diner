/*MezzorellaSticks.cs
 *Author: Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// method to get the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }
        /// <summary>
        /// constructor to set size to small
        /// </summary>
        public MezzorellaSticks() 
        {
            
            this.Size = Size.Small;

        }
        /// <summary>
        /// override toString to return the string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }
        /// <summary>
        /// method to gets the size and set the price and calories 
        /// </summary>
        public override Size Size
        {
            set
            {
                base.size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                    default:
                        break;
                }
                NotifyPropertyChanged("Description");

            }

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
                return special.ToArray();
            }
        }
    }
}