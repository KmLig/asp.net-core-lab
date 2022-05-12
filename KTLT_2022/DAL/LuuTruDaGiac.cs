using KTLT_2022.Entities;
using Newtonsoft.Json;

namespace KTLT_2022.DAL
{
    public class LuuTruDaGiac
    {
        

        public static DAGIAC Doc()
        {
            DAGIAC d;
            StreamReader file = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\DaGiac.txt");
            string s = file.ReadLine();
            int n = int.Parse(s);
            d.DanhSachDinh = new DIEM[n];
            for(int i = 0; i < n; i++)
            {
                s = file.ReadLine();
                d.DanhSachDinh[i] = LuuTruDiem.KhoiTaoDiem(s);
            }            

            file.Close();

            return d;
        }

        public static bool Luu_File(DAGIAC d)
        {
            StreamWriter writer = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\DaGiac.txt");
            writer.WriteLine(d.DanhSachDinh.Length);
            for(int i = 0;i < d.DanhSachDinh.Length; i++)
            {
                writer.WriteLine($"{d.DanhSachDinh[i].X},{d.DanhSachDinh[i].Y}");
            }
            writer.Close();
            return true;
        }

        public static bool Luu(DAGIAC d)
        {
            StreamWriter writer = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\DaGiac.json");
            string json = JsonConvert.SerializeObject(d);
            writer.WriteLine(json);
            
            writer.Close();
            return true;
        }

    }
}
