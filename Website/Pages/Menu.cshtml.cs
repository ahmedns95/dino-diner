using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        public List<IMenuItem> Items { get; set; }
        [BindProperty]
        public float? minPrice { get; set; }
        [BindProperty]
        public float? maxPrice { get; set; }
        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        public void OnGet()
        {
            Items = Menu.AvailableMenuItems;
        }
        public void OnPost()
        {
            Items = Menu.AvailableMenuItems;

            if (search != null)
            {
                Items = Menu.Search(Items,search);
            }
            if (menuCategory.Count != 0)
            {
                Items = Menu.ApplyFilter(Items, menuCategory);
            }
            if(minPrice!=null && maxPrice != null)
            {
                Items = Menu.FilterByMinPrice(Items,(float)minPrice, (float)maxPrice);
            }else if(minPrice == null && maxPrice== null)
            {
                Items = Menu.FilterByMinPrice(Items, 0, 100);
            }else if(maxPrice == null)
            {
                Items = Menu.FilterByMinPrice(Items, (float)minPrice , 100);
            }
            else if(minPrice ==null)
            {
                Items = Menu.FilterByMinPrice(Items, 0, (float)maxPrice);
            }
            if(excludeIngredient != null)
            {
                Items = Menu.FilterByIngridients(Items, excludeIngredient);
            }
        }
    }
}