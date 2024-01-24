using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi." + " Musterinin Adi: " + musteri.Name + 
                ", Musterinin Soyadı:" + musteri.Surname + 
                ", Musteri Yas:" + musteri.Age + ", TC Kimlik No: " + musteri.TCKimlikNo);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine( "Müşteri bilgileri silindi." + " ,Musteri adi: " + musteri.Name + "Musteri Yas: " + musteri.Age);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgisi listelendi." + " ,Musteri adi: " + musteri.Name + ", Şehir: " + musteri.City);
        }

    }
}
