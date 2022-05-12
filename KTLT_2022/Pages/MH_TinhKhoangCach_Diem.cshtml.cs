using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;

namespace KTLT_2022.Pages
{
    public class MH_TinhKhoangCach_DiemModel : PageModel
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
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            DIEM A, B;
            A.X = X1;
            A.Y = Y1;
            B.X = X2;
            B.Y = Y2;
            double kc = XL_Diem.TinhKhoangCach(A, B);
            Chuoi = $"Ket qua la: {kc}";
        }
    }
}
