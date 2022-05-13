using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;

namespace KTLT_2022.Pages
{
    public class MH_TinhKhoangCach_DiemModel : PageModel
    {
        public DIEM A, B;
        public string? Chuoi;

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
            A.X = 1;
            A.Y = 2;
            B.X = 3;
            B.Y = 4;
        }
        public void OnPost()
        {            
            A.X = X1;
            A.Y = Y1;
            B.X = X2;
            B.Y = Y2;
            double kc = XL_Diem.TinhKhoangCach(A, B);
            Chuoi = $"Ket qua la: {kc}";
        }
    }
}
