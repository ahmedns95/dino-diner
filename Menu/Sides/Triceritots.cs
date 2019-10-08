using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
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
        public Triceritots()
        {
              
              this.Size = Size.Small;
        }
        public override string ToString()
        {
            return size + " Triceritots";
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