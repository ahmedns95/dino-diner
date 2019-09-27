using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {

        protected double price;
        protected uint calories;
        protected List<string> ingredients = new List<string>();
        protected bool ice = true;
        protected Size size = Size.Small;

       
        /// <summary>
        /// 
        /// </summary>
        public void HoldIce()
        {
            this.ice = false;
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
    }
}
