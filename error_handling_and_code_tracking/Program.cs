using System;

namespace error_handling_and_code_tracking
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı girin : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception e)
            {

                Console.WriteLine("Hata : " + e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }

            try
            {
                int a = int.Parse("test");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine("Hata : " + ane.Message.ToString());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine("Hata : " + fe.Message.ToString());
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                Console.WriteLine("Hata : " + oe.Message.ToString());
            }
        }
    }
}


