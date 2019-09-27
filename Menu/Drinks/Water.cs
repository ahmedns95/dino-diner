using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool lemon = false;

        public Water()
        {
            this.ingredients.Add("water");
            if (lemon) ingredients.Add("Lemon");
        }

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
    }
}
