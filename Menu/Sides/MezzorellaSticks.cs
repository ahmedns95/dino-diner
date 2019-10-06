using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks() 
        {
            this.Ingredients.Add("Breading");
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;

        }
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
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