/* Triceritots.cs
 * Author: Ahmed Alnassar
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        /// <summary>
        /// method to get the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }
        /// <summary>
        /// constructor to set size to small
        /// </summary>
        public Triceritots()
        {
              
              this.Size = Size.Small;
        }
        /// <summary>
        /// override toString to return the string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Triceritots";
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
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                    default:
                        break;
                }
                NotifyPropertyChanged("Description");
                NotifyPropertyChanged("Special");
                NotifyPropertyChanged("Price");
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