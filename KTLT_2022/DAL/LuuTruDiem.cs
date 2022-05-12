using KTLT_2022.Entities;
using Newtonsoft.Json;

namespace KTLT_2022.DAL
{
    public class LuuTruDiem
    {
        public static void Luu_File(DIEM a)
        {
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Diem.txt");
            file.WriteLine($"{a.X},{a.Y}");
            file.Close();
        }
        public static void Luu(DIEM a)
        {
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Diem.json");
            string json = JsonConvert.SerializeObject(a);
            file.WriteLine(json);
            file.Close();
        }

        public static DIEM Doc_File()
        {
            DIEM a;
            StreamReader file = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Diem.txt");
            string s = file.ReadLine();            
            a = KhoiTaoDiem(s);
            file.Close();
            return a;
        }
        public static DIEM Doc()
        {
            DIEM a;
            StreamReader file = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\Diem.json");
            string json = file.ReadToEnd();
            a = JsonConvert.DeserializeObject<DIEM>(json);
            file.Close();
            return a;
        }

        public static DIEM KhoiTaoDiem(string s)
        {
            DIEM a;
            string[] m = s.Split(',');
            a.X = int.Parse(m[0]);
            a.Y = int.Parse(m[1]);
            return a;
        }
    }
}
