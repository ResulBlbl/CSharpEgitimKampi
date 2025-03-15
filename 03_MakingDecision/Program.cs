using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            #region Ornek1
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            #endregion
            #region Ornek2
            //string capital, country;
            //Console.Write("Başkenti giriniz");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Başkent ve Ülke Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Başkent ve Ülke Yanlış");
            //}
            #endregion
            #region Ornek3
            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 85)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);
            #endregion
            #region Ornek4
            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}
            #endregion

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenleri ile Karar Yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("********** C# Eğitim Kampı Restoran ***********");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana Yemekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Hamsi Tava");
            //    Console.WriteLine("4-Fırında Somun");
            //    Console.WriteLine("-------------------Ana Yemekler---------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Çorbalar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("-------------------Çorbalar---------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Pizza---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------------------Pizza---------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------İçecekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Meyve Suyu");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("-------------------İçecekler---------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Tatlılar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Künefe");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("-------------------Tatlılar---------------------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi yapınız: ");
            //int monthnumber=int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak isstediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+': result = number1 + number2; Console.WriteLine("Toplam: " + result); break;
            //    case '-': result = number1 - number2; Console.WriteLine("Fark: " + result); break;
            //    case '*': result = number1 * number2; Console.WriteLine("Çarpım: " + result); break;
            //    case '/': result = number1 / number2; Console.WriteLine("Bölüm: " + result); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}

            #endregion

            Console.Read();
        }
    }
}
