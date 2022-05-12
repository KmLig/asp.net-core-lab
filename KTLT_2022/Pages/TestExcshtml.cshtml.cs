using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT_2022.Pages
{
    public class TestExcshtmlModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }    
        [BindProperty]
        public int X { get; set; }  
        public void OnGet()
        {
            Name = "Khiem";
            Age = 30;
        }
        public void OnPost()
        {
            Age = X * 10;
        }
    }
}
