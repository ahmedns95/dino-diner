using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Tyrannotea thats inherits for the drinks base class
    /// </summary>
    public class Tyrannotea : Drink , IMenuItem
    {
        /// <summary>
        /// Gets or sets the sweet property 
        /// </summary>
        public bool Sweet = false;
        /// <summary>
        /// Gets or sets the lemon property 
        /// </summary>
        public bool lemon = false;
        /// <summary>
        /// Constructor Tyrannotea thats add the ingredients 
        /// and check if lemon or sweet is added
        /// </summary>
        public Tyrannotea()
        {
            
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                
                return ingredients;
            }
        }
        public override string ToString()
        {
            if(Sweet) return size + " Sweet Tyrannotea";
            else return size + " Tyrannotea";
        }
        /// <summary>
        /// method to add lemon
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
            NotifyPropertyChanged("special");
        }
        /// <summary>
        /// method of type Size to set the price and the calories according to the size
        /// And if sweet is added double the calories
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
                        this.price = 0.99;
                        this.calories = 8;
                        if (Sweet)
                        {
                            this.calories = 16;
                        }
                        break;
                    case Size.Medium:
                        this.price = 1.49;
                        this.calories = 16;
                        if (Sweet)
                        {
                            this.calories = 32;
                        }
                        break;
                    case Size.Large:
                        this.price = 1.99;
                        this.calories = 32;
                        if (Sweet)
                        {
                            this.calories = 64;
                        }
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
            get {
                List<string> description = new List<string>();
                if (Sweet)
                {
                    description.Add("Sweet");
                }
                return size.ToString();
            }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (lemon)
                {
                    special.Add("Add Lemon");
                }
                if (!ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }



    }
}
