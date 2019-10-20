using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree ,INotifyPropertyChanged
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

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
                List<string> ingredients = new List<string>() ;
                for (int i =0; i < 3; i++){
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.bun = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldOnion()
        {
            this.onion = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        public void HoldTomato()
        {
            this.tomato = false;
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
                if (!lettuce)
                {
                    special.Add("Hold Lettuce");
                }
                if (!tomato)
                {
                    special.Add("Hold Tomato");
                }
                if (!onion)
                {
                    special.Add("Hold Onion");
                }
                if (!pickle)
                {
                    special.Add("Hold Pickle");
                }
                if (!ketchup)
                {
                    special.Add("Hold Ketchup");
                }
                if (!mustard)
                {
                    special.Add("Hold Mustard");
                }
                if (!mayo)
                {
                    special.Add("Hold Mayo");
                }
                return special.ToArray();
            }
        }
    }
}
