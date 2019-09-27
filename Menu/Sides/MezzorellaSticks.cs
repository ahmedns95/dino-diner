using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;


namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks() 
        {
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Breading");
            this.Ingredients.Add("Vegtable Oil");
            this.Size = Size.Small;

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
            }

        }
    }
}