using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree,IMenuItem
    {

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories =318;
        }
    }
}
