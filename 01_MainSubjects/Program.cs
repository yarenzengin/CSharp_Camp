using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.Write("Merhaba Dünya"); yazıyı yazdıktan sonra imleci değerin en sağına atar
            //Console.WriteLine("Selam"); değerden sonra imleci alt satıra indirir

            //Console.WriteLine("***Yemek Kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***Yemek Kategorileri***");
            #endregion

            #region StringDegiskenler
            //değisken_türü değisken_adi;
            //string name;
            //name = "Yaren";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Berke";
            //customerSurname = "Zengin";
            //customerPhone = "+90 500 000 0000";
            //customerEmail = "berke@gmail.com";
            //district = "Ataşehir";
            //city = "İstanbul";

            //Console.WriteLine("***Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres" + district + "/" + city);
            //Console.WriteLine("---------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 100 0000";
            //customerEmail = "ayse@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres" + district + "/" + city);
            //Console.WriteLine("---------------------");

            #endregion

            #region IntDegiskenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 250;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 80;
            int pizzaPrice = 250;
            int lemonadePrice = 50;


            Console.WriteLine("***Restoran Menü Fiyatı***");
            Console.WriteLine();
            Console.WriteLine("---Hambuger: " + hamburgerPrice + " TL ");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("---Kola: " + cokePrice + " TL ");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("---Su: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("***Restoran Menü Fiyatı***");

            Console.WriteLine();
            int hambugerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount; 
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hambugerCount = 3;
            cokeCount= 3;
            waterCount= 3;
            friesCount= 2;
            pizzaCount= 1;
            lemonadeCount= 1;

            totalHamburgerPrice = hambugerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice  = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalFriesPrice + totalCokePrice + totalWaterPrice 
                             + totalHamburgerPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam tutar: " + totalPrice + "TL");

            #endregion
            Console.Read(); //tuşa basana kadar ekranı bekletecek olan kod

        }
    }
}


//Program sınıfı uygulamanın başta çalışacağı sınıf
//Ram de geçici olarak tutulan programalam değerleri > değişkenler
//hiyerarşik bir yapı var üstten aşağı okur