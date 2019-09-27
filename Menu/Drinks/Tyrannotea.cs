using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool sweet = false;
        public bool lemon = false;


        public Tyrannotea()
        {
            this.ingredients.Add("Water");
            this.ingredients.Add("Tea");
            if(lemon)ingredients.Add("Lemon");
            if(sweet)ingredients.Add("Cane Sugar");
            this.Size = Size.Small;
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
                        this.price = 0.99;
                        this.calories = 8;
                        if (lemon)
                        {
                            this.calories = 8 * 2;
                        }
                        break;
                    case Size.Medium:
                        this.price = 1.49;
                        this.calories = 16;
                        if (lemon)
                        {
                            this.calories = 16 * 2;
                        }
                        break;
                    case Size.Large:
                        this.price = 1.99;
                        this.calories = 32;
                        if (lemon)
                        {
                            this.calories = 32 * 2;
                        }
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
