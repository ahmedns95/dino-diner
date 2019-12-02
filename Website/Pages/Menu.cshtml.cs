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
        public List<Entree> Entrees { get; set; }
        public List<Side> Sides { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<CretaceousCombo> Combos { get; set; }

        public List<IMenuItem> items { get; set; } 
        public void OnGet()
        {
            items = Menu.AvailableMenuItems;
        }
        public void OnPost()
        {
            if (search != null)
            {
                items = Menu.Search(items, search);
            }

        }
    }
}