using KTLT_2022.Entities;
using KTLT_2022.DAL;
namespace KTLT_2022.Services

{
    public class XL_PhanSo
    {
        public static PHANSO TinhTong(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static bool LuuPhanSo(PHANSO a)
        {
            if (a.MauSo == 0)
            {
                return false;
            }
            LuuTruPhanSo.Luu(a);
            return true;
        }
    }
}
