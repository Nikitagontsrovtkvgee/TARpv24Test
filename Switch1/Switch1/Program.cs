using System.Drawing;

namespace Switch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 0; i < 1000; i++)
            {
                Color c = (Color)(new Random()).Next(0, 5);
                switch (c)
                {
                    case Color.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Red");
                        Console.Beep();
                        break;
                    case Color.Yellow:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.WriteLine("Yellow");
                        Console.Beep();
                        break;
                    case Color.Black:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Black");
                        Console.Beep();
                        break;
                    case Color.Magenta:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        Console.WriteLine("Magenta");
                        Console.Beep();
                        break;
                    case Color.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Green");
                        Console.Beep();
                        break;
                    case Color.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Blue");
                        Console.Beep();
                        break;
                    case Color.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("White");
                        Console.Beep();
                        break;
                    case Color.Orange:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("Orange");
                        Console.Beep();
                        break;
                    case Color.DarkBlue:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.WriteLine("DarkBlue");
                        Console.Beep();
                        break;
                    case Color.DarkGreen:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("DarkGreen");
                        Console.Beep();
                        break;
                    case Color.DarkCyan:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                        Console.WriteLine("DarkCyan");
                        Console.Beep();
                        break;
                    case Color.DarkRed:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.WriteLine("DarkRed");
                        Console.Beep();
                        break;
                    case Color.DarkYellow:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("DarkYellow");
                        Console.Beep();
                        break;
                    case Color.Gray:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("Gray");
                        Console.Beep();
                        break;
                    case Color.DarkGray:
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Console.WriteLine("DarkGray");
                        Console.Beep();
                        break;
                    case Color.Cyan:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine("Cyan");
                        Console.Beep();
                        break;
                    default:
                        break;
                }
                Console.ResetColor();
            }
        }
        public enum Color
        {
            Red, Green, Blue, White, Orange, Yellow, Black, Magenta, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkYellow, Gray, DarkGray, Cyan 
        }
    }
}