using System.Runtime.InteropServices;

namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Insert first number and press enter:");
            //string tuleb konvertida int andmetüüpiks
            int firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int calculationType = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number and press enter:");
            //string tuleb konvertida int andmetüüpiks
            float secondNr = float.Parse(Console.ReadLine());

            float result = 0;

            switch (calculationType)
            {
                case 1:
                    //tuleb ära lahendada see viga
                    result = secondNr + firstNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
                    break;

                case 2:
                    result = secondNr - firstNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
                    break;

                case 3:
                    result = secondNr * firstNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
                    break;

                case 4:
                    result = secondNr / firstNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                    break;

                default:
                    Console.WriteLine("You are stupid nigga");
                    break;
            }
        }
    }
}
