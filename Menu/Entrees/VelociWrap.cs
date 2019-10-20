using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class VelociWrap : Entree , INotifyPropertyChanged
    {
     
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;
        /// <summary>
        /// Event Handeler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldCheese()
        {
            this.cheese = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!lettuce)
                {
                    special.Add("Hold Lettuce");
                }
                if (!dressing)
                {
                    special.Add("Hold Dressing");
                }
                if (!cheese)
                {
                    special.Add("Hold Cheese");
                }
                return special.ToArray();
            }
        }
    }
}
