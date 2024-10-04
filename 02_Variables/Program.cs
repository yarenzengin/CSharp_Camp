using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("***Fiyat Listesi***");
            Console.WriteLine();

            double applePrice, orangePrice, strawPrice, potatoPrice, tomatoPrice;
            applePrice = 14.32;
            orangePrice = 23.03;
            strawPrice = 30.85;
            potatoPrice = 5.56;
            tomatoPrice = 6.88;


            Console.WriteLine("--Elma Birim Fiyatı:" + applePrice + "TL" );
            Console.WriteLine("--Portakal Birim Fiyatı:" + orangePrice + "TL" );
            Console.WriteLine("--Çilek Birim Fiyatı:" + strawPrice + "TL" );
            Console.WriteLine("--Patates Birim Fiyatı:" + potatoPrice + "TL" );
            Console.WriteLine("--Domates Birim Fiyatı:" + tomatoPrice + "TL" );


            double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawTotalPrice = strawGram * strawPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice 
                                + "- Gramaj: " + appleGram + "- Toplam Tutar: " + appleTotalPrice + "TL ");       
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice
                                + "- Gramaj: " + orangeGram + "- Toplam Tutar: " + orangeTotalPrice + "TL ");       
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawPrice
                                + "- Gramaj: " + strawGram + "- Toplam Tutar: " + strawTotalPrice + "TL ");         
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice
                                + "- Gramaj: " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice + "TL "); 
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice
                                + "- Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice + "TL ");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş toplam tutar: " + shoppingTotalPrice + "TL");
            #endregion

            #region CharDegiskenler

            //ABCDEFGH
            //+ 3 sonra harfi ekliyor yani A yerine D
            // ''

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirisleri_StringDegiskenler
            Console.WriteLine("*** THY Yolcu Bilgisi ***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerID,
                   , passengerDistrict, passengerCity, passengerAge;

            Console.Write("Yolcu Adı: " );
            passengerName = Console.ReadLine();
            
            Console.Write("Yolcu Soyadı: " );
            passengerSurname = Console.ReadLine();
            
            Console.Write("İlçe Bilgisi: " );
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: " );
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: " );
            passengerAge = Console.ReadLine();
            
            Console.Write("Yolcu TC No: " );
            passengerID = Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine("----------------------");

            Console.WriteLine("Yolcu TC No: " + passengerID + "- Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + 
                               passengerDistrict + "/" + passengerCity + " " + passengerAge );

            #endregion

            #region KlavyedenTamSayiGirisleri_Donusumler

            int shoesPrice, pcPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            pcPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, pcCount, chairCount, tvCount;
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine()); // int e çevirme

            Console.Write("Lütfen aldığınız PC sayısını giriniz: ");
            pcCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            
            Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());
            
            int totalPrice = (shoesCount * shoesPrice) + (pcCount * pcPrice) +
                                (chairCount * chairPrice) + (tvCount * tvPrice);

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + "TL");
            #endregion

            #region KlavyedenDoubleSayıIslemleri

            double exam1, exam2 , exam3, result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            
            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine()); 
            
            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);
            #endregion

            #region KlavyedenKarakterGirisleri
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz :" );
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
            Console.Read();

        }
    }
}
 