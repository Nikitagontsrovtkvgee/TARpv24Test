namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvida valikuks on: red, blue; green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");
            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("red");


            }
        }
    }
}
