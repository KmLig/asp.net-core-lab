using KTLT_2022.DAL;
using KTLT_2022.Entities;

namespace KTLT_2022.Services
{
    public class XL_DaGiac
    {
        public static DAGIAC DocDaGiac()
        {
            DAGIAC d;
            d = LuuTruDaGiac.Doc();
            return d;
        }

        public static DAGIAC KhoiTaoDaGiac(string chuoiDinh)
        {
            DAGIAC d;
            //chuoi dinh "(4,5) | (6,7) | (7,3) | (5,3)"
            string[] m = chuoiDinh.Split("|", StringSplitOptions.RemoveEmptyEntries);            
            d.DanhSachDinh = new DIEM[m.Length];
            for (int i = 0; i < m.Length; i++)
            {                
                d.DanhSachDinh[i] = XL_Diem.KhoiTao(m[i]);
            }
            return d;
        }

        public static double TinhChuVi(DAGIAC d)
        {
            double cv = 0;
            for (int i = 0; i < d.DanhSachDinh.Length - 1; i++)
            {
                cv += XL_Diem.TinhKhoangCach(d.DanhSachDinh[i], d.DanhSachDinh[i + 1]);
            }
            cv += XL_Diem.TinhKhoangCach(d.DanhSachDinh[0], d.DanhSachDinh[d.DanhSachDinh.Length - 1]);
            return cv;
        }

        public static bool LuuDaGiac(DAGIAC d)
        {
            if (d.DanhSachDinh.Length < 2)
            {
                return false;
            }
            LuuTruDaGiac.Luu(d);
            return true;
        }
    }
}
