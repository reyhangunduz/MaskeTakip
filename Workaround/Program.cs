using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
           //Vatandas vatandas1 = new Vatandas();

            SelamVer("Tom");
            SelamVer();
            int sonuc = Topla(3, 5);

            //Diziler (Array)

            string ogrenci1 = "Ayşe";
            string ogrenci2 = "Fatma";
            string ogrenci3 = "Hayriye";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ayşe";
            ogrenciler[1] = "Fatma";
            ogrenciler[2] = "Hayriye";

            ogrenciler = new string[4];
            ogrenciler[3] = "Pelinsu";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine         (ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "İstanbul", "Ankara", "Balıkesir" };
            string[] sehirler2 = new[] { "Muş", "Batman", "Van" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            sayi2 = 10;

            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123456789;

            Person person2 = new Person();
            person2.FirstName = "Jeyn";
            
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine (sehir);
            }
            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "Bursa1" };
            yeniSehirler1.Add("Adana1");
            foreach(var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(string isim ="İsimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1+ sayi2;
            Console.WriteLine("Toplam:"+sonuc.ToString());
            return sonuc;
        }
        
        private static void Degiskenler()
        {
            //string mesaj = "Merhaba";
            //double tutar = 1000;
            //int sayi = 100;
            //bool girisYapildiMi = false;

            //string ad = "John";
            //string soyad = "Doe";
            //int dogumYili = 2003;
            //long TCKN = 123456789;

            //Console.WriteLine(mesaj);
            //Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TCKN { get; set;}
    }
}