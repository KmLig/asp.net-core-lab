using KTLT_2022.Entities;
using KTLT_2022.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT_2022.Pages
{
    public class MH_TinhChuVi_DaGiacModel : PageModel
    {
        public DAGIAC d;
        public string? Chuoi;
        [BindProperty]
        public string? ChuoiDaGiac { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            ChuoiDaGiac = "(4,5)|(6,7)|(7,3)|(5,3)";
            d = XL_DaGiac.KhoiTaoDaGiac(ChuoiDaGiac);

        }
        public void OnPost()
        {
            d = XL_DaGiac.KhoiTaoDaGiac(ChuoiDaGiac);
            double kq = XL_DaGiac.TinhChuVi(d);
            Chuoi = $"Ket qua la {kq}";            
        }
    }
}
