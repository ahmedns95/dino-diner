using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        private Size size;
        public Entree Entree { get; set; }

        public Side Side { get; set; } = new Fryceritops();

        public Drink Drink { get; set; } = new Sodasaurus();

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

        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
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
            this.Entree = entree;
        }
        

    }
}
