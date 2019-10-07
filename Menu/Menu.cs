using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu 
    {

        public List<IMenuItem> AvailableMenuItems {
            get
            {
                List<IMenuItem> avaiMenuItems = new List<IMenuItem>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ(),
                    new JurrasicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return avaiMenuItems;
            }
        }
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> avaiEntree = new List<IMenuItem>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
                return avaiEntree;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> avaiSides = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return avaiSides;
            }
        }

        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> avaiDrinks = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return avaiDrinks;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> avaiCombos = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return avaiCombos;
            }
        }

        public override string ToString()
        {

            return "Brontowurst Combo Dino-Nuggets Combo";
             //   "\" +
              //  "Prehistoric PB&J Combo\" +
              //  "Pterodactyl Wings Combo\" +
              //  "Steakosaurus Burger Combo\";
                
        }

    }
}
