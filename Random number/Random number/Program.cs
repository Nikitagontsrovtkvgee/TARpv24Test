namespace Random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int cube = new Random().Next(1, 6);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said 1 ja oled been elemenated by 16 autistic clouns");
                    break;
                case 2:
                    Console.WriteLine("Said 2 ja oled magus Pruun šokolaadikene");
                    break;
                case 3:
                    Console.WriteLine("Said 3 ja oled paha");
                    break;
                case 4:
                    Console.WriteLine("Said 4 ja oled neetud");
                    break;
                case 5:
                    Console.WriteLine("Said 5 ja oled streamer viis fänn");
                    break;
                case 6:
                    Console.WriteLine("Said 6 ja Jumal suudles sinu perse");
                    break;
                default:
                    break;
            }
        }
    }
}
