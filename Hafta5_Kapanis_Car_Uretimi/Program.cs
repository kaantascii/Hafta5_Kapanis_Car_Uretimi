using Hafta5_Kapanis_Car_Uretimi;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            // Kullanıcıdan araba üretmek isteyip istemediğini sor
            Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
            string cevap = Console.ReadLine().Trim().ToUpper();
            
            // Kullanıcının girdiği cevabı kontrol et
            if (cevap == "H")
            {
                Console.WriteLine("Program sonlandırılıyor...");
                break;
            }
            else if (cevap != "E")
            {
                Console.WriteLine("Geçersiz giriş. Lütfen sadece 'E' veya 'H' yazınız.");
                continue;
            }
            // Yeni bir araba nesnesi oluştur

            Araba yeniAraba = new Araba();

            Console.Write("Arabanın Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Arabanın Markası: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Arabanın Rengi: ");
            yeniAraba.Renk = Console.ReadLine();

            Console.Write("Arabanın Modeli: ");
            yeniAraba.Model = Console.ReadLine();

            // Kapı sayısını alırken hata kontrolü yap
            while (true)
            {
                Console.Write("Arabanın Kapı Sayısı: ");
                string giris = Console.ReadLine();

                try
                {
                    // Kapı sayısı sayısal bir değer olmalıdır
                    yeniAraba.KapiSayisi = int.Parse(giris);
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş! Kapı sayısı sayısal bir değer olmalıdır.");
                }
            }

            // Araba üretildiğinde listeye ekle
            arabalar.Add(yeniAraba);
            Console.WriteLine(" Araba başarıyla üretildi!\n");

            // Kullanıcıya başka bir araba üretmek isteyip istemediğini sor
            Console.Write("Başka bir araba üretmek istiyor musunuz? (E/H): ");
            string tekrar = Console.ReadLine().Trim().ToUpper();

            if (tekrar == "H")
                break;
        }
        // Program sonlandırıldıktan sonra üretilen arabaları listele
        Console.WriteLine("\n Üretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri No: {araba.SeriNumarasi}, Marka: {araba.Marka}, Model: {araba.Model}");
        }
    }
}
