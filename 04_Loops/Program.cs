﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine(totalValue);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            #endregion

            #region While Döngüsü

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklar toplamını bulan kodu yazınız.

            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds, sum;

            //ones = number % 10;
            //tens= (number % 100)/10;
            //hundreds = number / 100;

            //Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
