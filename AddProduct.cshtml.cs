using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public ProductInputModel Product { get; set; }

        public bool ShowResult { get; set; }

        public void OnGet()
        {
            ShowResult = false;
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                ShowResult = false;
                return;
            }

            ShowResult = true;
        }

        public class ProductInputModel
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
