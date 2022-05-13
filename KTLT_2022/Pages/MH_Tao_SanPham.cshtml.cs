using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;


namespace KTLT_2022.Pages
{
    public class MH_Tao_SanPhamModel : PageModel
    {
        public SANPHAM A;
        public string? Chuoi;
        [BindProperty]
        public string? MaSP { get; set; }
        [BindProperty]
        public string? TenSP { get; set; }
        [BindProperty]
        public int GiaSP { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
            A.MaSP = "001";
            A.TenSP = "Sneaker";
            A.GiaSP = 20000;
        }
        public void OnPost()
        {
            A.MaSP = MaSP;
            A.TenSP = TenSP;
            A.GiaSP = GiaSP;
            bool kq = XL_SanPham.TaoSanPham(A);
            Chuoi = $"Ket qua la: {kq}";
        }
    }
}
