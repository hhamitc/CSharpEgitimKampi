using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            {   /*
                Console.Write("Lütfen şifreyi giriniz: ");
                string password;
                password = Console.ReadLine();
                if (password == "abcd")// karar yapılarından sonra ; konmaz. 
                {
                    Console.WriteLine("Şifre Doğru");
                }
                else 
                {
                    Console.WriteLine("Şifre Yanlış");
                }
                */
            }

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //Console.Write("Sayıyı giriniz: ");

            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "";

            //Console.Write("Sınav1: ");
            //exam1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = Convert.ToInt32(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuç Kötü";
            //}
            //if (avarage > 50 & avarage <= 84)
            //{
            //    result = "Sonuç orta";
            //}
            //if (avarage > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);




            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine().ToLower();

            //if (city == "adana" | city == "ankara" | city == "bursa")
            //{
            //    Console.Write("Şehir Mevcut.");
            //}
            //else
            //{
            //    Console.Write("Şehir Mevcut Değil.");
            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine().ToLower();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı geçersiz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı giriniz: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 1. Sayıyı giriniz: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları


            // Klavyeden girilen harfe göre takımı yazdıran  uygulama

            //char team;

            //Console.Write("Lüfen takım sembolünü giriniz: ");

            //team = Convert.ToChar(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş.");
            //}
            #endregion

            #region Örnek Proje Uygulaması


            //Console.WriteLine("****** C# Eğitim Kampı Restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğini menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("------Ana Yemekler------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------Ana Yemekler------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("------Çorbalar------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------Çorbalar------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("------Pizzalar------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------Pizzalar------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------İçecekler------");
            //}
            //if (menuItem == "5 ")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------Tatlılar------");
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi");
            //        break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.WriteLine("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default:
                    break;

            }


            #endregion

            Console.ReadKey();
        }
    }
}
