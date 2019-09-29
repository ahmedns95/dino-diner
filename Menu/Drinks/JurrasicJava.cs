using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool roomForCream = false;
        public bool decaf = false;

        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
        }
        public void AddICe()
        {
            this.Ice = true;
        }

        public JurrasicJava()
        {
            this.ingredients.Add("Water");
            this.ingredients.Add("Coffee");
            this.Ice = false;
            this.Size = Size.Small;
        }

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
