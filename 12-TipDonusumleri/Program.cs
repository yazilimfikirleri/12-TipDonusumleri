using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string metinselDeger = "123";//metinsel

            //int intDeger = metinselDeger;

            //Convert
            //int intDeger = Convert.ToInt32(metinselDeger);
            //byte byteDeger = Convert.ToByte(metinselDeger);
            //short shortDeger = Convert.ToInt16(metinselDeger);

            //int toplam = intDeger + 2;

            //Console.WriteLine(toplam);
            //Console.Read();

            int sayi1;
            int sayi2;
            int toplam;

            //Convert
            Console.WriteLine("Sayı1 değerini giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2 değerini giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam= " + toplam);
            Console.Read();

            //Parse
            int intParse = int.Parse(metinselDeger);
            byte byteParse = byte.Parse(metinselDeger);



        }
    }
}
