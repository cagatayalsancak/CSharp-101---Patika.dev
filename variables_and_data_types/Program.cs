using System;

namespace variables_and_data_types
{ 
    class Program
    {
        static void Main(string[] args, string hour)
        {
            // değişkenler sayılarla ve "_" hariç sembollerle başlayamaz...
            // string 1degisken;
            string _degisken; 
            int deger = 2; // tamsayı veri tipi
            String degisken = null; // Metinsel veri tipi
            string degisKen = null;
            // string class = null; // özel isimler değişken adı olarak kullanılamaz.
            // string namespace = null;

            string degisken_veri = null; // 2 kelimeden oluşacak değişkenlerin arasına sadece "_"  konulabilir. boşluk yada "-" kullanılamaz.            

            // Tam Sayı Veri Tipleri
            byte b = 5;  // 1 byte
            sbyte bs = 5;  // 1 byte
            short s = 5;  // 2 byte
            ushort us = 5;  // 2 byte
            Int16 i16 = 5;  // 2 byte
            Int32 i32 = 5;  // 4 byte
            Int64 i64 = 2;  // 8 byte
            int i = 2;      // 4 byte
            uint ui = 2;    // 4 byte
            long l = 2;     // 8 byte
            ulong ul = 2;   // 8 byte

            float f = 2;    // 4 byte
            double d = 2;   // 8 byte
            decimal de = 2;  // 16 byte

            int i1 = 5;
            int i2 = 8;
            int i3 = i1 * i2;

            // Metinsel Veri Tipler
            char ch = '2'; // 2 byte
            string str = "Çağatay"; // sınırsız
            string str2 = string.Empty; // boş string değişkeni
            str2 = "Mehmet Çağatay ALSANCAK";
            string name = "Mehmet Çağatay";
            string surName = "ALSANCAK";
            string nameSurName = name + " " + surName;

            // bool veri tipleri true ve false değerlerini alabilir.
            bool b1 = true;
            bool b2 = false;

            bool b3 = 10>3;

            // Tarih saat veri tipi
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = false;
            object o4 = 4.2;
            object o5 = 5;

            // Veri Tipi Dönüşümleri
            string str20 = "20";
            int int20 = 22;
            string yeni_str20 = str20 + int20.ToString(); // Çıktı : 2022
            int yeni_int20 = int20 + int.Parse(str20); // Çıktı : 40
            int yeni_int21 = int20 + Convert.ToInt32(str20); // Çıktı : 40

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // Çıktı : 15.02.2022
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); // Çıktı : 15/02/2022

            string hours = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Hello World!");
        }
    }
}
