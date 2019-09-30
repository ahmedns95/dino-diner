using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Gets or sets the lemon property
        /// </summary>
        public bool lemon = false;
        /// <summary>
        /// Constructor for the water
        /// adds the ingredients and check if the lemon is added
        /// </summary>
        public Water()
        {
            this.ingredients.Add("Water");
            if (lemon) ingredients.Add("Lemon");
            this.Size = Size.Small;

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
                        this.price =0.10;
                        this.calories = 0;
                        break;
                    default:
                        break;
                }
            }
        }

        public void AddLemon()
        {
            this.lemon = true;
        }
       
    }
}
