using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        public MeteorMacAndCheese() 
        {
            this.Ingredients.Add("Macaroni Noodles");
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Pork Sausuage");
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
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}