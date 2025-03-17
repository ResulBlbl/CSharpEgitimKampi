using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //int[] numbers = { 121, 31, 5, 15, 154, 11, 112, 1184, 5, 45, 152, 488 };

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int>()
            //{
            //    2,63,85,445,12
            //};

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string a = "Hello World";
            //foreach (char item in a)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenciniz var:");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu alınacak
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:  ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value;//notları toplama
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }//Sınav ortalamarı
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrencilerin oratalması ve geçip kalma durumları
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti") ;
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("-----------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
