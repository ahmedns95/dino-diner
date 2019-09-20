using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        protected double price;
        protected uint calories;
        protected List<string> ingredients;
        protected Size size;
        public Fryceritops(double price, uint calories, List<string> ingredients, Size size) : base(price, calories, ingredients, size)
        {
            this.Price = price;
            this.Calories = calories;
          //  this.Ingredients = ingredients;
            this.Size = size;
        }

        public virtual void Course(double price, uint calories, List<string> ingredients, Size size)
        {
            switch (price) {
                case size.
            }

        }
    }


}