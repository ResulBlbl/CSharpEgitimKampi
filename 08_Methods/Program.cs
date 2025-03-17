using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = $"Ülke Adı:{countryName}\nBaşkenti:{capital}\nBayrağının Renkleri:{flagColor}";
                return cardInfo;
            }

            string x, y, z;
            Console.Write("Ülke Adı Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkentini Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrağının Renklerini Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x,y,z));


            #endregion
        }
    }
}
