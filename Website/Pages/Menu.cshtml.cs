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
        public Entree Entree { get; } 
        public void OnGet()
        {
        }
        public static List<IMenuItem> Search(List<IMenuItem> entree, string searchString)
        {
            List<IMenuItem> res = new List<IMenuItem>();
            foreach (Entree entr in entree)
            {
                if (entr.ToString() != null && entr.ToString().Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                {
                    res.Add(entr);
                }
            }
            return res;
        }
        public static List<IMenuItem> FilterBySide(List<IMenuItem> menu, List<string> side)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (Side sidee in menu)
            {
                if (side.Contains(sidee.ToString()))
                {
                    result.Add(sidee);
                }
            }
            return result;
        }
    }
}