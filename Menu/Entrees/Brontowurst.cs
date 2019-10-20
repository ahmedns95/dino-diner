using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree ,INotifyPropertyChanged
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        ///// <summary>
        ///// Event Handeler for PropertyChanged events
        ///// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="propertyName"></param>
        //protected void NotifyPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        public override string ToString()
        {
            return "Brontowurst";
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            
        }

        public void HoldBun()
        {
            this.bun = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldOnion()
        {
            this.onions = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun)
                {
                    special.Add("Hold Whole Wheat Bread");
                }
                if (!peppers)
                {
                    special.Add("Hold Peppers");
                }
                if (!onions)
                {
                    special.Add("Hold Onions");
                }
                return special.ToArray();
            }
        }
    }
}
