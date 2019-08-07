using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _02_Adam_Asmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            char restart = '\0';
            do
            {Console.Clear();
                Random rnd = new Random();
                string[] city = {
                    "çorum","istanbul","ankara", "sinop", "siirt",
                    "samsun","balıkesir","halep","şam","rakka"};
                string randomCity = city[rnd.Next(city.Length)];

                int life = 5; 
                bool flag = false;
                char harf = '\0';
                char[] guess = new char[randomCity.Length * 2];
                for (int j = 0; j < randomCity.Length; j++)
                {
                    guess[2 * j] = '-';
                    guess[2 * j + 1] = ' ';
                }

                int sayac = randomCity.Length;
                do
                {

                    flag = false;
                    for (int i = 0; i < guess.Length; i++)
                    {
                        Console.Write(guess[i]);
                    }

                    Console.WriteLine();
                    Console.Write("Tahmin : ");
                    harf = char.Parse(Console.ReadLine());
                    for (int i = 0; i < randomCity.Length; i++)
                    {
                        if (randomCity[i] == harf)
                        {
                            guess[2 * i] = harf;
                            sayac--;
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        life--;
                        Console.WriteLine("{0} CANIN KALDI..",life);
                    }
                } while (sayac > 0 && life > 0);
                Console.WriteLine();

                if (sayac == 0)
                {
                    Console.WriteLine($"HELAL LAN DOĞRU CEVAP : {randomCity}");
                }
                else
                {
                    Console.WriteLine("BAŞARISIZ . ŞEHİR : {0}",randomCity);
                }

                Console.WriteLine();
                Console.WriteLine("TEKRAR OYNAMAK İSTER MİSİNİZ ? (Y/N)");
                 restart = char.Parse(Console.ReadLine());
            } while (restart!='n');
            
               
               
            
            Console.ReadKey();
        }
    }
}
