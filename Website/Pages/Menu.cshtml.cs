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
        public static List<Entree> Search(List<Entree> entree, string searchString)
        {
            List<Entree> res = new List<Entree>();
            foreach (Entree entre in entree)
            {
                if (entre.ToString() != null && entre.ToString().Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                {
                    res.Add(entre);
                }
            }
            return res;
        }
    }
}