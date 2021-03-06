using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;

namespace KTLT_2022.Pages
{
    public class MH_Luu_TamGiacModel : PageModel
    {
        public string? Chuoi { get; set; }
        [BindProperty]
        public int X1 { get; set; }
        [BindProperty]
        public int Y1 { get; set; }
        [BindProperty]
        public int X2 { get; set; }
        [BindProperty]
        public int Y2 { get; set; }
        [BindProperty]
        public int X3 { get; set; }
        [BindProperty]
        public int Y3 { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            TAMGIAC t;
            t.A.X = X1;
            t.A.Y = Y1;
            t.B.X = X2;
            t.B.Y = Y2;
            t.C.X = X3;
            t.C.Y = Y3;
            bool kq = XL_TamGiac.LuuTamGiac(t);
            Chuoi = $"Luu thanh cong: {kq}";
        }
    }
}
