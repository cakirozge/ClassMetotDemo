using ClassMetotDemo;
using System;

namespace ClassMetotoDemo;

class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Id = 1;
        musteri1.Name= "Musteri 1";
        musteri1.Surname = " Musteri 1'in soyadı";
        musteri1.Age = 30;
        musteri1.TCKimlikNo = "11111111111";
        musteri1.City = "Giresun";

        Musteri musteri2 = new Musteri();
        musteri2.Id = 2;
        musteri2.Name = "Musteri 2";
        musteri2.Surname = "Musteri 2'nin soyadı";
        musteri2.Age = 18;
        musteri2.TCKimlikNo = "88888888888";
        musteri2.City = "İstanbul";

        Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

        foreach (Musteri musteri in musteriler)
        {
            Console.WriteLine(musteri.Id + ",  " + musteri.Name + ", " + musteri.Surname + ", " + musteri.Age + ", " + musteri.TCKimlikNo );
        }

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);
        musteriManager.Sil(musteri2);
        musteriManager.Sil(musteri1);
        musteriManager.Listele(musteri1);
        musteriManager.Listele(musteri2);
    }
}
