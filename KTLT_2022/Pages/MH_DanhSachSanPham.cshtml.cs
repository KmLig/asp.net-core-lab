using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;


namespace KTLT_2022.Pages
{
    public class MH_DanhSachSanPhamModel : PageModel
    {
        public List<SANPHAM> dsSanPham;
        
        [BindProperty]
        public string? TuKhoa { get; set; }
        
        public void OnGet()
        {
            dsSanPham = XL_SanPham.TimKiem(string.Empty);
        }
        public void OnPost()
        {
            dsSanPham = XL_SanPham.TimKiem(TuKhoa);
        }
    }
}
