using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli atama operatörleri
            int x = 3;
            Console.WriteLine(x);
            int y = 3;
            Console.WriteLine(y);
            y += 2; // y = y + 2
            Console.WriteLine(y);
            y /= 5; // y = y / 5
            Console.WriteLine(y);
            x *= 7; // x = x * 7
            Console.WriteLine(x);
            Console.WriteLine("-------------------------------------------------------------------");

            // Aritmetik operatörler (4 işlem, artırma, azaltma, mod alma  operatörleri)
            // % mod alma (bölme işleminde kalan)
            // ++ : artırma  -- : azaltma

            int z = 4;
            x = y + z;
            Console.WriteLine(x);
            int sdf = x++;
            Console.WriteLine(sdf);
            
            int sonuc2 = x % y;
            Console.WriteLine(sonuc2);


            Console.WriteLine("-------------------------------------------------------------------");

            
            // Mantıksal Operatörler
            // && , || , !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){ // && operatörü iki şartın ikisinin de true olması durumunda yazılan komutu çalıştırır. 
                Console.WriteLine("Perfect!"); 
            }
            if(isSuccess || isCompleted) // || operatörü iki şartın birinin true olması durumunda yazılan komutu çalıştırır.
            {
                Console.WriteLine("Great!");
            }
            if(isSuccess && !isCompleted){ // ! operatörü bool değerinin zıttını alır. Örn: x = true; !x = false
                Console.WriteLine("Fine!");
            }

            Console.WriteLine("-------------------------------------------------------------------");
            // İlişkisel Operatörler
            // < , > , <= , => , == , !=
            
            int a = 5;
            int b = 12;
            int c = 18;

            bool sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = c < a;
            Console.WriteLine(sonuc);
            sonuc = b != 5;
            Console.WriteLine(sonuc);
            Console.WriteLine("-------------------------------------------------------------------");
            
        }
    }
}
