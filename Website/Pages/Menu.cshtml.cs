using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using System.Collections;

namespace Website.Pages
{
    public class MenuModel : PageModel 
    {
        public Menu Menu { get; } = new Menu();
        public IEnumerable<IMenuItem> Items;
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? minPrice { get; set; }
        [BindProperty]
        public float? maxPrice { get; set; }
        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        public void OnGet()
        {
            Items = Menu.AvailableMenuItems.OrderBy(menuItem => menuItem.Category);

        }
        public void OnPost()
        {
            Items = Menu.AvailableMenuItems;

            if (search != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.Contains(Items, search));
                //Items = Menu.Search(Items,search);
            }
            if (menuCategory.Count != 0)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuCategory.Contains(menuItem.Category));
                //Items = Menu.ApplyFilter(Items, menuCategory);
            }
            //if(minPrice!=null && maxPrice != null)
            //{
            //    //Items = Menu.FilterByMinPrice(Items,(float)minPrice, (float)maxPrice);
            //}else if(minPrice == null && maxPrice== null)
            //{
            //    //Items = Menu.FilterByMinPrice(Items, 0, 100);
            //}
            if(maxPrice != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.Price >= minPrice);
                //Items = Menu.FilterByMinPrice(Items, (float)minPrice , 100);
            }
            else if(minPrice != null)
            {
                Items = Menu.AvailableMenuItems.Where(menuItem => menuItem.Price <= maxPrice);
            }
            if (excludeIngredient != null)
            {
                foreach(string s in excludeIngredient)
                {
                    Items = Menu.AvailableMenuItems.Where(menuItem => !menuItem.Ingredients.Contains(s));

                }
            }
        }
    }
}