using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT_2022.Entities;
using KTLT_2022.Services;

namespace KTLT_2022.Pages
{
    public class MH_SuaSanPhamModel : PageModel
    {
        public SANPHAM SanPham;
        public string Chuoi;
        public bool coSanPham;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string TenSP { get; set; }
        [BindProperty]
        public int GiaSP { get; set; }
        public void OnGet()
        {
            SANPHAM? sp = XL_SanPham.DocSanPham(Id);
            if (sp != null)
            {
                SanPham = sp.Value;
            }
            else
            {
                SanPham = new SANPHAM(); // co the bo
                Chuoi = "Khong tim thay san pham";
            }
            coSanPham = (sp != null);
        }
        public void OnPost()
        {
            bool kq = XL_SanPham.SuaSanPham(Id, TenSP, GiaSP);
            Chuoi = $"Ket qua la {Id},{TenSP},{GiaSP}, {kq}";
            //quay lai man hinh danh sach san pham
            Response.Redirect("/MH_DanhSachSanPham");
        }
    }
}
