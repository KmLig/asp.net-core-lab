using KTLT_2022.Entities;
using Newtonsoft.Json;

namespace KTLT_2022.DAL
{
    public class LuuTruSanPham
    {
        public static bool Luu(SANPHAM A)
        {
            List<SANPHAM> danhSachSanPham = DocDanhSachSanPham();
            danhSachSanPham.Add(A);
            LuuDanhSachSanPham(danhSachSanPham);

            return true;
        }

        public static List<SANPHAM> DocDanhSachSanPham()
        {
            StreamReader reader = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\SanPham.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<SANPHAM> danhSachSanPham = JsonConvert.DeserializeObject<List<SANPHAM>>(jsonString);
            return danhSachSanPham;
        }

        public static bool LuuDanhSachSanPham(List<SANPHAM> danhSachSanPham)
        {
            StreamWriter writer = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\SanPham.json");
            string jsonString = JsonConvert.SerializeObject(danhSachSanPham);
            writer.WriteLine(jsonString);
            writer.Close();

            return true;
        }

        public static bool Sua(SANPHAM s)
        {
            List<SANPHAM> dssp = DocDanhSachSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSP == s.MaSP)
                {
                    dssp[i] = s;
                    LuuDanhSachSanPham(dssp);
                    return true;
                }
            }
            return false;
        }

        public static bool Xoa(string id)
        {
            List<SANPHAM> dssp = DocDanhSachSanPham();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSP == id)
                {
                    dssp.RemoveAt(i);
                    LuuDanhSachSanPham(dssp);
                    return true;
                }
            }
            return false;
        }
    }
}
