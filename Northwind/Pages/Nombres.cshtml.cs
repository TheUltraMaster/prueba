using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SampleDataLibrary.Data;

namespace NorthwindM.Pages
{
    public class NombresModel : PageModel
    {

        public List<Category>? categorias { get; set;}
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web - Categorias";
            using (SampleDataLibrary.Data.Northwind db = new())
            {
                categorias = db.Categories.ToList();
              
            }
        }
    }
}
