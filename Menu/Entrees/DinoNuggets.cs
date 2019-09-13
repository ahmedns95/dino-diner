using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entree
{
    public class DinoNuggets
    {

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
             get
             {
                  List<string> ingredients = new List<string>() { "6 chicken nuggets" };
                  //if (bun) ingredients.Add("Whole Wheat Bun");
                  return ingredients;
                }
            }

        public DinoNuggets()
        {
             this.Price = 4.25;
             this.Calories = 59;
        }

        public void AddAdditionalNugget()
        {

        }



    }
}
