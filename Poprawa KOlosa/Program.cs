using System;

namespace Poprawa_KOlosa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokosc Liter A: ");

            int wysokosc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------");

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Podałes wysokosc " + wysokosc +" Liter");

            int a = 1;
            int b = wysokosc;
            int c = 0;
            int d = wysokosc;

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < wysokosc * 2; j++)
                {
                    if (i == a & j == b)
                    {
                        Console.Write("{0}", "A");
                        a++;
                        b++;
                    }
                    if (i == c & j == d)
                    {
                        Console.Write("{0}", "A");
                        d--;
                        c++;
                    }
                    if (i == wysokosc / 2 & j < Math.Abs(wysokosc - 1) + Math.Abs(wysokosc) / 2 & j > Math.Abs(wysokosc - 1) / 2)
                    {
                        Console.Write("{0}", "A");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }

                Console.Write("\n");
                
            }

            Console.WriteLine("Oto twoja Piramida");
        }
        
    }
}