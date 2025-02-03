using System;
using System.Drawing;

namespace ifElsePutSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage size");
            int size = int.Parse(Console.ReadLine());

            if
               (size >= 30 && size <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teie jala suurus: {0}. Teksti värvus on roheline.", size);

            }
            else if (size >= 34 && size <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Teie jala suurus: {0}. Taust on valge.", size);
            }
            else if (size >= 39 && size <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Teie jala suurus: {0}. Teksti värvus on kollane.", size);
            }
            else if (size >= 45 && size <= 48)
            {
                Console.Beep();
                Console.WriteLine("Teie jala suurus: {0}. Beep (beep).", size);
            }
            else
            {
                Console.WriteLine("Teadmata jalanõude suurus.");
            }
            Console.ResetColor();
        }
    }
}
