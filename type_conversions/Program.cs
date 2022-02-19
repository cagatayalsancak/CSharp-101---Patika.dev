using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) -- Veri tiplerinin yüksek seviyedeki bir veri tipine otomatik dönüşme işlemi. Örnek : object veri = float+string+long
            Console.WriteLine("********** Implicit Conversion **********");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: "+ d);

            long h = d;
            Console.WriteLine("h: "+ h);

            float f = h;
            Console.WriteLine("f: "+ f);

            string e = "Cagatay";
            char g = 'm';
            object k = g+e+d;

            Console.WriteLine("k: "+ k);

            // Explicit Conversion (Bilinçli Dönüşüm) -- Veri tiplerinin aynı seviyede yada daha düşük seviyedeki veri tipine manuel olarak dönüştürme işlemi.
            Console.WriteLine("********** Explicit Conversion **********");

            int x = 4;
            byte y = (byte)x;
             Console.WriteLine("y: "+ y);

             int z = 100;
             byte t = (byte)z;
             Console.WriteLine("t: "+ t);

             float w = 10.3f;
             byte v = (byte)w;
             Console.WriteLine("v: "+ v);

            // ToString Dönüşümü
            Console.WriteLine("********** ToString Conversion **********");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+ yy);
            
            string zz = 12.5f.ToString();
            Console.WriteLine("zz: "+ zz);

            // System.Convert
            Console.WriteLine("********** Conversion with System.Convert Class **********");

            string s1 = "10", s2 = "25";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + Toplam);
            object type = zz.GetType();
            Console.WriteLine(type);
            
            // Parse
            Console.WriteLine("********** Conversion with  Parse Method **********");

            ParseMethod();
            
            

        }
        static void ParseMethod() {
            string m1 = "10";
            string m2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(m1);
            double1 = Double.Parse(m2);

            Console.WriteLine("Rakam : " + rakam1);
            Console.WriteLine("Double : " + double1);


        }
    }
}
