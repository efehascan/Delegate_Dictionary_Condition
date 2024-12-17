using System;
using System.Collections.Generic;


namespace Delegate_Dictionary
{


    delegate void DortIslem(); // Delegate tanımlaması

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci numarayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ikinci numarayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
                
            
            // Dictionary tanımlaması
            var islemSozlugu = new Dictionary<string, DortIslem>
            {
                ["topla"] = () => Console.WriteLine($"Toplama işlemi sonucu: { sayi1 + sayi2 }"),
                ["cikar"] = () => Console.WriteLine($"Çıkarma işlemi sonucu: { sayi1 - sayi2 }"),
                ["carp"] = () => Console.WriteLine($"Çarpma işlemi sonucu: { sayi1 * sayi2 }"),
                ["bolme"] = () => Console.WriteLine($"Bölme işlemi sonucu: { sayi1 / sayi2 }")
            };

            // Kullanıcıdan işlem seçmesini iste
            Console.WriteLine("Bir işlem seçiniz: topla, cikar, carp, bolme");
            string secilenIslem = Console.ReadLine();

            islemSozlugu[secilenIslem]();
        }
    }

}