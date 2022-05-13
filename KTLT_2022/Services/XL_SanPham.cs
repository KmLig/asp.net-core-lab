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

        public static SANPHAM? DocSanPham(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            List<SANPHAM> dssp = LuuTruSanPham.DocDanhSachSanPham();
            foreach(SANPHAM sp in dssp)
            {
                if(sp.MaSP == id)
                {
                    return sp;
                }
            }
            return null;
        }
        public static bool SuaSanPham(string id, string tenSP, int giaSP)
        {
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tenSP) || giaSP <= 0)
            {
                return false;
            }
            SANPHAM? sp = DocSanPham(id);
            if (sp != null)
            {
                SANPHAM spMoi;
                spMoi.MaSP = id;
                spMoi.TenSP = tenSP;
                spMoi.GiaSP = giaSP;
                LuuTruSanPham.Sua(spMoi);
                return true;
            }            
            return false;
        }

        public static bool XoaSanPham(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }
            SANPHAM? sp = DocSanPham(id);
            if (sp != null)
            {
                LuuTruSanPham.Xoa(id);
                return true;
            }
            return false;
        }
    }
}
