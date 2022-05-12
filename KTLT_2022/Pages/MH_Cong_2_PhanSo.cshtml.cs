using KTLT_2022.Entities;
using KTLT_2022.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT_2022.Pages
{
    public class MH_Cong_2_PhanSoModel : PageModel
    {
        public string? Chuoi { get; set; }
        [BindProperty]
        public int Tu1 { get; set; }
        [BindProperty]
        public int Mau1 { get; set; }
        [BindProperty]
        public int Tu2 { get; set; }
        [BindProperty]
        public int Mau2 { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;            
        }

        public void OnPost()
        {
            PHANSO A, B;
            A.TuSo = Tu1;
            A.MauSo = Mau1;
            B.TuSo = Tu2;
            B.MauSo = Mau2;
            PHANSO s = XL_PhanSo.TinhTong(A, B);
            Chuoi = $"Ket qua là: {s.TuSo}/{s.MauSo}";
        }
    }
}
