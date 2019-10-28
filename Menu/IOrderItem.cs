/*IOrderItem.cs
 * Author : Ahmed Alnassar
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Price (double) property
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Description (string) property
        /// </summary>
        string  Description { get; }
        /// <summary>
        /// Special (string[]) property
        /// </summary>
        string[]  Special { get; }
    }
}
