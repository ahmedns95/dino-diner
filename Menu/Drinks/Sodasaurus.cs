using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks

{
    public class Sodasaurus : Drink
    {
       // public bool ice = true;
        private SodasaurusFlavor flavor;

        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }


        public Sodasaurus() {

            this.ingredients.Add("Water");
            this.ingredients.Add("Natural Flavors");
            this.ingredients.Add("Cane Sugar");
            this.Size = Size.Small;

        }
        public override  Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.price = 1.50;
                        this.calories = 112;
                        break;
                    case Size.Medium:
                        this.price = 2.00;
                        this.calories = 156;
                        break;
                    case Size.Large:
                        this.price = 2.50;
                        this.calories = 208;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
