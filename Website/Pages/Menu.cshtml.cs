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
        //[BindProperty]
        public List<Entree> Entrees { get; set; }
        //[BindProperty]
        public List<Side> Sides { get; set; }
        //[BindProperty]
        public List<Drink> Drinks { get; set; }
        //[BindProperty]
        public List<CretaceousCombo> Combos { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        public List<IMenuItem> Items { get; set; } 
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
                Items = Menu.AplyFilter(Items,menuCategory);
            }

        }
    }
}