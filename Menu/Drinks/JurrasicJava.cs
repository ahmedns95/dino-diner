﻿/*
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
    public class JurrasicJava : Drink ,IMenuItem
    {
        /// <summary>
        /// properties RoomForCream 
        /// </summary>
        public bool roomForCream = false;
        /// <summary>
        /// properties Decaf 
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// propertie for LeaveRoomForCream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
        }
        /// <summary>
        /// method to AddIce
        /// </summary>
        public void AddICe()
        {
            this.Ice = true;
        }
        public override string ToString()
        {
            if (Decaf)
            {
                return size + " Decaf Jurassic Java";
            }
            else
            {
                return size + " Jurassic Java";
            }
        }
        /// <summary>
        /// Constructor for JurrasicJava
        /// Adds the ingredients
        /// </summary>
        public JurrasicJava()
        {
            this.Ingredients.Add("Water");
            this.Ingredients.Add("Coffee");
            this.Ice = false;
            this.Size = Size.Small;
        }
        /// <summary>
        /// method of type Size to set the price and the calories according to the size
        /// </summary>
        public override Size Size{
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
    }
}
