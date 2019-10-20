using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegatable Oil");
                return ingredients;
            }
        }
        public Fryceritops() {
            this.Size = Size.Small;

        }
        public override string ToString()
        {
            return size+" Friceritops";
        }
        public override Size Size
        {
            set
            {
                base.size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    default:
                        break;
                }
            }

        }
        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public string Description
        {
            get { return size.ToString(); }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add("");
                return special.ToArray();
            }
        }


    }


}