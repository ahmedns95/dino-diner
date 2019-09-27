using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;


namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }

        public Side Side { get; set; }

        public Drink Drink { get; set; }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories ;
            }
        }
        private Size size = Size.Small;

        public Size Size
        {
            set
            {
                Drink.Size = value;
                Side.Size = value;
            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return Ingredients;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
        }
    }
}
