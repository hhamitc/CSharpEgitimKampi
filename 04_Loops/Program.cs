﻿using System;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            // for(x;y;z)
            //x=başlanhıç
            //y=bitiş
            //z=artış/azalış

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ekrana yazılmasını istediğiniz adedi giriniz.");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totaValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totaValue += i;
            //}
            //Console.WriteLine(totaValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);

            //int count = 0;  // 1-50 arası 7 ye tam bölünenkaç sayı var

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine($"{i}.Saat Sonunda: {bacterium} olur.");
            //}
            #endregion

            #region While Döngüsü
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba While");
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
            // Klavyeden girilen 3 basamaklı bir sayının basamakları toplamını hesaplayan kodu yazın.
            //456


            //Console.WriteLine("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;

            //hundred = number / 100;
            //ones = number % 10;
            //tens = (number % 100) / 10;

            //sum = ones + tens + hundred;

            //Console.WriteLine($"{ones} + {tens} + {hundred} ");
            //Console.WriteLine(sum);


            #endregion



            Console.Read();
        }
    }
}
