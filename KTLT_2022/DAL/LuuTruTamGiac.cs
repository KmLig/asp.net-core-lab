using KTLT_2022.Entities;
using Newtonsoft.Json;

namespace KTLT_2022.DAL
{
    public class LuuTruTamGiac
    {
        public static void Luu_File(TAMGIAC t)
        {
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\TamGiac.txt");
            file.WriteLine($"{t.a.X}, {t.a.Y}");
            file.WriteLine($"{t.b.X}, {t.b.Y}");
            file.WriteLine($"{t.c.X}, {t.c.Y}");
            file.Close();
        }

        public static void Luu(TAMGIAC t)
        {
            StreamWriter file = new StreamWriter("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\TamGiac.json");
            string json = JsonConvert.SerializeObject(t);
            file.WriteLine(json);
            file.Close();
        }

        public static TAMGIAC Doc_File()
        {
            TAMGIAC t;
            StreamReader file = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\TamGiac.txt");
            string s = file.ReadLine();
            t.a = LuuTruDiem.KhoiTaoDiem(s);
            s = file.ReadLine();
            t.b = LuuTruDiem.KhoiTaoDiem(s);
            s = file.ReadLine();
            t.c = LuuTruDiem.KhoiTaoDiem(s);

            file.Close();
            return t;
        }
        public static TAMGIAC Doc()
        {
            TAMGIAC t;
            StreamReader file = new StreamReader("D:\\CN-CNTT-FS\\HK2\\Kỹ thuật lập trình\\KTLT\\Lưu\\TamGiac.json");
            string s = file.ReadToEnd();
            t = JsonConvert.DeserializeObject<TAMGIAC>(s);           

            file.Close();
            return t;
        }
    }
}
