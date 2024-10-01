﻿using System;
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

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice =  14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma birim fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal birim fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek birim fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates birim fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates birim fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleKilo, orangeKilo, strawberryKilo, potatoKilo, tomatoKilo;

            //appleKilo = 1.245;
            //orangeKilo = 2.650;
            //strawberryKilo = 0.750;
            //potatoKilo = 4.859;
            //tomatoKilo = 3.745;

            //double appleTotalPrice = appleKilo * applePrice;
            //double orangeTotalPrice = orangeKilo * orangePrice;
            //double strawberryTotalPrice = strawberryKilo * strawberryPrice;
            //double potatoTotalPrice = potatoKilo * potatoPrice;
            //double tomatoTotalPrice = tomatoKilo * tomatoPrice;
            //Console.WriteLine($"Alınn ürün: Elma - Birim Fiyat: {applePrice} - Gramaj: {appleKilo} - Toplam Tutar: {appleTotalPrice}");
            //Console.WriteLine($"Alınn ürün: Portakal - Birim Fiyat: {orangePrice} - Gramaj: {orangeKilo } - Toplam Tutar: {orangeTotalPrice}");
            //Console.WriteLine($"Alınn ürün: Çilek - Birim Fiyat: {strawberryPrice} - Gramaj: {strawberryKilo} - Toplam Tutar: {strawberryTotalPrice}");
            //Console.WriteLine($"Alınn ürün: Patates - Birim Fiyat: {potatoPrice} - Gramaj: {potatoKilo} - Toplam Tutar: {potatoTotalPrice}");
            //Console.WriteLine($"Alınn ürün: Domates - Birim Fiyat: {tomatoPrice} - Gramaj: {tomatoKilo} - Toplam Tutar: {tomatoTotalPrice}");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice);
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine(); 

            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Yolcu TC Kimlik No: {passengerIdentityNumber} Yolcu Ad soyad: {passengerName} {passengerSurname} {passengerDistrict}/{passengerCity} {passengerAge} ");

            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount , tvCount ;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = (shoesCount * shoesPrice) + (computerCount*computerPrice) + (chairCount*chairPrice) + (tvCount*tvPrice);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz (E/K): ");
            //gender = char.Parse(Console.ReadLine().ToUpper());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
