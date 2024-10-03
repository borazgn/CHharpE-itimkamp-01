using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHharpEğitimkampı01
{
    internal class Program
    {
        static void Main(string[] args)


        {
            #region YazdırmaKomutları            



            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemek");
            //Console.WriteLine("3- Soğuk başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion




            #region String Değişkenler


            //string
            //Değşken_türü değşken_adı;

            //string name;
            //name = "Bora";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Bora";
            //customerSurname = "Zengin";
            //customerPhone = "+90 500 400 300 30 ";
            //customerEmail = "deneme@gmail.com";
            //district = "Ümraniye";
            //city = "İstanbul";

            //Console.WriteLine("*** Rezeervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 400 100 60 ";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");








            #endregion

            #region Int Değişkenler

            //Int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("---hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("---Kola: " + cokePrice);
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---Kızartma : " + friesPrice + " TL");
            Console.WriteLine("---Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyatı ***");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totallemonadePrice= lemonadeCount * lemonadePrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalhamburgerPrice + "TL ");
            Console.WriteLine("pizza Tutarı:" + totalpizzaPrice + "TL ");
            Console.WriteLine("kızartma Tutarı:" + totalfriesPrice + "TL ");
            Console.WriteLine("Kola Tutarı:" + totalcokePrice + "TL ");
            Console.WriteLine("Limonata Tutarı:" + totallemonadePrice + "TL ");
            Console.WriteLine("Su Tutarı:" + totalwaterPrice + "TL ");

            Console.WriteLine();
            int totalPrice=totalcokePrice+ totalwaterPrice+ totallemonadePrice+ totalhamburgerPrice+ totalpizzaPrice+ totalfriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL ");


















            #endregion


            Console.Read();

        }
    }
}
