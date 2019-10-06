using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {

        private uint nuggetCount = 6;
        public override List<string> Ingredients
        {
             get
             {
                List<string> ingredients = new List<string>();
                for (int i=0; i< nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                  return ingredients;
             }
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        public DinoNuggets()
        {
             this.Price = 4.25;
             this.Calories = 59*nuggetCount;
        }

        public void AddNugget()
        {
            nuggetCount++;
            this.Price += 0.25;
            this.Calories += 59;
        }



    }
}
