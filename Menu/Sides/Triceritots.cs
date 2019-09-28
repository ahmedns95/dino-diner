using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
              this.Ingredients.Add("Potato");
              this.Ingredients.Add("Salt");
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
            }
        }
    }
}