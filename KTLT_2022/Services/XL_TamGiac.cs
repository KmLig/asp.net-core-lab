using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT_2022.Entities;
using KTLT_2022.DAL;
namespace KTLT_2022.Services
{
    public class XL_TamGiac
    {
        public static double TinhChuVi(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_Diem.TinhKhoangCach(tg.b, tg.c); 
            b = XL_Diem.TinhKhoangCach(tg.a, tg.c);
            c = XL_Diem.TinhKhoangCach(tg.a, tg.b);

            return a + b + c;
        }

        public static bool KiemTraTamGiac(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_Diem.TinhKhoangCach(tg.b, tg.c);
            b = XL_Diem.TinhKhoangCach(tg.a, tg.c);
            c = XL_Diem.TinhKhoangCach(tg.a, tg.b);

            return a + b > c && a + c > b && c + b > a;
        }
        public static bool LuuTamGiac(TAMGIAC t)
        {
            if (!KiemTraTamGiac(t))
            {
                return false;
            }
            LuuTruTamGiac.Luu(t);
            return true;
        }

        public static TAMGIAC DocTamGiac()
        {
            TAMGIAC kq;
            kq = LuuTruTamGiac.Doc();
            return kq;
        }
    }
}
