using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu 
    {

        public List<string> AvailableMenuItems {

            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return Ingredients;
            }
        }
        public List<string> AvailableEntrees
        {
            get
            {
                List<IMenuItem> ingredients = new List<IMenuItem>();
                ingredients.AddRange(Side.ingredients);
                ingredients.AddRange(Drink.AvailableMenuItems);
                return AvailableMenuItems;
            }
        }
    }
}
