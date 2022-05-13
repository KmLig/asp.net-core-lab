using KTLT_2022.Entities;
using KTLT_2022.DAL;
namespace KTLT_2022.Services
{
    public class XL_SanPham
    {
        public static bool TaoSanPham(SANPHAM A)
        {
            // kiem tra tinh hop le cua san pham
            if (string.IsNullOrWhiteSpace(A.MaSP) || string.IsNullOrWhiteSpace(A.TenSP) || A.GiaSP <= 0)
            {
                return false;
            }
            // luu san pham            
            return LuuTruSanPham.Luu(A); 
        } 
        public static List<SANPHAM> TimKiem(string tuKhoa)
        {
            if (tuKhoa == null) tuKhoa = string.Empty;
            List<SANPHAM> dssp = LuuTruSanPham.DocDanhSachSanPham();
            List<SANPHAM> kq = new List<SANPHAM>();
            foreach(SANPHAM sp in dssp)
            {
                if (sp.TenSP.Contains(tuKhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
    }
}
