using KTLT_2022.Entities;
using Newtonsoft.Json;

namespace KTLT_2022.DAL
{
    public class LuuTruPhanSo
    {
        

        public static void Luu_File(PHANSO a)
        {
            //code luu phan so a xuong tap tin
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Phanso.txt");
            file.WriteLine($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
        public static void Luu(PHANSO a)
        {
            //code luu phan so a xuong tap tin
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Phanso.json");
            string json = JsonConvert.SerializeObject(a);
            file.WriteLine(json);
            file.Close();
        }
    }
}
