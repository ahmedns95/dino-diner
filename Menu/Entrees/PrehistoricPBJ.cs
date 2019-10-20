using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree ,IMenuItem ,INotifyPropertyChanged, IOrderItem
    {
        private bool peanutButter = true;
        private bool jelly = true;
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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyPropertyChanged("Ingredients");
            NotifyPropertyChanged("Special");
        }

        public void HoldJelly()
        {
            this.jelly = false;
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
                if (!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if (!jelly)
                {
                    special.Add("Hold Jelly");
                }
                return special.ToArray();
            }
        }
    }
}
