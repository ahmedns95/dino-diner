/*
 * JurrasicJava.cs
 * Author: Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class JurrasicJava thats inherits for the drinks base class
    /// </summary>
    public class JurrasicJava : Drink, IOrderItem
    {
        /// <summary>
        /// properties RoomForCream
        /// </summary>
        public bool roomForCream = false;
        /// <summary>
        /// properties Decaf
        /// </summary>
        public bool decaf = false;
        /// <summary>
        /// propertie for LeaveRoomForCream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
        }
        ///// <summary>
        ///// method to AddIce
        ///// </summary>
        //public void AddICe()
        //{
        //    this.Ice = true;//////////////
        //}
        public override string ToString()
        {
            if (decaf)
            {
                return size + " Decaf Jurassic Java";
            }
            else
            {
                return size + " Jurassic Java";
            }
        }
        public void AddDecaf()
        {
            this.decaf = true;
            NotifyPropertyChanged("Special");
            NotifyPropertyChanged("Description");
        }
        /// <summary>
        /// Constructor for JurrasicJava
        /// Adds the ingredients
        /// </summary>
        public JurrasicJava()
        {

            //this.Ice = false;/////////////
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }
        /// <summary>
        /// method of type Size to set the price and the calories according to the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.price = .59;
                        this.calories = 2;
                        break;
                    case Size.Medium:
                        this.price = .99;
                        this.calories = 4;
                        break;
                    case Size.Large:
                        this.price = 1.49;
                        this.calories = 8;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Gets a descripting of the order item
        /// </summary>
        public override string Description
        {
            get
            {
                List<string> description = new List<string>();
                if (decaf)
                {
                    description.Add("Decaf");
                }
                return this.ToString();
            }
        }
        /// <summary>
        /// gets the special of the order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                return special.ToArray();
            }
        }
    }
}