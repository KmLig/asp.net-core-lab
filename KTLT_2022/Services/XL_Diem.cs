using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT_2022.DAL;
using KTLT_2022.Entities;
namespace KTLT_2022.Services
{
    public class XL_Diem
    {
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static bool LuuDiem(DIEM a)
        {
            LuuTruDiem.Luu(a);
            return true;
        }

        public static DIEM DocDiem()
        {
            DIEM kq;
            kq = LuuTruDiem.Doc();
            return kq;
        }
        public static DIEM KhoiTao(string chuoi)
        {
            DIEM d;
            chuoi = chuoi.Substring(1, chuoi.Length - 2); // 4,5
            string[] mDiem = chuoi.Split(",");
            d.X = int.Parse(mDiem[0]);
            d.Y = int.Parse(mDiem[1]);
            return d;
        }
    }
}
