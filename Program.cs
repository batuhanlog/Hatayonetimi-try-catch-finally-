using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
            Console.WriteLine("Hello, World!");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş oldugunuz sayi :" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : "+ ex.Message.ToString());
            }
            //finally
            //{
             //   Console.WriteLine("İşlem tamamlandı :");
            //}
           try
           {
           // int a = int.Parse(null);
           // int a = int.Parse("test");
           int a = int.Parse("-20000000");

           }
           catch (ArgumentNullException ex)
           {
            Console.WriteLine("boş değer girdiniz : ");
            Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
            Console.WriteLine("Veri Tipi Uygun Değil ");
            Console.WriteLine(ex);
           }
            catch (OverflowException ex)
           {
            Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz. ");
            Console.WriteLine(ex);
           }
          finally{
            Console.WriteLine("İşlem başarılı");
          }


           
        }
    }
}
