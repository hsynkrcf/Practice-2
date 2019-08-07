using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _01___Simple_Öğrenci_Otomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            string[] students = new string[0];
            ConsoleKeyInfo tus = new ConsoleKeyInfo();
            string value;
            Console.WriteLine("HÜSEYİN ÖĞRENCİ İŞLERİNE HOŞGELDİN!\nBAŞLAMAK İÇİN ENTER'A BASIVER :)");
            while (Console.ReadLine() != "n" || Console.ReadLine() == "y")
            {
                Console.Clear();
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrenci Listele");
                Console.WriteLine("3. Öğrenci Sil");
                Console.WriteLine("4. ÇIKIŞ ");
                Console.Write("SEÇİM YAPINIZ : ");
                bool check = int.TryParse(Console.ReadLine(), out secim);

                if (check)
                {
                    Console.Clear();
                    switch (secim)
                    {

                        case 1:

                            Console.WriteLine("ÖĞRENCİ EKLE BÖLÜMÜNÜ SEÇTİNİZ!\n" +
                                              "***********************************");
                            Console.WriteLine("ÇIKMAK İÇİN ENTER'A BASINIZ!!");
                            do
                            {
                                Console.Write("Öğrenci Adı : ");
                                value = Console.ReadLine();
                                Array.Resize(ref students, students.Length + 1);
                                students[students.Length - 1] = value;
                                tus = Console.ReadKey(true);
                            } while (tus.Key != ConsoleKey.Enter);

                            Console.WriteLine("BAŞKA BİR İŞLEM YAPMAK İSTİYOR MUSUNZ ? (Y/N)");
                            break;
                        case 2:
                            Console.WriteLine("ÖĞRENCİ LİSTELE BÖLÜMÜNÜ SEÇTİNİZ!\n" +
                                              "***********************************");
                            Console.WriteLine("ÖĞRENCİLERİ LİSTELİYORUM");
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine(students[i]);
                            }
                            Console.WriteLine("BAŞKA BİR İŞLEM YAPMAK İSTİYOR MUSUNZ ? (Y/N)");
                            break;
                        case 3:
                            Console.WriteLine("ÖĞRENCİ SİL BÖLÜMÜNÜ SEÇTİNİZ!\n" +
                                              "***********************************");
                            Console.WriteLine("ÖĞRENCİLERİ LİSTELİYORUM");
                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i] != " ")
                                {
                                    Console.WriteLine(students[i]);
                                }
                            }
                            Console.Write("Silmek İstediğiniz Öğrenci Sırası : ");
                            bool check2 = int.TryParse(Console.ReadLine(), out secim);
                            if (check2)
                            {
                                Array.Clear(students, secim - 1, 1);
                                Console.WriteLine($"{secim} numaralı öğrenci silindi.");
                                for (int i = 0; i < students.Length; i++)
                                {
                                    Console.WriteLine(students[i]);
                                }

                            }
                            else
                            {
                                Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ!!");
                            }
                            Console.WriteLine("BAŞKA BİR İŞLEM YAPMAK İSTİYOR MUSUNZ ? (Y/N)");
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("YANLIŞ SEÇİM");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Sayı İle Seçim Yapınız..");
                }
            }

        }
    }
}
