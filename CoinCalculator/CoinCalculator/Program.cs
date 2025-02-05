namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine("Maa ümbermõõt: " + aroundEarth);

            //nüüd arvutame mühtide arvu
            double result = aroundEarth / coinDiameter;

            Console.WriteLine("Ümber maa mahub nii" +
                "palju kahe euroseid " + result);

        }
    }
}
