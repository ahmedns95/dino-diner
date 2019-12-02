﻿/* Menu.cs
 * Author : Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu 
    {
        /// <summary>
        /// a property with a getter for AvailableMenuItems
        /// </summary>
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
                    new JurassicJava(),
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
        /// <summary>
        /// a property with a getter for AvailableEntrees
        /// </summary>
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
        /// <summary>
        /// a property with a getter for AvailableSides
        /// </summary>
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
        /// <summary>
        /// a property with a getter for AvailableDrinks
        /// </summary>
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
        /// <summary>
        /// a property with a getter for AvailableCombos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> avaiCombos = new List<IMenuItem>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
                return avaiCombos;
            }
        }
        public Drink Sodasaurus { get; set; } = new Sodasaurus();
        public Side Fryceritops { get; set; } = new Fryceritops();

        /// <summary>
        /// method ToString() to overide all the menu items and retunr the string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            StringBuilder st = new StringBuilder();
            foreach(IMenuItem s in AvailableMenuItems)
            {
                st.Append(s.ToString());
                st.Append("\n");
            }
            return st.ToString();
        }

        public List<IMenuItem> Search(List<IMenuItem> entree, string searchString)
        {
            List<IMenuItem> res = new List<IMenuItem>();
            
            foreach (IMenuItem entr in AvailableMenuItems)
            {
                if (entr.ToString() != null && entr.ToString().Contains(searchString))
                {
                    res.Add(entr);
                }
            }
            return res;
        }
        public  List<IMenuItem> AplyFilter(List<IMenuItem> menu, List<string> side)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem sidee in menu)
            {
                if (side.Contains(sidee.ToString()))
                {
                    result.Add(sidee);
                }
            }
            return result;
        }

    }
}
