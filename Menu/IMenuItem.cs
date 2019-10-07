using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        double Price { get;  }
        /// <summary>
        /// 
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// 
        /// </summary>
        List<string> Ingredients { get; }
    }
}
